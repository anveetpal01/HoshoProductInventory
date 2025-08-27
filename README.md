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
- **Swagger** (API testing) - http://localhost:5002/swagger/index.html
- **Postman** (API testing) - Postman collection

---
Database already contains 20 by default dummy data fields 
## Setup Instructions

### 1. Clone Repository
git clone https://github.com/anveetpal01/HoshoProductInventory.git
cd HoshoProductInventory

### 3. restore installed libraries
dotnet restore

### 4. Run project / Start server
dotnet run
(Download the postman collection named - Product Inventory API_new.postman_collection.json)
Download postman collection -> open postman -> import collection to postman -> Run it.

### Sample Apis and Responses
| Method | Endpoint             | Description                | Query / Body                                                                                                                        |
| ------ | -------------------- | -------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| GET    | `/api/products`      | Get all products           | Query parameters (optional): `category`, `Description`, `sortOrder` (`asc`/`desc`), `page`, `pageSize`, `lowStock` (`true`/`false`) |
| GET    | `/api/products/{id}` | Get a single product by ID | -                                                                                                                                   |
| POST   | `/api/products`      | Add a new product          | Body (JSON): `{ "name": "...", "description": "...", "price": 100, "stockQuantity": 10, "category": "..." }`                        |
| PUT    | `/api/products/{id}` | Update a product           | Body (JSON): `{ "name": "...", "description": "...", "price": 120, "stockQuantity": 15, "category": "..." }`                        |
| DELETE | `/api/products/{id}` | Soft delete a product      | -                                                                                                                                   |




