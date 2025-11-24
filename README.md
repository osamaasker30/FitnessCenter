# 🏋️ Fitness Center Management and Appointment System (PhishGuard)

## 📌 Project Overview

This is a comprehensive web application developed for the Web Programming Course at Sakarya University. The goal is to solve operational inefficiencies in the fitness sector by creating a centralized, digital platform for managing services, trainers, and member appointments.

The system features robust **Role-Based Authorization** (Admin/Member) and integrates a cutting-edge **Artificial Intelligence (AI)** module for personalized user recommendations.

## ✨ Key Features

* **Trainer Management (CRUD):** Full management of trainers, including defining their expertise (e.g., muscle building, weight loss, yoga) and working hours/availability slots.
* **Service & Gym Management (CRUD):** Define all services offered (duration, fees) and manage gym locations/hours.
* **Member Booking System:** A responsive interface allowing members to view trainer availability and book appointments in real-time.
* **Appointment Workflow:** Implements a confirmation/approval mechanism and stores detailed appointment history.
* **REST API for Scheduling:** Exposes API endpoints for filtering trainers and appointments using complex **LINQ queries**.
* **AI Integration:** A dedicated feature to provide members with **personalized exercise or diet plan recommendations** based on their input (e.g., height, weight, body type).
* **Admin Panel:** A dedicated interface for management users to oversee all CRUD operations and approve pending appointments.

## 💻 Technology Stack

This project is built using enterprise-level tools for security, scalability, and performance.

| Component | Technology | Role |
| :--- | :--- | :--- |
| **Backend Framework** | ASP.NET Core MVC (LTS) & C# | Core business logic, routing, and API development. |
| **Database** | MSSQL Server / PostgreSQL | Persistent data storage for users, services, and appointments. |
| **ORM** | Entity Framework Core (EF Core) & LINQ | Object-Relational Mapping for database interaction. |
| **Frontend/UI** | HTML5, CSS3, JavaScript, jQuery | Client-side interactivity and logic. |
| **Styling** | Bootstrap 5 | Responsive design, grid layout, and UI components. |
| **AI/ML** | Python / OpenAI API (or similar) | Handling the personalized plan generation feature. |

## 🚀 Getting Started (Setup Instructions)

To run this project locally, follow these steps:

### 1. Prerequisites

* .NET SDK (LTS version)
* SQL Server Express / PostgreSQL (for database)
* Visual Studio or Visual Studio Code

### 2. Database Setup

1.  Update the **`DefaultConnection`** connection string in `appsettings.json` to point to your local SQL Server instance.
2.  Open the Package Manager Console (PMC) and run the following Entity Framework Core commands:
    ```bash
    Update-Database
    ```
    *(Note: This assumes you have already created the initial Identity and core migrations.)*

### 3. Application Launch

1.  Build the solution: `dotnet build` (or press F6 in VS).
2.  Run the application: `dotnet run` (or press F5 in VS).
3.  Navigate to the registration page (`/Identity/Account/Register`) to create your first user.

### 4. Admin Account

To access the administrative CRUD panel, you must manually create a user and assign them the **"Admin"** role in the database.

## 🤝 Contribution and Contact

This project was developed by:

* **Student 1 Name:** [Your Name]
* **Student 2 Name:** [Partner's Name, if applicable]

For academic inquiries, please contact: [Your Student Email Address]
