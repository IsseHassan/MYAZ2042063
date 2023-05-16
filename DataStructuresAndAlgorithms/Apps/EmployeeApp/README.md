# MYAZ2042063

EmployeeApp is a project that provides functionality for managing employee information through a RESTful API. It allows you to perform CRUD (Create, Read, Update, Delete) operations on employee records.

## Installation

1. Clone the repository: `git clone https://github.com/IsseHassan/MYAZ2042063.git`
2. Navigate to the project directory: `cd MYAZ2042063`
3. Select EmployeeApp as the startup project in your preferred development environment.
4. Install dependencies: `dotnet restore`

## Usage

1. Start the application: `dotnet run`
2. The API will be available at `https://localhost:7289/api/employees`

### Endpoints

- `GET /api/employees`: Retrieve a list of all employees.
- `GET /api/employees/{id}`: Retrieve an employee by ID.
- `POST /api/employees`: Create a new employee.
- `PUT /api/employees/{id}`: Update an existing employee by ID.
- `DELETE /api/employees/{id}`: Delete an employee by ID.

### Request and Response Format

The API accepts and returns data in JSON format. For example, 
when creating a new employee, you can send a POST request with the following JSON payload:

{
  - "firstName": "John",
  - "lastName": "Doe",
  - "title": "Software Engineer",
  - "salary": 50000.0
  
 }

The API will respond with the created employee object, including the assigned ID.
