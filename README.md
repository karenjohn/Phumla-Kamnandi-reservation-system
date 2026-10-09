# Phumla Kamnandi Hotel Reservation System

A desktop-based hotel management application developed in C# using .NET Windows Forms and Microsoft SQL Server. This project was developed collaboratively by a team of four between August and October 2025.

The system is designed to support hotel operations by managing guest bookings, reservations, invoicing, and inventory-related processes through a graphical user interface.

## Table of Contents

* [Project Overview](#project-overview)
* [Technologies Used](#technologies-used)
* [Project Structure](#project-structure)
* [Prerequisites](#prerequisites)
* [Getting Started](#getting-started)
* [Database Configuration](#database-configuration)
* [Running the Application](#running-the-application)
* [Exploring the Application](#exploring-the-application)
* [Troubleshooting](#troubleshooting)
* [Limitations and Notes](#limitations-and-notes)

## Project Overview

The Phumla Kamnandi Hotel Reservation System provides a centralized desktop interface for handling selected hotel management operations.

The application includes forms for making and changing bookings, cancelling reservations, processing invoice-related information, and viewing reports.

## Technologies Used

* **Programming language:** C#
* **Framework:** .NET Windows Forms
* **Database:** Microsoft SQL Server
* **Data access:** ADO.NET
* **IDE:** Microsoft Visual Studio
* **UI dependency:** Bunifu UI for Windows Forms

## Project Structure

The downloaded project contains the following important files and folders. The exact structure may vary slightly depending on the supplied project archive.

| File or folder                   | Purpose                                                                         |
| -------------------------------- | ------------------------------------------------------------------------------- |
| `.sln`                           | Visual Studio solution used to open the project                                 |
| `.csproj`                        | Project configuration, source file references, and build settings               |
| `Program.cs`                     | Application entry point                                                         |
| `DatabaseHelper.cs`              | Database access and related operations                                          |
| `App.config`                     | Application configuration, potentially including the database connection string |
| `Packages.config`                | Lists NuGet dependencies required by the project                                |
| `MakeBooking.cs`                 | Booking interface and related logic                                             |
| `ChangeBooking.cs`               | Booking modification functionality                                              |
| `CancelBooking.cs`               | Booking cancellation functionality                                              |
| `InvoiceSummaryForm.cs`          | Invoice summary interface and related logic                                     |
| `Enquiry.cs`                     | Enquiry functionality                                                           |
| `Report.cs`                      | Reporting interface and related logic                                           |
| `ReservationMenu.cs`             | Reservation navigation interface                                                |
| `HotelDatabase.mdf`              | SQL Server database file, if included in the supplied archive                   |
| `HotelDatabaseDataset.xsd`       | Typed dataset definition                                                        |
| `Resources/`                     | Images and other application resources                                          |
| `Properties/`                    | Project properties, settings, and resource definitions                          |
| `SQLQuery1.sql`, `SQLQuery2.sql` | SQL scripts supplied with the project                                           |

Files ending in `.Designer.cs` and `.resx` support the Windows Forms user interface and its resources. Keep them together with their corresponding forms.

## Prerequisites

Before running the application, ensure that your computer has the following:

1. **Microsoft Visual Studio:** A version compatible with the project's target .NET Framework.
2. **.NET Framework:** The version specified in the project configuration.
3. **Microsoft SQL Server:** Required if the application connects to SQL Server.
4. **SQL Server Express LocalDB or another compatible SQL Server instance:** The appropriate option depends on the connection string configured in the application.
5. **Required NuGet packages:** Including the Bunifu UI dependency specified by the project.

The project was developed as a Windows desktop application and is intended to run on a compatible Windows environment.

## Getting Started

### Step 1: Download the project

1. Open the Google Drive link provided with this repository.
2. Download the project ZIP archive to your computer.
3. Extract the archive using Windows File Explorer.
4. Move the extracted folder to a convenient location, such as your Documents folder.

Ensure that the extracted folder contains the Visual Studio solution file (`.sln`) and the associated project files.

### Step 2: Open the solution in Visual Studio

1. Launch Microsoft Visual Studio.
2. Select **Open a project or solution**.
3. Navigate to the extracted project directory.
4. Select `Pumla Kamnandi Hotel Project.sln`, or the actual `.sln` filename supplied with the project.
5. Wait for Visual Studio to load the solution.

If Visual Studio reports missing packages or dependencies, proceed to the dependency restoration instructions below.

### Step 3: Restore project dependencies

The project uses NuGet packages and a third-party Windows Forms UI library.

To restore the dependencies:

1. Open the solution in Visual Studio.
2. Right-click the solution in Solution Explorer.
3. Select **Restore NuGet Packages**, if that option is available.
4. Wait for the packages to download and restore.
5. Review any package compatibility errors.

If automatic restoration fails, check `Packages.config`, the project's target framework, and the package sources. The correct version of Bunifu UI may need to be installed or restored separately.

## Database Configuration

The application uses Microsoft SQL Server and ADO.NET for database operations. Correct database configuration is essential for the booking, reservation, and invoicing functionality to work.

### Step 1: Locate the database files

Check whether the downloaded project includes:

* `HotelDatabase.mdf`
* `HotelDatabase_LOG.ldf`
* `DatabaseHelper.cs`
* `App.config`

The `.mdf` file contains the SQL Server database. The `.ldf` file is its transaction log.

### Step 2: Identify the database connection string

Open `App.config` and locate the connection string configuration.

The connection string specifies how the application connects to the database. Depending on the existing project configuration, it may use SQL Server LocalDB, SQL Server Express, or another SQL Server instance.

**Do not replace the existing connection string blindly.** First inspect its server or instance name, database attachment settings, and authentication method.

### Step 3: Configure the database connection

If the project uses an attached `.mdf` database:

1. Ensure that a compatible SQL Server instance or LocalDB installation is available.
2. Confirm the database file's location.
3. Check that the connection string points to the correct database file and SQL Server instance.
4. Ensure the application has permission to access the database.
5. Follow any project-specific database initialization instructions.

If the application expects an existing database on a particular SQL Server instance, configure that instance or update the connection string to match your local environment.

Avoid attaching the same database files simultaneously to conflicting SQL Server instances. Keep a backup of the original database files before making changes.

### Step 4: Verify database access

After configuration, build and run the application.

If a database connection error appears, verify the connection string, SQL Server installation, database file path, and database permissions before proceeding.

## Running the Application

Once the project dependencies and database connection have been configured:

1. Open the solution in Visual Studio.
2. In Solution Explorer, confirm that the correct project is selected as the startup project.
3. Select **Build → Build Solution**.
4. Resolve any compilation errors.
5. Press **F5** to run the application with debugging, or **Ctrl + F5** to run it without debugging.

The application should launch its Windows Forms interface if the build succeeds and its runtime requirements are satisfied.

## Exploring the Application

The solution contains several forms that represent different hotel management functions.

### Reservations and bookings

Use the booking-related forms to explore the reservation workflow:

* **Make Booking:** Enter the information required to create a booking.
* **Change Booking:** Access the functionality for modifying an existing booking.
* **Cancel Booking:** Access the functionality for cancelling a reservation.
* **Enquiry:** Explore the available enquiry interface.

The availability of particular actions and the exact fields displayed depend on the implemented form logic and database state.

### Invoicing

Open the invoice summary functionality to explore the invoicing interface.

This module is particularly relevant to my contribution to the project, which focused on database integration and invoicing.

### Reports

Open the reporting interface to view the reporting functionality implemented in the application.

### Expected outcomes

When the application is correctly configured and the required database records are available, users should be able to interact with the implemented forms and observe the corresponding application responses.

Successful operations may include displaying booking information, saving or modifying reservations, processing cancellations, and displaying invoice-related information.

The precise results depend on the supplied database contents and the implemented business rules.

## Troubleshooting

### The solution does not open

* Confirm that you selected the `.sln` file rather than an individual `.cs` file.
* Check whether your Visual Studio version supports the project's target framework.
* Review any missing project or dependency warnings.

### Bunifu UI references are missing

* Check the required package version in `Packages.config`.
* Restore the NuGet packages.
* Confirm that the referenced assemblies are available and compatible with the target framework.

### The application cannot connect to the database

* Verify that the required SQL Server instance or LocalDB is installed.
* Check the connection string in `App.config`.
* Confirm that the `.mdf` file exists at the configured path, if applicable.
* Check database permissions and whether the database is attached correctly.

### The application builds but does not run correctly

* Review the error message in Visual Studio.
* Check the startup project and application entry point.
* Confirm that all required resources and dependencies are available.
* Verify that the database contains the records expected by the relevant forms.

### Some forms or images are missing

* Ensure that the `.Designer.cs` and `.resx` files have been included with their associated forms.
* Check that the `Resources` folder and required images are present.
* Confirm that the project file references the relevant source files and resources.

## Limitations and Notes

* This is an academic group project developed between August and October 2025.
* The application is designed for a compatible Windows desktop environment.
* Successful execution depends on the correct .NET Framework, third-party dependencies, and database configuration.
* The project should be tested in a clean environment before being considered fully reproducible.
* Database contents and credentials should be reviewed before redistributing the project.
* This repository documents the project and provides access to the supplied project files; it does not imply that the application has been independently tested on every computer.

## Project Access

**Download the complete Visual Studio project:** [https://drive.google.com/file/d/1qHCkR3Z1bzMLhvEgT8sOLkhrrMMIL1eX/view?usp=sharing]

After downloading and extracting the files, follow the setup instructions above to configure the development environment and database.

---

*Developed collaboratively by a team of four. My primary responsibilities were database integration and the invoicing module.*





