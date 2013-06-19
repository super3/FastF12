# ------------------------------------------------------------
# Filename: FastF12Client.py
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
import random
import hashlib
from Job import Job
from time import sleep

class FastF12Client:
	"""
	Retrives jobs from an external server.

	Data Members:
	client_key -- A key generated at runtime so client can uniquely identify itself
				  to the server.
	server_key -- A key that is passed to the client so it can know which render 	
				  pool it is a part of.
				  
	"""
	def __init__(self):
		self.client_key = self.gen_client_key()
		self.server_key = None
		
	# Validation Method
	def check_sha256(self, hash):
		pass
	
	# Key Method
	def gen_client_key(self):
		"""Generates a unique client key."""
		gen_key = str(random.random())
		return hashlib.sha256(gen_key).hexdigest()[:66]
		
	# API
	def get_jobs(self):
		"""Retrieves null or job file."""
		API_URL = "http://example.com/api/getwork/{server_key}/{client_key}"
		return API_URL.format(server_key=self.server_key, client_key=self.client_key)
		
	def run(self, cmd_server_key, check_rate = 30):
		"""Queries server for job."""
		# validate server key is sha hash
		print("\nFastF12 Client now Running...(Use Ctrl+C to exit)")
		while True:
			self.get_jobs()
			sleep(check_rate) # pause for 'check_rate' seconds
						
		
if __name__ == "__main__":
	# Get Server Key(argsparse)
	# Start Client
	client = FastF12Client()
	client.run("testnet")