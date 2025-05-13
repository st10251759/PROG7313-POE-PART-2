# Agri-Energy Connect

<p align="center">
  <img src="/Agri-EnergyConnect Logo.png" alt="Agri-Energy Connect Logo" width="800" height="200"/>
</p>

<p align="center">
  <a href="https://github.com/st10251759/PROG7313-POE-PART-2"><strong>View Repository »</strong></a>
  <br>
  <a href="https://youtu.be/oQuFbhntUWE">
    <img src="https://img.shields.io/badge/Watch%20on-YouTube-red?style=for-the-badge&logo=youtube&logoColor=white" alt="Watch video demo on YouTube">
  </a>
</p>

## Table of Contents
- [Overview](#overview)
- [Repository Contents](#repository-contents)
- [Built With](#built-with)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Design Approach](#design-approach)
  - [Cloning the Project](#cloning-the-project)
  - [Restoring the Database](#restoring-the-database)
- [Architecture and Design Pattern](#architecture-and-design-pattern)
- [Database Implementation](database-implementation)
- [Key Features](#key-features)
- [Functionality and App Usage](#functionality-and-app-usage)
  - [User Roles and Access](#user-roles-and-access)
  - [Farmers](#farmers)
  - [Employees](#employees)
  - [Admins](#admins)
- [Testing Credentials](#testing-credentials)
- [Assumptions of Usage](#assumptions-of-usage)
- [Future Requirements](#future-requirements)
- [Code Attribution](#code-attribution)
- [Contributors](#contributors)

## Overview

Agri-Energy Connect is an innovative web platform designed to bridge the gap between South Africa's agricultural sector and green energy technology providers. This digital ecosystem facilitates collaboration, resource sharing, and innovation in sustainable agriculture and renewable energy.

The platform serves as a central hub where farmers can showcase their green energy solutions, employees can manage farmer profiles, and administrators can oversee the entire system. Each user role has specific permissions and functionalities, ensuring secure and efficient operation.

## Repository Contents

The repository contains the following key components:

- **ASP.NET Core Web Application** - Complete source code for the application
- **Database Script and BK file** - SQL Server scripts for database creation and seeding as well as a database backup file
- **Documentation** - Comprehensive documentation including this README file
- **Images and Static Resources** - All images and static resources used in the application

## Built With

<p align="center">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/ASP.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" alt="ASP.NET">
  <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white" alt="HTML5">
  <img src="https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white" alt="CSS3">
  <img src="https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server">
  <img src="https://img.shields.io/badge/.NET_8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 8">
</p>

- **C#** - Primary programming language
- **ASP.NET Core MVC** - Web application framework
- **Microsoft Identity** - Authentication and authorization system
- **HTML/CSS** - Frontend design
- **SQL Server Management Studio (SSMS)** - Database management
- **.NET 8** - Framework version

## Getting Started

### Prerequisites

To run this application locally, you'll need:

- Visual Studio 2022 or later
- SQL Server Management Studio (SSMS)
- .NET 8 SDK
- Web browser (Chrome, Firefox, Edge recommended)
- Git (for cloning the repository)

### Design Approach

Agri-Energy Connect follows a user-centric design approach with:

- **Responsive Design** - Fully responsive for desktop and mobile devices
- **Color Scheme** - Various shades of green to reflect the agricultural and sustainable energy focus
- **User-Friendly Interface** - Intuitive navigation and clear visual hierarchy
- **Accessibility** - Designed with accessibility in mind for all users

### Cloning the Project

1. Open your command line interface (CLI)
2. Navigate to your desired directory
3. Run the following command:

```bash
git clone https://github.com/st10251759/PROG7313-POE-PART-2.git
```

4. Open the solution file (AgriEnergyConnect.sln) in Visual Studio
5. Restore NuGet packages
6. Build the solution

### Restoring the Database

#### Method 1: Using the Backup (.bak) File

1. Open SQL Server Management Studio (SSMS)
2. Right-click on "Databases" in the Object Explorer
3. Select "Restore Database..."
4. Choose "Device" as the source
5. Click the "..." button to browse for the backup file
6. Navigate to the backup file in the project's Database folder
7. Select the file and click "OK"
8. Click "OK" to restore the database

#### Method 2: Using the Generated Script

1. Open SQL Server Management Studio (SSMS)
2. Connect to your server
3. Click "New Query"
4. Open the SQL script file from the project's Database folder
5. Execute the script to create and populate the database
6. Verify that the database has been created successfully

After restoring the database, update the connection string in the `appsettings.json` file to point to your local SQL Server instance.

## Architecture and Design Pattern

### Model-View-Controller (MVC)

Agri-Energy Connect employs the **Model-View-Controller (MVC)** pattern as its architectural foundation, providing a clean separation of concerns:

- **Models:** Handle data structures and business logic (e.g., `ApplicationUser`, `Product`)
- **Views:** Present information to users with role-specific organization (e.g., `/Views/Farmer/`, `/Views/Admin/`)
- **Controllers:** Manage user input and application flow (e.g., `FarmerController`, `EmployeeController`)

This approach enables straightforward routing and consistent handling of user interactions based on roles.

### Layered Architecture

The application follows a **3-Tier Layered Architecture** for improved maintainability:

- **Presentation Layer:** User interface components and views
- **Business Logic Layer:** Controllers and services handling application operations
- **Data Access Layer:** Entity Framework and `DbContext` managing database operations

This separation of concerns allows changes in one layer to occur without disrupting others. For example, all database operations are isolated in the `Prog7311DbContext` class, while validation logic remains in the business layer. This organization made it simpler to implement features like role-based access and user management while keeping the codebase organized and adaptable.

## Database Implementation

### SQL Server and Entity Framework Core

Agri-Energy Connect uses **SQL Server Management Studio (SSMS)** as its database engine, connected through **Entity Framework Core**. This combination was selected for:

- **Reliability:** Stable performance for handling multiple concurrent users
- **Structured storage:** Efficient organization of relational data (Users, Products, Roles, Categories)
- **ASP.NET integration:** Seamless compatibility with the application framework

Entity Framework Core serves as the ORM (Object-Relational Mapper), allowing:
- Code-first migrations
- Automated data validation
- Reduced need for manual SQL queries

The database schema is designed to support scalability, with the `Prog7311DbContext` class acting as the bridge between application code and data storage. This implementation ensures data integrity while maintaining security for sensitive user information, and provides a straightforward workflow for future enhancements and expansions.

## Key Features

### 1. Sustainable Farming Hub
- Resource center for sustainable farming best practices
- Knowledge sharing on water conservation and soil health
- Interactive forums for collaboration

<p align="center">
  <img src="/Screenshot-Sustainable-Farming-Hub.png" alt="Sustainable Farming Hub" width="800" height="400"/>
</p>

### 2. Green Energy Marketplace
- Platform for showcasing green energy solutions
- Product listings for solar irrigation, wind turbines, and biogas energy solutions
- Product comparison and review capabilities

<p align="center">
  <img src="/Screenshot-Green-Energy-Marketplace.png" alt="Green Energy Marketplace" width="800" height="400"/>
</p>

### 3. Educational and Training Resources
- Platform for providing Online courses, webinars, and workshops on integrating 
  green energy technologies in 
  agriculture
- Provides Users with learning material focusing on the benefits and practicalities 
  of adopting renewable energy sources on farms

<p align="center">
  <img src="/Screenshot-Training-Resources.png" alt="Educational and Training Resources" width="800" height="400"/>
</p>

### 4. Project Collaboration and Funding Opportunities
- Platform for farmers and energy experts to propose and collaborate on joint 
  projects.
- Provides information on grants, subsidies, and funding opportunities for green initiatives in agriculture.

<p align="center">
  <img src="/Screenshot-Project-Collab.png" alt="Project Collaboration and Funding Opportunities Resources" width="800" height="400"/>
</p>

### 5. User Role Management
- Three distinct user roles (Farmer, Employee, Admin)
- Role-based access control
- Secure authentication system

<p align="center">
  <img src="/Screenshot-Access-Denied.png" alt="Access denied" width="800" height="400"/>
</p>

### 6. Product Management
- Detailed product listings with images
- Categorization system
- Search and filter functionality

<p align="center">
  <img src="/Screenshot-Product-Managemet.png" alt="Product Management" width="800" height="400"/>
</p>

### 7. Farmer Profile Management
- Comprehensive farmer profiles
- Location and contact information
- Product portfolio management

<p align="center">
  <img src="/Screenshot-Farmer-Profile.png" alt="Farmer Profile Management" width="800" height="400"/>
</p>

## Functionality and App Usage

### User Roles and Access

<p align="center">
  <img src="/Screenshot-Login.png" alt="Login" width="800" height="400"/>
</p>

#### Farmers
Farmers have access to:
- View their own product listings
- Add new products to their profile
- Update existing product details
- Remove products they've created
- Manage their personal profile

#### Employees
Employees have access to:
- View all farmer profiles
- Add new farmer profiles
- Remove farmers from the system
- View and filter all products from any farmer
- Search for specific products

#### Admins
Admins have access to:
- View all employee profiles
- Create new employee accounts
- Delete employee accounts
- Overall system management

### Farmers

**Viewing Products:**
- Login to your account
- Navigate to "My Products" to see all your listed products
- Click on a product to view its details

**Adding Products:**
- Navigate to "Add Product"
- Fill in required details (name, description, category, etc.)
- Upload product image
- Submit the form

**Managing Profile:**
- Navigate to "My Profile"
- Update contact information, location, or password
- Save changes

### Employees

**Managing Farmers:**
- View all farmers in the "Farmers" section
- Add new farmers using the "Add Farmer" form
- Remove farmers by clicking the "Delete" button on a farmer's profile

**Viewing Products:**
- Browse all products in the "Products" section
- Use filters to narrow down by date range or category
- Use the search bar to find specific products

### Admins

**Managing Employees:**
- View all employees in the "Employees" section
- Create new employee accounts using the "Add Employee" form
- Delete employee accounts as needed

## Testing Credentials
### Farmer
- **Email Address:** sipho.dlamini@example.com
- **Password:** Password@123

### Employee
- **Email Address:** rajesh.reddy@example.com
- **Password:** Password@123

### Admin
- **Email Address:** admin@gmail.com
- **Password:** Password@123

## Assumptions of Usage

1. **Internet Access**: Users have consistent internet access to use the web application.
   
2. **Browser Compatibility**: The application works optimally on modern browsers (Chrome, Firefox, Edge, Safari).
   
3. **User Knowledge**: Users have basic knowledge of web navigation and form submission.
   
4. **Image Uploads**: Farmers will upload images in common formats (JPEG, PNG) with reasonable file sizes.
   
5. **Data Privacy**: All users understand that their profile information is visible to employees and admins.

## Future Requirements

1. **Mobile Application**: Develop a companion mobile app for field use.
   
2. **Advanced Analytics**: Implement dashboards showing trends and insights on green energy adoption.
   
3. **Payment Integration**: Add functionality for direct transactions between farmers and customers.
   
4. **Multi-language Support**: Add support for South Africa's 11 official languages.
   
5. **Offline Mode**: Enable basic functionality when internet connectivity is limited.
   
6. **AI Recommendations**: Implement AI-based product recommendations based on farming type and location.

## Code Attribution

- **Microsoft Identity Integration:**
  - Author: Andy Malone MVP
  - Link: [Microsoft Identity Tutorial](https://www.youtube.com/watch?v=zS79FDhAhBs)
  - Date Accessed: 05 May 2025

- **MVC Application Framework:**
  - Author: Microsoft
  - Link: [ASP.NET Core MVC Tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-9.0&tabs=visual-studio)
  - Date Accessed: 06 May 2025

- **Data Annotation Attributes:**
  - Author: Simplilearn
  - Link: [Data Annotation in ASP.NET MVC](https://www.simplilearn.com/tutorials/asp-dot-net-tutorial/data-annotation-attributes-in-asp-dot-net-mvc)
  - Date Accessed: 06 May 2025

- **ASP.NET App with SSMS Database:**
  - Author: Andy Malone MVP
  - Link: [Database Connection Tutorial](https://www.youtube.com/watch?app=desktop&v=ZX12X-ALwGA)
  - Date Accessed: 05 May 2025

- **HTML Resources:**
  - Author: w3schools
  - Link: [HTML Tutorial](https://www.w3schools.com/html/)
  - Date Accessed: 08 May 2025

- **CSS Resources:**
  - Author: w3schools
  - Link: [CSS Tutorial](https://www.w3schools.com/css/)
  - Date Accessed: 08 May 2025

- **JQuery Resources:**
  - Author: w3schools
  - Link: [JQuery Tutorial](https://www.w3schools.com/jquery/default.asp)
  - Date Accessed: 08 May 2025

- **JavaScript Resources:**
  - Author: w3schools
  - Link: [JavaScript Tutorial](https://www.w3schools.com/js/DEFAULT.asp)
  - Date Accessed: 08 May 2025

- **REGEX Validation Resources:**
  - Author: Tyler Woodward
  - Link: [Phone Validation Regex: The What, How, and Pros and Cons](https://trestleiq.com/phone-validation-regex-the-what-how-and-pros-and-cons/)
  - Date Accessed: 08 May 2025

- **Database Implementation:**
  - Author: Microsoft
  - Link: [Working with SQL in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-8.0&tabs=visual-studio)
  - Date Accessed: 08 May 2025

- **LINQ Implementation:**
  - Author: Grant Riordan
  - Link: [How to Use LINQ](https://www.freecodecamp.org/news/how-to-use-linq/)
  - Date Accessed: 08 May 2025

- **Exception Handling:**
  - Author: w3schools
  - Link: [C# Exceptions](https://www.w3schools.com/cs/cs_exceptions.php)
  - Date Accessed: 08 May 2025

- **Image Upload Functionality:**
  - Author: Aurigma
  - Link: [File Upload in ASP.NET MVC](https://www.aurigma.com/upload-suite/developers/aspnet-mvc/how-to-upload-files-in-aspnet-mvc)
  - Date Accessed: 08 May 2025

  ---
## Contributors

<table>
  <tr>
    <td align="center">
      <a href="https://github.com/st10251759">
        <img src="https://github.com/identicons/st10251759.png" width="100px;" alt="Cameron Chetty"/>
        <br />
        <sub><b>Cameron Chetty</b></sub>
      </a>
      <br/>
      <sub>ST10251759</sub>
      <br/>
      <a href="mailto:ST10251759@vcconnect.edu.za">ST10251759@vcconnect.edu.za</a>
    </td>
  </tr>
</table>

For support or questions, contact me at:
- 📧 st10251759@vcconnect.edu.za
- 📞 +27 81 262 5090

© 2025 Agri-Energy Connect. All Rights Reserved.

---

<p align="right">(<a href="#readme-top">back to top</a>)</p>
