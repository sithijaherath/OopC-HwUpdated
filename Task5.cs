// Task5.cs
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonAssignment
{
    class Task5
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("Task 5: Creating new JSON file with user_types data and deserializing it");
            
            // Create lists to store specialized user types
            List<AdminUser> adminUsers = new List<AdminUser>
            {
                new AdminUser
                {
                    Id = 101,
                    Name = "Admin Smith",
                    Email = "admin.smith@example.com",
                    Age = 42,
                    Permissions = new string[] { "UserManagement", "ContentEditing", "SystemConfig" },
                    Department = "IT",
                    IsSuperAdmin = true
                },
                new AdminUser
                {
                    Id = 102,
                    Name = "Admin Johnson",
                    Email = "admin.johnson@example.com",
                    Age = 38,
                    Permissions = new string[] { "UserManagement", "ReportViewing" },
                    Department = "HR",
                    IsSuperAdmin = false
                }
            };
            
            List<CustomerUser> customerUsers = new List<CustomerUser>
            {
                new CustomerUser
                {
                    Id = 201,
                    Name = "Customer Brown",
                    Email = "customer.brown@example.com",
                    Age = 32,
                    CustomerType = "Premium",
                    RegistrationDate = new DateTime(2020, 5, 15),
                    LoyaltyPoints = 450.75
                },
                new CustomerUser
                {
                    Id = 202,
                    Name = "Customer Williams",
                    Email = "customer.williams@example.com",
                    Age = 29,
                    CustomerType = "Standard",
                    RegistrationDate = new DateTime(2021, 3, 22),
                    LoyaltyPoints = 120.50
                }
            };
            
            // Create a dictionary to store different user types
            var userTypes = new Dictionary<string, object>
            {
                { "AdminUsers", adminUsers },
                { "CustomerUsers", customerUsers }
            };
            
            // Serialize to JSON
            string userTypesJson = JsonConvert.SerializeObject(userTypes, Newtonsoft.Json.Formatting.Indented);
            
            // Save to file
            File.WriteAllText("user_types.json", userTypesJson);
            
            Console.WriteLine("User types JSON file created successfully!");
            Console.WriteLine("\nJSON content:");
            Console.WriteLine(userTypesJson);
            
            // Deserialize the JSON file
            Console.WriteLine("\nDeserializing the user_types.json file...");
            
            string jsonData = File.ReadAllText("user_types.json");
            
            // Using a dynamic object to deserialize the complex structure
            dynamic deserializedData = JsonConvert.DeserializeObject(jsonData);
            
            // Process and display admin users
            Console.WriteLine("\nDeserialized Admin Users:");
            Console.WriteLine("------------------------");
            
            foreach (var admin in deserializedData.AdminUsers)
            {
                Console.WriteLine($"ID: {admin.Id}");
                Console.WriteLine($"Name: {admin.Name}");
                Console.WriteLine($"Email: {admin.Email}");
                Console.WriteLine($"Age: {admin.Age}");
                Console.WriteLine($"Department: {admin.Department}");
                Console.WriteLine($"Is Super Admin: {admin.IsSuperAdmin}");
                
                Console.Write("Permissions: ");
                foreach (var permission in admin.Permissions)
                {
                    Console.Write($"{permission} ");
                }
                Console.WriteLine();
                Console.WriteLine("------------------------");
            }
            
            // Process and display customer users
            Console.WriteLine("\nDeserialized Customer Users:");
            Console.WriteLine("------------------------");
            
            foreach (var customer in deserializedData.CustomerUsers)
            {
                Console.WriteLine($"ID: {customer.Id}");
                Console.WriteLine($"Name: {customer.Name}");
                Console.WriteLine($"Email: {customer.Email}");
                Console.WriteLine($"Age: {customer.Age}");
                Console.WriteLine($"Customer Type: {customer.CustomerType}");
                
                // Convert the date format from the JSON
                DateTime registrationDate = DateTime.Parse(customer.RegistrationDate.ToString());
                Console.WriteLine($"Registration Date: {registrationDate.ToShortDateString()}");
                
                Console.WriteLine($"Loyalty Points: {customer.LoyaltyPoints}");
                Console.WriteLine("------------------------");
            }
            
            Console.WriteLine("\nTask completed successfully!");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}