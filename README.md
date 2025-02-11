
# SuperHero API 🦸♂️

A RESTful API built with **.NET 8** and **Entity Framework Core** to manage superhero data. Supports CRUD operations and uses SQL Server for database storage.

## Features ✨
- **CRUD Operations**: Create, Read, Update, and Delete superheroes.
- **Entity Framework Core**: Code-First approach with migrations.
- **SQL Server Integration**: Persistent data storage.
- **Clean Architecture**: Controllers, Models, and Data layers.

## Technologies 🛠️
- .NET 8
- Entity Framework Core 8
- SQL Server
- Swagger/OpenAPI (for API documentation)

## Getting Started 🚀

### Prerequisites
- .NET 8 SDK
- SQL Server (LocalDB or Docker)
- IDE (Visual Studio 2022, VS Code, etc.)

### Installation
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/AhmedGomaa15/SuperHero-Api.git
Restore Packages:


dotnet restore
Configure Database:
Update the connection string in appsettings.json:


"ConnectionStrings": {
  "DefaultConnection": "Your-SQL-Server-Connection-String"
}
Run Migrations:
Create the database using EF Core migrations:


dotnet ef database update
Run the Application:


dotnet run
Test the API:
Access Swagger UI at https://localhost:PORT/swagger.

API Endpoints 📋
Method	Endpoint	Description
GET	/api/superhero	Get all superheroes
GET	/api/superhero/{id}	Get a single superhero
POST	/api/superhero	Add a new superhero
PUT	/api/superhero/{id}	Update a superhero
DELETE	/api/superhero/{id}	Delete a superhero
Example Request (POST) 🌟

{
  "name": "Iron Man",
  "firstName": "Tony",
  "lastName": "Stark",
  "place": "New York",
  "powers": ["Tech Genius", "Powered Armor"]
}
Contributing 🤝
Feel free to fork, open issues, or submit PRs! Let’s make this API even more heroic!



---

This structure ensures clarity and ease of use for anyone exploring your project. Add screenshots of Swagger/Postman if you have them! 🌟
