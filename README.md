# Rectangle Coordinate Matcher API

## Overview

This .NET Web API is designed to efficiently match coordinates against a database of rectangles. It leverages modern software design principles and technologies for spatial data processing, suitable for various applications.

## Key Features

- **Data Seeding**: Automated seeding of 200 rectangle data entries into the database.
- **Coordinate Matching**: Accepts an array of coordinates and matches each against defined rectangles in the database.
- **Scalable Design**: Built with scalability in mind, ensuring performance under load.

## Technologies Used

- **Fluent Validation**: For query validation.
- **Dependency Injection**: Ensuring modularity and testability.
- **Onion Architecture**: For a maintainable and loosely coupled design.
- **Entity Framework**: ORM for database interactions.
- **MediatR**: For implementing the Mediator pattern.
- **Design Patterns**: Utilized various design patterns for optimal solutions.
- **Custom Data Seeding**: Tailored data seeding for initial database setup.
- **Extensibility**: The project is open for extension.
- **Code First Approach & Migrations**: For database schema management.

## Getting Started

### Prerequisites

- .NET 5.0 or later

### Installation

1. Clone the repository:

```git clone https://github.com/AliAliyev2005/RectMatch_API.git```

3. Navigate to the project directory:
   
```cd RectMatch_API```

5. Build and run the application:

```dotnet build```
```dotnet run```

## Usage

Send an HTTP request to the endpoint with an array of coordinates. The response will include a list of rectangles that the coordinates fall into.
