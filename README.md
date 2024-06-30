# MyBackendAPI

This is a .NET Core API built with C# that allows for managing orders. It provides endpoints to create, retrieve, and delete order records.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/yourusername/MyBackendAPI.git
    cd MyBackendAPI
    ```

2. Restore the dependencies:

    ```bash
    dotnet restore
    ```

3. Update the `appsettings.json` file with your SQL Server connection string:

    ```json
    {
      "ConnectionStrings": {
        "OrderContext": "Your SQL Server Connection String"
      },
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
        }
      },
      "AllowedHosts": "*"
    }
    ```

4. Apply the database migrations:

    ```bash
    dotnet ef database update
    ```

5. Run the API:

    ```bash
    dotnet run
    ```

### API Endpoints

- **Create Order**
  - **URL:** `/api/order`
  - **Method:** `POST`
  - **Request Body:**
    ```json
    {
      "firstName": "John",
      "lastName": "Doe",
      "description": "Sample order",
      "quantity": 5
    }
    ```

- **Get All Orders**
  - **URL:** `/api/order`
  - **Method:** `GET`

- **Delete Order**
  - **URL:** `/api/order/{id}`
  - **Method:** `DELETE`

### Design Considerations

- **Clean Code:** Followed best practices for clean and maintainable code.
- **Design Patterns:** Used repository and dependency injection patterns.
- **Persistence:** Implemented using Entity Framework Core.
- **Unit Tests:** Added unit tests for the services.
- **Integration Tests:** Added integration tests for the API endpoints.
- **Performance:** Optimized for performance with appropriate indexing and queries.
- **Security:** Implemented CORS policy and other best practices.
- **Dependency Injection:** Used .NET Core's built-in DI container.
- **HTTP Verbs and Resource Naming:** Followed REST standards.
- **API Documentation:** Can be accessed via Swagger UI at `/swagger`.

### Development Practices

- **Branching:** Followed GitFlow branching model.
- **Code Reviews:** Conducted regular code reviews.
- **CI/CD:** Set up CI/CD pipelines using GitHub Actions.

## License

This project is licensed under the MIT License.
