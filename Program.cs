// Updated Program.cs
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace JsonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JSON Assignment - .NET Class Library Demo");
            Console.WriteLine("=========================================");
            Console.WriteLine("Press any key to start Task 1: Creating JSON file and XML Reader example...");
            Console.ReadKey();
            
            // Run Task 1: Create manual JSON file and XML reader example
            RunTask1();
            
            // Run Task 2: Add new entries to the JSON object
            Task2.Run();
            
            // Run Task 3: Deserialize JSON data into C# objects
            Task3.Run();
            
            // Run Task 4: Use inheritance for specialized user types
            Task4.Run();
            
            // Run Task 5: Create and deserialize user types JSON file
            Task5.Run();
        }
        
        static void RunTask1()
        {
            Console.Clear();
            Console.WriteLine("Task 1: Creating JSON file and XML Reader Example");
            
            // Create a User object
            User user1 = new User
            {
                Id = 1,
                Name = "John Doe",
                Email = "john.doe@example.com",
                Age = 30
            };
            
            User user2 = new User
            {
                Id = 2,
                Name = "Jane Smith",
                Email = "jane.smith@example.com",
                Age = 28
            };
            
            // Create a list of users
            List<User> users = new List<User> { user1, user2 };
            
            // Serialize users to JSON
            string jsonData = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            
            // Save the JSON to a file
            File.WriteAllText("users.json", jsonData);
            Console.WriteLine("JSON file created successfully!");
            Console.WriteLine("\nJSON content:");
            Console.WriteLine(jsonData);
            
            // XML Reader example
            Console.WriteLine("\nXML Reader Example:");
            string xmlFilePath = "users.xml";
            
            // Create an XML file with user data
            CreateSampleXmlFile(xmlFilePath, users);
            
            // Read the XML file
            ReadXmlFile(xmlFilePath);
            
            Console.WriteLine("\nPress any key to continue to Task 2...");
            Console.ReadKey();
        }
        
        // Method to create a sample XML file
        static void CreateSampleXmlFile(string filePath, List<User> users)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "    "
            };
            
            using (XmlWriter writer = XmlWriter.Create(filePath, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Users");
                
                foreach (var user in users)
                {
                    writer.WriteStartElement("User");
                    
                    writer.WriteElementString("Id", user.Id.ToString());
                    writer.WriteElementString("Name", user.Name);
                    writer.WriteElementString("Email", user.Email);
                    writer.WriteElementString("Age", user.Age.ToString());
                    
                    writer.WriteEndElement(); // End User
                }
                
                writer.WriteEndElement(); // End Users
                writer.WriteEndDocument();
            }
            
            Console.WriteLine($"XML file created at: {filePath}");
        }
        
        // Method to read XML file
        static void ReadXmlFile(string filePath)
        {
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "User":
                                Console.WriteLine("\nUser:");
                                break;
                                
                            case "Id":
                                if (reader.Read())
                                    Console.WriteLine($"Id: {reader.Value}");
                                break;
                                
                            case "Name":
                                if (reader.Read())
                                    Console.WriteLine($"Name: {reader.Value}");
                                break;
                                
                            case "Email":
                                if (reader.Read())
                                    Console.WriteLine($"Email: {reader.Value}");
                                break;
                                
                            case "Age":
                                if (reader.Read())
                                    Console.WriteLine($"Age: {reader.Value}");
                                break;
                        }
                    }
                }
            }
        }
    }
    
    // User class definition
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}