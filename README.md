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

Folders
-------
* /alpha-one/ - First working alpha of Fast12. Released, but not a polished product. Most of the base code is from this project.
* /alpha-two/ - Second alpha of FastF12. Was labeled FastF12 2.0, but was not completed. BlendJob wizards are taken from this project.
* /alpha-three/ - Current developmental build of FastF12. 
* /dev-docs/ - PDFs from Blender documentation on command line arguments. 
             
Todo
-------
- [ ] Write standard for JSON job file.