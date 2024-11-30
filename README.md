**Product Management API**

This project is a simple **ASP.NET Core MVC application** designed to manage a list of products using **Entity Framework Core**. The application provides **CRUD operations** (Create, Read, Update, Delete) through APIs for managing products.

## **Features**
- API endpoints for CRUD operations.
- Products have the following properties:
  - **ID**: Unique identifier (Primary Key).
  - **Name**: Name of the product.
  - **Description**: Description of the product.
  - **Price**: Price of the product.
  - **Quantity**: Quantity in stock.
- Database integration with **Entity Framework Core** using SQL Server.

---

## **Technologies Used**
- **.NET Core 8**
- **Entity Framework Core**
- **SQL Server** for the database
- **Swagger** for API documentation
- **Visual Studio 2022**

---

 **Setup Instructions**

 **1. Prerequisites**
- Install **.NET Core SDK** (6 or later).
- Install **SQL Server** or **SQL Server Management Studio** (SSMS).
- Install **Visual Studio 2022** with ASP.NET Core workload.
- Install **Swagger** (already integrated into the project).

---

 **2. Database Configuration**
1. Open the `appsettings.json` file and configure your SQL Server connection string:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=ProductDB;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```
2. Replace `YOUR_SERVER_NAME` with your SQL Server instance name.

---

 **3. Migrations**
1. Open the **Package Manager Console** in Visual Studio.
2. Run the following commands to create and update the database:
   ```bash
   Add-Migration InitialCreate
   Update-Database
   ```

---

 **4. Run the Application**
1. Press **F5** or **Run** the application in Visual Studio.
2. Swagger UI will open in your browser (e.g., `http://localhost:5000/swagger`).

---
 **API Endpoints**

 **1. Get All Products**
- **URL**: `GET /api/products`
- **Description**: Fetches the list of all products.
- **Response**: JSON array of products.

 **2. Get Product by ID**
- **URL**: `GET /api/products/{id}`
- **Description**: Fetches a specific product by its ID.
- **Response**: JSON object of the product.

 **3. Create a Product**
- **URL**: `POST /api/products`
- **Description**: Adds a new product.
- **Request Body** (JSON):
  ```json
  {
    "name": "Product Name",
    "description": "Product Description",
    "price": 99.99,
    "quantity": 10
  }
  ```
- **Response**: Created product with an auto-generated ID.

 **4. Update a Product**
- **URL**: `PUT /api/products/{id}`
- **Description**: Updates an existing product.
- **Request Body** (JSON):
  ```json
  {
    "id": 1,
    "name": "Updated Name",
    "description": "Updated Description",
    "price": 120.00,
    "quantity": 15
  }
  ```
- **Response**: Updated product details.

 **5. Delete a Product**
- **URL**: `DELETE /api/products/{id}`
- **Description**: Deletes a product by ID.
- **Response**: Success or error message.

---

## **Project Structure**
- **Controllers**: Contains API endpoints (e.g., `ProductsController.cs`).
- **Models**: Defines the `Product` entity with its properties.
- **Data**: Manages the database context using **Entity Framework Core**.
- **Migrations**: Contains the database migration files.
- **Startup Configuration**:
  - Registers `DbContext` with Dependency Injection.
  - Adds Swagger for API documentation.

---

 **Product Entity**
The `Product` entity is defined as follows:
```csharp
public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
```

---
 **Usage Instructions**
1. Open Swagger (https://localhost:7037/swagger/index.html) to test the API endpoints.
2. Use the available endpoints to perform CRUD operations.

---

 **Future Improvements**
- Add frontend (Blazor/React) to consume the APIs.
- Implement advanced features like filtering, sorting, and pagination.

---

