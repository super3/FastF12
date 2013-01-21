# ------------------------------------------------------------
# Filename: Job.py
#
# Author: Shawn Wilkinson
# Author Website: http://super3.org/
# Author Email: me@super3.org
#
# Website: http://super3.org/
# Github Page: https://github.com/super3/FastF12
# 
# Creative Commons Attribution 3.0 Unported License
# http://creativecommons.org/licenses/by/3.0/
# ------------------------------------------------------------

# Imports
import os
import json
from pprint import pprint

# Job Class
class Job:
	"""
	An object that accepts all the options for a render job, and then
	can return correct command line text. 

	Based off of the Blender 2.6 Command Line Implementation: 
	http://wiki.blender.org/index.php/Doc:2.6/Manual/Render/Command_Line

	"""

	# Constructor
	def __init__(self, path, render_type, render_output, frame = 1, frame_start = 1, frame_end = 250, format = None, use_extension = None, threads = None, scene = None):
		"""
		Keyword Arguments:
		path - Relative file path to the .blend file
		render-output - Directory to output the render results
		render_type - Single Frame or Animation Render. Accepted Values: "Single" or "Animation"
		format - Set the render format. See Blender Command Line Documentation for accepted values.
		use-extension - Add or omit the file extension to the end of the file. Accepted Values: "True" or "False"
		threads - Amount of threads to use for rendering
		scene -Scene to use
		frame - Frame to render
		frame-start - Start frame in animation to render
		frame-end - End frame in animation to render

		"""

		# Needed
		self.path = str(path)
		self.render_type = str(render_type)
		self.render_output = str(render_output)
		
		# Needed's Arguments
		self.frame = self.checkInt(frame)
		self.frame_start = self.checkInt(frame_start)
		self.frame_end = self.checkInt(frame_end)

		# Optional 
		self.format = self.checkStr(format)
		self.use_extension = self.checkBool(use_extension)
		self.threads = self.checkInt(threads)
		self.scene = self.checkStr(format)

	def checkInt(self, var):
		if var == None:
			return None
		return int(var)

	def checkBool(self, var):
		if var == None:
			return None
		return bool(var)

	def checkStr(self, var):
		if var == None:
			return None
		return str(var) 

	# Error Checking
	def validate(self):
		"""Error check the passed data."""
		
		# Error Message List
		errors = []

		# Check .Blend File
		if not os.path.isfile(self.path):
			errors.append("Blend File Not Found.")

		# Render Types
		if self.render_type == "Single":
			if not self.frame >= 1:
				errors.append("Invalid frame number.")

		elif self.render_type == "Animation":
			if self.frame_end > self.frame_start:
				errors.append("Invalid Animation Render Frames.")
		else:
			errors.append("Unsupported Render Type.")

		# Check Optional Files
		# if not os.path.exists(os.getcwd() + self.render_output):
		# 	errors.append("Output Directory Not Found.")
		if not self.format == None and not self.checkFormats(self.format):
			errors.append("Unsupported Render Format.")
		if not self.threads == None and not self.threads >= 1:
			errors.append("Invalid Thread Number.")

		# Return Validation
		if len(errors) <= 0:
			return True
		else:
			print(errors)
			return False

	# Checkers
	def checkFormats(self, format):
		"""Check the format option for formats support by Blender. All render formats from
		HDR onward are not supported by Blender by default."""

		formats = [ "TGA", "IRIS", "HAMX", "FTYPE", "JPEG", "MOVIE", "IRIZ", "RAWTGA", 
				     "VIRAW", "AVIJPEG", "PNG", "BMP", "FRAMESERVER", "HDR", "TIFF", "EXR"
				     "MPEG", "AVICODEC", "QUICKTIME", "CINEON", "DPX" ]

		for item in formats:
			if item.find(format) != -1:
				return True
		return False

	# Command Builder
	def cmdstr(self, pathToBlender):
		"""
		Uses the passed data to create a string to pass to a command line.

		Blender 2.6 Command Syntax:
			blender [-b <dir><file> [-o <dir><file>][-F <format>]
			[-x [0|1]][-t <threads>][-S <name>][-f <frame>]
			[-s <frame> -e <frame> -a]] [[-P <scriptname> [-- <parameter>]]

		"""

		cmd = "\"" + pathToBlender + "\""        			# blender
		cmd += " -b " + self.path 		        		 	# -b <dir><file>
		cmd += " -o " + os.getcwd() + self.render_output    # -o <dir><file>
		# cmd += " -F " + self.format             		    # -F <format>
		# cmd += " -x " + str(self.use_extension)           # -x [0|1]
		# cmd += " -t " + str(self.threads)		            # -t <threads>
		# cmd += " -S " + self.scene 			            # -S <name>

		if self.render_type == "Single":
			cmd += " -f " + str(self.frame)		            # -f <frame>
		else:
			cmd += " -s " + str(self.start)
			cmd += " -e " + str(self.end)
			cmd += " -a "						            # -s <frame> -e <frame> -a
 
		# omiting script option for now

		return cmd

	# Command Runner
	def run(self, pathToBlender):
		if self.validate():
			os.system(self.cmdstr(pathToBlender))
		else:
			print("Could not complete job.")

# Main
if __name__ == "__main__":
	# Load in JSON
	job_file=open('default.job')
	data = json.load(job_file)
	test_job = Job( data["path"], data["render-type"], data["render-output"])
	test_job.run("C:\\Program Files\\Blender Foundation\\Blender\\blender.exe")