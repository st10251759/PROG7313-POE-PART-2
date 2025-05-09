# Agri-Energy Connect

<p align="center">
  <img src="/Agri-EnergyConnect Logo.png" alt="Agri-Energy Connect Logo" width="800" height="200"/>
</p>

<p align="center">
  <a href="https://github.com/yourusername/AgriEnergyConnect"><strong>View Repository »</strong></a>
  <br>
  <a href="https://youtube.com/your-demo-video">
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
- [Key Features](#key-features)
- [Functionality and App Usage](#functionality-and-app-usage)
  - [User Roles and Access](#user-roles-and-access)
  - [Farmers](#farmers)
  - [Employees](#employees)
  - [Admins](#admins)
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
- **Database Scripts** - SQL Server scripts for database creation and seeding
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

## Key Features

### 1. Sustainable Farming Hub
- Resource center for sustainable farming best practices
- Knowledge sharing on water conservation and soil health
- Interactive forums for collaboration

### 2. Green Energy Marketplace
- Platform for showcasing green energy solutions
- Product listings for solar irrigation, wind turbines, and biogas energy solutions
- Product comparison and review capabilities

### 3. User Role Management
- Three distinct user roles (Farmer, Employee, Admin)
- Role-based access control
- Secure authentication system

### 4. Product Management
- Detailed product listings with images
- Categorization system
- Search and filter functionality

### 5. Farmer Profile Management
- Comprehensive farmer profiles
- Location and contact information
- Product portfolio management

## Functionality and App Usage

### User Roles and Access

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
