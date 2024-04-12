# Coding Challenge

This project consists of a front end and a backend.

## Backend

### Requirements

- [.NET](https://dotnet.microsoft.com/download)
- [.NET SDK](https://dotnet.microsoft.com/download/dotnet)

### Running Locally

1. Navigate to the `backend` directory.
2. Run the following command to start the backend server locally:

```bash
dotnet run
```

This command will start the backend server. Make sure you have the necessary dependencies installed.

## Frontend

### Requirements

- Node.js (which includes npm)

### Installing Dependencies

1. Navigate to the `frontend` directory.
2. Install the necessary dependencies using npm:

This command will install all dependencies required by the frontend.

### Updating Proxy Port

The frontend communicates with the backend via a proxy. You need to update the proxy port number in the `setupProxy.js` file based on the HTTPS port the backend server is running on.

Example:
```bash
target: "http://localhost:5137",
```
Replace `:5137` with the appropriate port number of your backend server.

### Running Locally

Once you have installed the dependencies and updated the proxy port, you can run the frontend locally:

```bash
npm start
```
This will start the development server for the frontend.
