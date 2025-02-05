# DogCareStoreAPI

## Overview

The **DogCareStoreAPI** is a combined API project for managing a dog daycare service while also integrating an online store to sell pet products. It is built using **ASP.NET Core 8.0** and includes basic functionality for handling dogs, products, and orders. This API is designed to showcase practical use of CI/CD pipelines, encryption, and deployment to AWS Elastic Beanstalk.

---

## Features Implemented

### Initial Setup

1. First, make a directory to work in using:

   ```bash
   mkdir dotnet
   ```

2. Go to the folder we just created:

   ```bash
   cd dotnet
   ```

3. Create a folder to work directly in with the command:

   ```bash
   mkdir DogCareStoreAPI
   ```

4. Move into the new folder using:

   ```bash
   cd DogCareStoreAPI
   ```

5. Created the project using:

   ```bash
   dotnet new web
   ```

6. Opened the project in VS Code:

   ```bash
   code .
   ```

7. Updated the default endpoint "app.MapGet("/", () => "Hello World!");" to display a personalized message:

   ```csharp
   app.MapGet("/", () => "Hello Dogs!");
   ```

8. Upgraded the project to .NET 8.0 by modifying the `<TargetFramework>` in the `.csproj` file:

   ```xml
   <TargetFramework>net8.0</TargetFramework>
   ```

9. Generated a `.gitignore` file using:

   ```bash
   dotnet new gitignore
   ```

   This was done to ensure that certain files and folders, such as `bin/` and `obj/` directories, are not added to version control. These folders contain build artifacts and temporary files that do not need to be tracked in Git.

10. Added a `README.md` file:

    ```bash
    echo "# KYH_DogCare_Store-API" >> README.md
    ```

11. Created a new repository on GitHub:

    - Go to GitHub and click on **New Repository**.
    - Name the repository `KYH_DogCare_Store-API`.
    - Check the box to add a **README file**, as this will help with immediate repository documentation.
    - Do not add a **.gitignore** or **license** since they already exist locally.



1. Initialized a new Git repository:

   ```bash
   git init
   ```

2. Staged all files for the initial commit:

   ```bash
   git add .
   ```

3. Created the first commit with the `README.md` file:

   ```bash
   git commit -m "first commit"
   ```

4. Renamed the default branch to `main`:

   ```bash
   git branch -M main
   ```

5. Added the remote repository:

   ```bash
   git remote add origin https://github.com/WANTEDSIMON/KYH_DogCare_Store-API.git
   ```

6. Pushed the code to GitHub:

   ```bash
   git push -u origin main
   ```



---

### Issue List

1. Create readme using terminal at first.

2. Used a falty "Added the remote repository" which created problem with Pushing to github.

---

### Folder Structure

The project has the following structure:

```plaintext
DogCareStoreAPI/
├── src/                # Source code for the API
│   ├── DogCareStore/   # Core project folder (your .NET project)
│   │   ├── Controllers/ # API endpoints (e.g., DogController, ProductController)
│   │   ├── Models/      # Data models (e.g., Dog.cs, Product.cs, Cart.cs)
│   │   ├── Program.cs   # Main entry point for the API
│   │   ├── appsettings.json # Configuration for the API
├── tests/              # Unit tests
│   ├── DogCareStore.Tests/  # Test project for the API
├── .github/            # GitHub Actions workflows
│   ├── workflows/      # CI/CD pipeline YAML files
├── img_readme/         # Folder for storing images related to documentation
├── README.md           # Documentation for the project
```

---

## API Endpoints (Planned)

### Dog Daycare Endpoints

| Method | Endpoint     | Description                    |
| ------ | ------------ | ------------------------------ |
| GET    | `/dogs`      | Fetch all dogs in the daycare. |
| POST   | `/dogs`      | Add a new dog to the daycare.  |
| DELETE | `/dogs/{id}` | Remove a dog from the daycare. |
| GET    | `/dogs/{id}` | Fetch a dog’s details.         |

### Online Store Endpoints

| Method | Endpoint         | Description                          |
| ------ | ---------------- | ------------------------------------ |
| GET    | `/products`      | Fetch all products.                  |
| GET    | `/products/{id}` | Fetch details of a specific product. |
| POST   | `/cart`          | Add a product to the cart.           |
| GET    | `/cart`          | View the shopping cart.              |
| POST   | `/orders`        | Place an order.                      |

---

## Current Status

---

### Result: First Run

The following image shows the first successful run of the application, displaying the response **"Hello Dogs!"**:

![First Run](img_readme/HelloDogs_local.png)

---

## Current Status

1. The project was initialized successfully.
2. The default endpoint was customized to respond with **"Hello Dogs!"**.
3. The project was upgraded to .NET 8.0 as it is the latest .NET version supported by AWS Elastic Beanstalk.
4. A `.gitignore` file was generated for the project.
5. Git repository was initialized to start version control.
6. The project was pushed to a GitHub repository.
7. Basic folder structure is in place for models, controllers, and services.

---

## Next Steps

1. **Add Models**:
   - Define `Dog` and `Product` models.
2. **Create Controllers**:
   - Add `DogController` and `ProductController` to handle core functionality.
3. **Set Up CI/CD**:
   - Create GitHub Actions workflows for build, test, and deployment.
4. **Deploy to AWS Elastic Beanstalk**:
   - Prepare the project for deployment.
5. **Unit Testing**:
   - Write tests for dog and product management.

---

