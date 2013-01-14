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

# Job Class
class Job:
	"""
	An object that accepts all the options for a render job, and then
	can return correct command line text. 

	Based off of the Blender 2.6 Command Line Implementation: 
	http://wiki.blender.org/index.php/Doc:2.6/Manual/Render/Command_Line

	"""

	# Constructor
	def __init__(self, path, out_path, format, isAni, start, end, frame):
		"""
		Keyword Arguments:
		path        -- Path to the .blend file.
		out_path    -- Path to place the rendered files.
		format      -- Set the render file format.
		frame       -- Set frame to render.
		isAni       -- Bool. Render animation instead of frame.
		start       -- Start frame of the animation render.
		end 	    -- End frame of the animation render. 

		"""

		# Private Vars
		self.path = path
		self.out_path = out_path
		self.format = format
		self.frame = frame
		self.isAni = isAni
		self.start = start
		self.end = end

	# Error Checking
	def validate(self):
		"""Error check the passed data."""
		
		# Error Message List
		errors = []

		# Error Check Class Data
		if not os.path.isfile(self.path):
			errors.append("Blend File Not Found.")
		if not os.path.exists(self.out_path):
			errors.append("Output Directory Not Found.")
		if not self.checkFormats(self.format):
			errors.append("Unsupported Render Format.")
		if not isinstance(self.frame, int):
			errors.append("Invalid Render Frame.")

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

		cmd = "\"" + pathToBlender + "\""   # blender
		cmd += " -b " + self.path 		    # -b <dir><file>
		cmd += " -o " + self.out_path       # -o <dir><file>
		cmd += " -F " + self.format         # -F <format>

		if not self.isAni:
			cmd += " -f " + str(self.frame) # -f <frame>
		else:
			cmd += " -s " + str(self.start)
			cmd += " -e " + str(self.end)
			cmd += " -a "					# -s <frame> -e <frame> -a

		return cmd

	# Command Runner
	def run(self, pathToBlender):
		if self.validate():
			os.system(self.cmdstr(pathToBlender))

# Main
if __name__ == "__main__":
	blend_path = "C:\\Users\\super_000\\Desktop\\default.blend"
	out_path = "C:\\Users\\super_000\\Desktop\\test\\"
	frame = 1
	testjob = Job(blend_path, out_path, "PNG", True, 1, 50, frame)
	testjob.run("C:\\Program Files\\Blender Foundation\\Blender\\blender.exe")