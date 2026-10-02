# Hospital Management System

A Windows Forms desktop application for managing hospital records and patient information.

## Overview

This project is a simple hospital management system built with C# and .NET Framework. It provides a graphical interface for handling core hospital tasks such as managing doctors, patients, and diagnosis records.

## Features

- Doctor management
- Patient management
- Diagnosis management
- Home dashboard navigation
- Add, update, delete, and reset record actions
- SQL Server LocalDB database connectivity

## Tech Stack

- C#
- .NET Framework 4.8
- Windows Forms
- SQL Server LocalDB

## Project Structure

- Hospital MS.sln - Solution file
- Hospital MS/ - Main application project
  - Home.cs - dashboard form
  - Login.cs - login form
  - Doctor.cs - doctor management form
  - Patient.cs - patient management form
  - Diagnosis.cs - diagnosis management form
  - Program.cs - application entry point

## Prerequisites

- Windows operating system
- Visual Studio 2019 or later
- .NET Framework 4.8
- SQL Server LocalDB

## Setup Instructions

1. Clone the repository.
2. Open the solution file named Hospital MS.sln in Visual Studio.
3. Restore NuGet dependencies if prompted.
4. Build the solution.
5. Press F5 to run the application.

## Database Note

The project currently uses a LocalDB connection string pointing to a file path on the original machine. If you run it on another computer, update the connection string in the form classes to match your local database location.

## License

This project is provided for educational and demonstration purposes.
