# BitBuggy Auth
BitBuggy Authentication & Authorization Server Implementation.
Implements OAuth2 according to standards, and uses authentication standards such as OIDC to create mappings.
Please note that this project is for EDUCATIONAL purposes. No responsibility is assumed for code being taken and repurposed for production environments.

# Contributing
If you wish to contribute to the project, then please refer to the contribution document.

# Running 
If you wish to run this application for testing purposes, then it's recommended you follow the steps below.

## Before Running
There are some steps that must be taken before the application can be ran on a development workstation, or deployed to a server.

### Connection String
A connection string is being used to connect to a PostgreSQL database under `ConnectionStrings:AuthDatabase`.
Please make sure that you have sent this connection string within your user secrets before continuing.