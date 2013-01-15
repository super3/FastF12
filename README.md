Fast12
=============
A Python tool that aims to simplify batch, remote, and distributed rendering by using Blender's build in command line
arguments. The tool accepts a JSON formatted file(with the extension .job) with the render configuration, and which contains the local file location. The tool will then generate and run the corresponding command line argument to Blender. 

The GUI subset of the tool will focus on two parts:
* Allow for users to easily create and run batch Blender render jobs.
* Allow for users to easily run Blender render jobs on remote computers using a 3rd party website.

Requirements
-------
* Blender 2.65a - [Download Now](http://www.blender.org/download/get-blender/)
* Python 3.2 - [Download Now](http://www.python.org/download/releases/3.2/)

Compatibility 
-------
The FastF12 tool is dependent on the current implementation of Blender's command line arguments. There have been slight changes in the number of commands between major Blender releases. This tool will follow the current implementation of command line arguments in Blender 2.65a as detailed by [this documentation](http://wiki.blender.org/index.php/Doc:2.6/Manual/Render/Command_Line).

Sample JSON Config Files
-------
	{
	    "source": "default.blend",
	    "lastName": "Smith",
	    "age": 25,
	    "address": {
	        "streetAddress": "21 2nd Street",
	        "city": "New York",
	        "state": "NY",
	        "postalCode": 10021
	    },
	    "phoneNumber": [
	        {
	            "type": "home",
	            "number": "212 555-1234"
	        },
	        {
	            "type": "fax",
	            "number": "646 555-4567"
	        }
	    ]
	}