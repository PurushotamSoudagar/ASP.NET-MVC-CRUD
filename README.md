
# ASP.NET Core MVC CRUD App (.NET 9)

This repository contains a **CRUD (Create, Read, Update, Delete)** web application built using **ASP.NET Core MVC (.NET 9)**. It demonstrates core features like:

- MVC pattern (Models, Views, Controllers)  
- Routing and Dependency Injection  
- Entity Framework Core with Migrations  
- Razor Views with Bootstrap UI  
- Server-side validation and form handling

## 🚀 Features

- Full CRUD operations (Create, Read, Update, Delete)  
- Client- and server-side validation  
- Responsive UI with Bootstrap  
- EF Core migrations for database versioning  
- Clean, maintainable folder structure

## 🛠️ Tech Stack

| Technology               | Description                             |
|--------------------------|-----------------------------------------|
| **Framework**            | ASP.NET Core MVC (.NET 9)              |
| **ORM**                  | Entity Framework Core                  |
| **Database**             | SQL Server (LocalDB)                   |
| **Frontend**             | Bootstrap / Razor Views                |
| **IDE**                  | Visual Studio 2022                     |

## 📂 Folder Structure

```
MyApp/
├── Controllers/       # MVC controllers 
├── Models/            # Entity and data models
├── Views/             # Razor view templates
├── Migrations/        # EF Core migration files
├── wwwroot/           # Static assets (CSS, JS)
├── appsettings.json   # Configuration file
└── Program.cs         # Application startup
```
## 🎯 How to Use

- Browse through list of items  
- Click **Create** to add new entries  
- Use **Edit/Delete** buttons to modify or remove items  
- Validation prevents invalid input