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
	def __init__(self, path, frame):
		"""
		Keyword Arguments:
		path  -- Path to the .blend file.
		frame -- Set frame to render.

		"""

		# Assign Private Vars
		self.path = path
		self.frame = frame

		# Error Check Vars
		self.errors = []
		self.errors += isPath()

	# Input Checkers
	def isPath(self, path):

