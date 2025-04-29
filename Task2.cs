// Task2.cs
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonAssignment
{
    class Task2
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("Task 2: Adding new entries to a JSON object");
            
            // Read the existing JSON file
            string jsonData = File.ReadAllText("users.json");
            Console.WriteLine("Original JSON content:");
            Console.WriteLine(jsonData);
            
            // Deserialize the JSON into a list of User objects
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);
            
            // Add new entries to the JSON object
            User user3 = new User
            {
                Id = 3,
                Name = "Robert Johnson",
                Email = "robert.johnson@example.com",
                Age = 35
            };
            
            User user4 = new User
            {
                Id = 4,
                Name = "Emily Davis",
                Email = "emily.davis@example.com",
                Age = 26
            };
            
            // Add the new users to the list
            users.Add(user3);
            users.Add(user4);
            
            // Serialize the updated list back to JSON
            string updatedJsonData = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            
            // Save the updated JSON to the file
            File.WriteAllText("users.json", updatedJsonData);
            
            Console.WriteLine("\nUpdated JSON content:");
            Console.WriteLine(updatedJsonData);
            
            Console.WriteLine("\nPress any key to continue to Task 3...");
            Console.ReadKey();
        }
    }
}