# SoftwareMackFlightSimWPF
# SoftwareMackFlightSimWPF - Frontend

## Overview

This project is the frontend for **SoftwareMackFlightSim**. I built using **WPF** and follows the **MVVM** pattern. The app allows instructors to monitor and adjust flight simulation parameters (altitude, wind speed, etc.) and visualizes data using **LiveCharts**.

## Features

- Real-time visualization of wind speed and altitude using **LiveCharts**.
- **MVVM** architecture with data binding.
- Easy-to-use interface for controlling flight parameters.

## Tech Stack

- **.NET 7.0 or later**
- **C#**
- **WPF**
- **MVVM Pattern** (via **CommunityToolkit.Mvvm**)
- **LiveCharts** for visualization

- # SoftwareMackFlightSim - Backend

## Overview

This provides the backend services for **SoftwareMackFlightSim**. It exposes RESTful APIs for managing flight parameters and wind speed updates, connecting with the WPF frontend.

## Features

- **REST API** for controlling flight parameters and updating wind speed.
- Uses **SQL Server** with **Entity Framework Core** for data persistence.
- Provides test coverage using **xUnit**.

## Tech Stack

- **.NET 7.0**
- **C#**
- **ASP.NET Core Web API**
- **Entity Framework Core (SQL Server)**
- **xUnit** for unit testing
