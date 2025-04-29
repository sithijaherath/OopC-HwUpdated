#.NET JSON Data Processing

This project demonstrates how to deal with JSON data in a.NET console application using the Newtonsoft.Json package, and inheritance and serialization/deserialization concepts.

## Project Organization

The solution contains the following major components:

- **Program.cs**: Top-level entry point where all tasks are executed sequentially
- **Task1-5.cs**: Separate implementations of tasks
- **User.cs**: Inheritance-based base class and special user classes

## Tasks Implementation

### Task 1: Creating Manual JSON File and XML Reader Example
- Developed a User class with basic properties
- Serialized User objects to JSON using Newtonsoft.Json
- Implemented creation and reading using System.Xml

### Task 2: Adding New Entries to a JSON Object
- Read existing JSON data from file
- Deserialized into objects in C#
- Added new entries to the set
- Serialized back to JSON and saved

### Task 3: Deserializing JSON Data into C# Objects
- Applied a loop to deserialize all items from the JSON file
- Wrote out each object's properties to the console
- Handled collections correctly

### Task 4: Using Inheritance to Extend the User Class
- Created specialized user types (AdminUser, CustomerUser) from the inherited User
- Added type-specific properties to each inherited class
- Demonstrated polymorphism concepts

### Task 5: Serialization and Deserialization of User Types JSON Data
- Created a new JSON file containing different types of users
- Used a dictionary to store different collections
- Performed deserialization of the complex nested object
- Displayed the deserialized output

## Version History

| Version | Description |
|---------|-------------|
| v1.0    | Initial version with Task 1 - Creation of JSON file and XML reader sample
| v2.0    | Included Task 2 - Adding new entries to a JSON object |
| v3.0    | Completed Task 3 - Deserializing JSON data into C# objects |
| v4.0    | Included Task 4 - Using inheritance for special user types |
| v5.0    | Completed Task 5 - Deserializing and creating user types JSON file

## How to Run

1. Clone the repository
2. Open the solution in Visual Studio
3. Build the solution
4. Run the application

## Dependencies

-.NET Core 3.1 or newer
- Newtonsoft.Json package

## Notes

- This project was written as an educational example of working with JSON in.NET
- The code follows object-oriented principles and uses inheritance
- Each task is written to be executed step-by-step, based on what has been done previously
