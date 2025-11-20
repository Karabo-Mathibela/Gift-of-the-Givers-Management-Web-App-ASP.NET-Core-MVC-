# Donation Tracker Web App (GOG MVC)

This project is a simple, core-concept ASP.NET Core MVC web application designed to demonstrate fundamental architectural patterns, including Model-View-Controller (MVC) data flow, Razor View rendering, form handling (GET/POST), and using EF Core for data persistence.

The application simulates basic CRUD (Create, Read, Update, Delete) operations for managing internal inventory and donor profiles, mirroring common requirements for a non-profit organization's management portal.

# Features

The application highlights the following ASP.NET Core and C# concepts:

* Clear separation between Models (data), Views (UI), and Controllers (business logic).

* Efficient and type-safe data passing from Controller to View.

* Demonstrates form data binding using raw HTML inputs (<input name="Property">) rather than Tag Helpers, focusing on core HTTP request principles.

* Using ViewBag for same-request status messages (success/failure) and TempData for Post-Redirect-Get (PRG) pattern (e.g., confirmation after updating a record).

* Uses Entity Framework Core to interact with a local SQL Server database for persistent storage of inventory or user records.

* Uses the C# @foreach loop and Razor code blocks (@{ }) for displaying lists and calculating totals (e.g., total stock value).

# Getting Started

## Prerequisites

* .NET 8 SDK or higher

* Visual Studio 2022 (or VS Code with C# Dev Kit)

* SQL Server Express or SQL Server LocalDB (Required for running EF Core Migrations)
