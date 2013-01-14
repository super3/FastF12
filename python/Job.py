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
	def __init__(self, path, out_path, frame):
		"""
		Keyword Arguments:
		path  -- Path to the .blend file.
		frame -- Set frame to render.

		"""

		# Assign Private Vars
		self.path = path
		self.out_path = out_path
		self.frame = frame

		# Error Check Vars
		self.errors = []

	# Input Checkers
	def isPath(self):
		return os.path.isfile(self.path)

	# Command Builder
	def cmdstr(self):
		cmd = "\"C:\\Program Files\\Blender Foundation\\Blender\\blender.exe\""
		cmd += " -b " + self.path 
		cmd += " -o " + self.out_path
		cmd += " -f " + str(self.frame)
		return cmd

	# Command Runner
	def run(self):
		print(self.cmdstr())
		os.system(self.cmdstr())

# Main
if __name__ == "__main__":
	blend_path = "C:\\Users\\super_000\\Desktop\\default.blend"
	out_path = "C:\\Users\\super_000\\Desktop\\"
	frame = 1
	testjob = Job(blend_path, out_path, frame)
	testjob.run()