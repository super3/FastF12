# ------------------------------------------------------------
# Filename: Job.py
#
# Author Website: http://super3.org/
# Author Email: me@super3.org
#
# Website: http://super3.org/
# Github Page: https://github.com/super3/FastF12
# 
# Creative Commons Attribution 3.0 Unported License
# http://creativecommons.org/licenses/by/3.0/
# ------------------------------------------------------------

import os
import json

class Job:
	"""
	Renders an .blend file, and processes/stores infromation
	from the console output during rendering.
	
	Based off of the Blender 2.6 Command Line Implementation: 
	http://wiki.blender.org/index.php/Doc:2.6/Manual/Render/Command_Line
	
	"""
	def __init__(self, blender_path, job_path):
		"""
		Data Members:
		blender_path  -- Path to blender.exe (absolute path)
		job_path   	  -- Path to the .job file which contains the render config (absolute path)
		file_path     -- Path to the .blend file which to render (absolute path)
		
		ren_path   -- Path which to output the render results (relative path)
		ren_type   -- 'Single' or 'Animation' render
		ren_format -- Set the render format. See Blender Command Line Doumentation
				      for accepted values.
		
		scene      -- Scene to render
		frame      -- Frame to render (start frame if animation)
		end_frame  -- End frame to render (animation only)
					  
		use_ext    -- Boolean. Add or omit the file extension
		threads    -- Amount of process treads to use for rendering
		
		"""
		
		# Check/Load contructor input
		self.check_paths(blender_path, job_path)
		# Check/Load .job file
		self.load_job()
		# Check/Load .blend file
		self.check_file()
		# Check/Load rest of .job file data
		self.load_obj()
	
	
	# Constructor Methods	
	def check_paths(self, blender_path, job_path):
		"""Make sure the blender.exe and job file paths are both valid."""
		if not os.path.isfile(blender_path):
			raise IOError("Blender.exe '{0}' not found...".format(blender_path))
		elif not os.path.isfile(job_path):
			raise IOError("Job File '{0}' not found...".format(job_path))
		else:
			self.blender_path = blender_path
			self.job_path = job_path
			
	def load_job(self):
		"""Load JSON data from raw job file."""
		job_raw = open(self.job_path)
		self.job_data = json.load(job_raw)
		
	def check_file(self):
		"""Make sure .blend file path is valid."""
		self.file_path = self.job_data['path']
		if not os.path.isfile(self.file_path):
			raise IOError(".Blend '{0}' not found...".format(self.file_path))
	
	def load_obj(self):
		"""Fill object with data members according to the job file."""
		
		# Raw Data from JSON
		self.ren_out = self.get_jkey('render-output')
		self.ren_type = self.get_jkey('render-type')
		self.ren_format = self.get_jkey('format')
		self.scene = self.get_jkey('scene')
		self.frame = self.get_jkey('frame')
		self.end_frame = self.get_jkey('frame-end')
		self.use_exts = self.get_jkey('use-extension')
		self.threads = self.get_jkey('threads')
		
		# Validate Data Here
		self.val_ren_path()
		self.val_ren_type()
		self.val_ren_format()
		self.val_int()
		self.val_ext()
		
	def get_jkey(self, jkey):
		"""Try to load JSON key value or return None"""
		try: return self.job_data[jkey]
		except KeyError: return None
		
		
	# Validate Methods
	def val_ren_path(self):
		"""Validate render path."""
		if not self.ren_out == None and not os.path.exists(self.ren_out):
			raise ValueError("Invalid render path")
			
	def val_ren_type(self):
		"""Validate render type."""
		if not self.ren_type == None:
			print(self.ren_type.lower())
			if not self.ren_type.lower() == "single" and not self.ren_type.lower() == "animation":
				raise ValueError("Invalid render type")
				
	def val_ren_format(self):	
		"""
		Validate render format.
		
		Check the format option for formats support by Blender. All render formats from
		HDR onward are not supported by Blender by default.
		
		"""
		if not self.ren_format == None:
			formats = [ "TGA", "IRIS", "HAMX", "FTYPE", "JPEG", "MOVIE", "IRIZ",
						"RAWTGA", "VIRAW", "AVIJPEG", "PNG", "BMP", "FRAMESERVER",
						"HDR", "TIFF", "EXR", "MPEG", "AVICODEC", "QUICKTIME",
						"CINEON", "DPX" ]
		
			# Check from listed formats
			for item in formats:
				if item.find(format) != -1:
					return None
			raise ValueError("Invalid render format")
			
	def val_ext(self):
		"""Validate extension. Force correct format."""
		if not self.use_exts == None:
			self.use_exts = int(bool(self.use_exts))
			
	def val_int(self):
		"""Validate all numbers."""
		if not self.frame == None and not str(self.frame).isdigit():
			raise ValueError("Invalid frame")
		elif not self.end_frame == None and not str(self.end_frame).isdigit():
			raise ValueError("Invalid end frame")
		elif not self.threads == None and not str(self.threads).isdigit():	
			raise ValueError("Invalid threads")
		
		
	# Command Builder
	def add_val(self, dash_arg, val):
		"""Only add to the string if not none."""
		if not val == None:	return dash_arg + str(val)
		else: return ""

	def cmdstr(self):
		"""
		Creates the command line argument for Blender.

		Blender 2.6 Command Syntax:
			blender [-b <dir><file> [-o <dir><file>][-F <format>]
			[-x [0|1]][-t <threads>][-S <name>][-f <frame>]
			[-s <frame> -e <frame> -a]] [[-P <scriptname> [-- <parameter>]]

		"""

		cmd = "\"" + self.blender_path + "\""        	    # blender
		cmd += " -b " + self.file_path 		        	 	# -b <dir><file>
		cmd += " -o " + self.ren_out         				# -o <dir><file>
		#cmd += " -o " + os.getcwd() + self.ren_out        # -o <dir><file>
		
		cmd += self.add_val(" -F ", self.ren_format)        # -F <format>
		cmd += self.add_val(" -x ", self.use_exts)     		# -x [0|1]
		cmd += self.add_val(" -t ", self.threads)		    # -t <threads>
		cmd += self.add_val(" -S ", self.scene)			    # -S <name>

		if self.ren_type.lower() == "single":
			cmd += self.add_val(" -f ", self.frame)		    # -f <frame>
		elif self.ren_type.lower() == "animation":
			cmd += self.add_val(" -f ", self.frame)	
			cmd += self.add_val(" -e ", self.end_frame)	
			cmd += " -a "						            # -s <frame> -e <frame> -a

		# python scripts not added for now
			
		return cmd
	
		
# Unit Tests
if __name__ == "__main__":
	blender_path = "C:\\Program Files\\Blender Foundation\\Blender\\blender.exe"
	file_path = "C:\\Users\\shawn\\Desktop\\FastF12\\default.job"
	
	myjob = Job(blender_path, file_path)
	print(myjob.cmdstr())
	os.system(myjob.cmdstr())
	raw_input()