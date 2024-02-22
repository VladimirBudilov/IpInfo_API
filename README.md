### Summary:

This .NET Core application provides an API endpoint for retrieving location information based on a specified IP address. It utilizes the ipinfo.io service for data retrieval. The API is documented using Swagger for easy testing. No authentication is required. Additionally, the application logs the history of unique requests to SQLite database using Entity Framework.

### Features:

- Retrieve location information for a given IP address.
- Swagger documentation for API testing.
- No authentication required.
- Request history logging using Entity Framework.

### Technologies:

- .NET Core
- Entity Framework
- Swagger
- C#

### Usage:

- Send a GET request to `/api/ipinfo/{ipAddress}` to get location information.
- Explore Swagger documentation at `/swagger` for detailed API documentation and testing.
- No authentication needed.

### Note:

- Internet access is required for fetching data from the ipinfo.io service.
- Configure a database for request history logging using Entity Framework.
