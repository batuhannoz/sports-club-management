# Sports Club Management System

A comprehensive desktop application for managing sports club operations, including member management, subscription plans, timetables, and health status tracking.

## Features

### User Management
- User registration and authentication
- Profile management (personal information, contact details)
- Role-based access control with different permission levels
- Address management for members

### Subscription Management
- Multiple subscription plan types
- Plan creation and management
- Active subscription tracking
- Payment handling
- Subscription status monitoring

### Schedule Management
- Weekly timetable for different plans
- Group activity scheduling
- Customizable time slots

### Health Tracking
- Member health status monitoring
- Health records management

### Administrative Features
- User profile management
- Permission management
- Database backup and restore
- Member search functionality
- Comprehensive reporting

## Technology Stack

- **Frontend**: Windows Forms (.NET)
- **Backend**: C#
- **Database**: Microsoft SQL Server
- **Containerization**: Docker

## Getting Started

### Prerequisites

- Docker
- .NET Framework
- Windows Forms compatible environment

### Database Setup

1. Navigate to the `/db` directory
2. Build the Docker image:
```bash
docker build -t sports-club-db .
```
3. Run the container:
```bash
docker run -v backups:/var/opt/mssql/backups -p 1433:1433 -d sports-club-db
```

### Application Setup

1. Clone the repository
2. Open the solution in Visual Studio
3. Build and run the application
4. Default admin credentials:
   - Username: admin@admin.com
   - Password: admin

## Project Structure

- `/app`: Contains the main application code
  - User interface components
  - Business logic
  - Data access layer
- `/db`: Database scripts and Docker configuration
  - SQL scripts
  - Schema definitions
  - Stored procedures
  - Triggers

## Database Schema

The system uses a relational database with the following key entities:
- Users
- Profiles
- Permissions
- Plans
- Subscriptions
- Health Records
- Addresses
- Timetables

## Security Features

- Password-protected user accounts
- Role-based access control
- Permission-based feature access
- Secure database connections

## Acknowledgments

- Fatih Kayaalp
- Düzce University
- Course: BM309 Database Management Systems

---
*Note: This project was developed as part of a database management systems course at Düzce University.*
