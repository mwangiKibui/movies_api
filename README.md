# Movies API

A dummy Movies API using ASP.Net Core 7.0 and Maria DB.

### Pre-requisites

Before proceeding ensure you have the following:

- [Visual Studio](https://visualstudio.microsoft.com/downloads/) installed on your computer.
- [ASP.Net 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) installed on your computer. (Automatically installed with Visual Studio).
- [Maria DB](https://mariadb.org/download/?t=mariadb&p=mariadb&r=11.2.0) installed on your computer.

### Installation procedures:

- Install the dependecies:

    ```bash
    dotnet restore
    ```

- Run the migrations:

    ```bash
    dotnet ef migrations add InitialCreate
    ```

- Commit the migrations to the Database:

    ```bash
    dotnet ef database update
    ```

- Run the application:

    ```bash
    dotnet run
    ```

- Interact with the APIs from the Swagger UI that is automatically presented on your browser.