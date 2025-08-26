# Product Inventory REST API

A simple RESTful API built with **ASP.NET Core 8 Web API + Entity Framework Core + SQLiteDB**  
to manage products in an inventory.

---

## 🚀 Features
- Add Product
- Get All Products (with optional filters:
  category(search by category for ex-Electronics)
  search(search by description),
  sorting(sort by price asc/desc),
  pagination(Enter page number and page size),
  low-stock alert(true or false))
- Get Product by ID
- Update Product by ID
- Delete Product (Soft delete with `IsActive` flag)

---

## 🛠️ Tech Stack
- **ASP.NET Core 8**
- **Entity Framework Core**
- **SQLite DB**
- **Swagger** (API testing)
- **Postman** (API testing)

---
Database already contains 20 by default dummy data fields 
## Setup Instructions

### 1. Clone Repository
git clone https://github.com/anveetpal01/HoshoProductInventory.git
cd HoshoProductInventory

### 3. Install required Libraries
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Sqlite
Install-Package Microsoft.EntityFrameworkCore.Tools


### 3. Apply Migations
Add-Migration InitialCreate
Update-Database

### 4. Run the API
open the .csproj file in visual studio and press ctrl+f5 or start without debugging


| Method | Endpoint             | Description                | Query / Body                                                                                                                        |
| ------ | -------------------- | -------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| GET    | `/api/products`      | Get all products           | Query parameters (optional): `category`, `Description`, `sortOrder` (`asc`/`desc`), `page`, `pageSize`, `lowStock` (`true`/`false`) |
| GET    | `/api/products/{id}` | Get a single product by ID | -                                                                                                                                   |
| POST   | `/api/products`      | Add a new product          | Body (JSON): `{ "name": "...", "description": "...", "price": 100, "stockQuantity": 10, "category": "..." }`                        |
| PUT    | `/api/products/{id}` | Update a product           | Body (JSON): `{ "name": "...", "description": "...", "price": 120, "stockQuantity": 15, "category": "..." }`                        |
| DELETE | `/api/products/{id}` | Soft delete a product      | -                                                                                                                                   |




