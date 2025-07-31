#  MAUI Game Library

##  Personal Project — Software Development Portfolio

A cross-platform mobile app built using **.NET MAUI**, designed to help users catalog and manage their personal video game collection. This application supports key features such as real-time input validation, media integration for cover images, and a modern Material Design UI.

Originally developed as part of my academic coursework, I’ve enhanced and documented this project to showcase my skills in mobile app development and software architecture.

---

##  Background

This project was initially created under the guidance of my lecturer as a hands-on learning exercise for building mobile applications with .NET MAUI. It served to teach us practical concepts like:

- MVVM architecture
- Cross-platform development
- Data validation and user input handling
- Dependency injection
- Clean and scalable UI design

I’ve continued to work on the app independently as part of my personal portfolio.

---

##  Features

-  **Game Management**: Add, edit, and view game entries
-  **Image Support**: Add cover images via photo picker or URL
-  **Real-time Validation**: Required fields are validated instantly
-  **Cross-Platform Support**: Runs on Android, iOS, Windows, and macOS
-  **Modern UI**: Material Design styling with responsive layouts

---

##  Tech Stack

- **Framework**: .NET 9.0 + .NET MAUI
- **Languages**: C#, XAML
- **Architecture**: MVVM (Model-View-ViewModel)
- **Tools**: Visual Studio 2022, Git, NuGet
- **Validation**: MAUI Community Toolkit

---

##  Project Structure Overview

MauiGameLibrary/
- Models/ # Game data models and enums
- ViewModels/ # Logic for managing app state and data
- Views/ # User interface pages (XAML)
- Services/ # Data handling logic
- Platforms/ # Platform-specific configurations
- Resources/ # Images, fonts, and styles

yaml
Copy
Edit

---

##  Getting Started

### Prerequisites

- Visual Studio 2022 (v17.8 or later)
- .NET 9.0 SDK
- Android/iOS SDKs or Windows 10+ for desktop

### Setup Instructions

1. Clone the repo:
   ```bash
   git clone https://github.com/Abdurrageem/MauiGameLibrary.git
   cd MauiGameLibrary
Restore dependencies:

bash
Copy
Edit
dotnet restore
Build and run:

bash
Copy
Edit
dotnet build
dotnet run
Note: You can run the app on Android, iOS, or Windows by specifying the appropriate target framework.

## Academic Credit
This application was originally developed as part of a software development course assignments, focused on practical mobile development.

## What I Learned
Structuring apps using MVVM

Handling cross-platform UI consistency

Implementing real-time form validation

Managing platform-specific features (camera, file system)

Applying clean code principles and modern architecture

