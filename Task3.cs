// Task3.cs
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonAssignment
{
    class Task3
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("Task 3: Deserializing all entries (LOOP) from the JSON data into C# objects");
            
            // Read the JSON file
            string jsonData = File.ReadAllText("users.json");
            
            // Deserialize the JSON into a list of User objects
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);
            
            // Use a loop to output each user's data to the console
            Console.WriteLine("User data from JSON file:");
            Console.WriteLine("------------------------");
            
            foreach (User user in users)
            {
                Console.WriteLine($"User ID: {user.Id}");
                Console.WriteLine($"Name: {user.Name}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Age: {user.Age}");
                Console.WriteLine("------------------------");
            }
            
            Console.WriteLine($"Total number of users: {users.Count}");
            
            Console.WriteLine("\nPress any key to continue to Task 4...");
            Console.ReadKey();
        }
    }
}