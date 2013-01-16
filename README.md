Fast12
=============
A Python tool that aims to simplify batch, remote, and distributed rendering by using Blender's build in command line
arguments. The tool accepts a JSON formatted file (with the extension .job) with the render configuration, and which contains the local file location. The tool will then generate and run the corresponding command line argument to Blender. 

In the future, this tool will be expanded with a GUI to do the following:
* Allow for users to easily create and run batch Blender render jobs.
* Allow for users to easily run Blender render jobs on remote computers.

Requirements
-------
* Blender 2.65a - [Download Now](http://www.blender.org/download/get-blender/)
* Python 3.2 - [Download Now](http://www.python.org/download/releases/3.2/)

Summary
-------
The FastF12 tool is dependent on the current implementation of Blender's command line arguments. There have been slight changes in the number of commands between major Blender releases. This tool will follow the current implementation of command line arguments in Blender 2.65a as detailed by [the official documentation](http://wiki.blender.org/index.php/Doc:2.6/Manual/Render/Command_Line).

The current supported command line arguments are:

	blender [-b <dir><file> [-o <dir><file>][-F <format>] [-x [0|1]][-t <threads>][-S <name>][-f <frame>] [-s <frame> -e <frame> -a]] [[-P <scriptname> [-- <parameter>]]

A JSON formatted config file, as sampled below, contains all the relevant fields to generate a command of the latter format.
For single frame render, only the .blend file and frame to render are required. Likewise for an animation render, only the .blend file and the range of frames to render are required. All other fields are optional. A simple sample .job config file is below:

	{
	    "file": "default.blend",
	    "render-output": "/render",
	    "type": "Single",
	    "frame": "1"
	}

This will produce the following command, which is then monitored, and run by the tool. 

	blender -b default.blend -o /render -f 1

Job Files
-------
All JSON file field names are taken from the [Blender 2.5 Command Line Arguments Documentation](http://wiki.blender.org/index.php/Dev:2.5/Doc/Command_Line_Arguments). Type is the only special field, so that the tool can distinguish between an single frame render, and an animation render. 

###JSON Fields

* file
* render-output
* type
* format
* use-extension
* threads
* scene
* frame
* frame-start
* frame-end