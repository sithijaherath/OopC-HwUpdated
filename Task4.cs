// Task4.cs
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonAssignment
{
    // Base User class (already defined in Program.cs)
    // public class User
    // {
    //     public int Id { get; set; }
    //     public string Name { get; set; }
    //     public string Email { get; set; }
    //     public int Age { get; set; }
    // }
    
    // AdminUser class - specialized user type that inherits from User
    public class AdminUser : User
    {
        public string[] Permissions { get; set; }
        public string Department { get; set; }
        public bool IsSuperAdmin { get; set; }
    }
    
    // CustomerUser class - another specialized user type that inherits from User
    public class CustomerUser : User
    {
        public string CustomerType { get; set; }
        public DateTime RegistrationDate { get; set; }
        public double LoyaltyPoints { get; set; }
    }
    
    class Task4
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("Task 4: Using inheritance to extend the User class with specialized user types");
            
            // Create specialized user types
            
            // Admin user example
            AdminUser admin1 = new AdminUser
            {
                Id = 101,
                Name = "Admin Smith",
                Email = "admin.smith@example.com",
                Age = 42,
                Permissions = new string[] { "UserManagement", "ContentEditing", "SystemConfig" },
                Department = "IT",
                IsSuperAdmin = true
            };
            
            AdminUser admin2 = new AdminUser
            {
                Id = 102,
                Name = "Admin Johnson",
                Email = "admin.johnson@example.com",
                Age = 38,
                Permissions = new string[] { "UserManagement", "ReportViewing" },
                Department = "HR",
                IsSuperAdmin = false
            };
            
            // Customer user examples
            CustomerUser customer1 = new CustomerUser
            {
                Id = 201,
                Name = "Customer Brown",
                Email = "customer.brown@example.com",
                Age = 32,
                CustomerType = "Premium",
                RegistrationDate = new DateTime(2020, 5, 15),
                LoyaltyPoints = 450.75
            };
            
            CustomerUser customer2 = new CustomerUser
            {
                Id = 202,
                Name = "Customer Williams",
                Email = "customer.williams@example.com",
                Age = 29,
                CustomerType = "Standard",
                RegistrationDate = new DateTime(2021, 3, 22),
                LoyaltyPoints = 120.50
            };
            
            // Display the specialized user types
            Console.WriteLine("\nAdmin Users:");
            Console.WriteLine("------------------------");
            DisplayAdminUser(admin1);
            Console.WriteLine("------------------------");
            DisplayAdminUser(admin2);
            
            Console.WriteLine("\nCustomer Users:");
            Console.WriteLine("------------------------");
            DisplayCustomerUser(customer1);
            Console.WriteLine("------------------------");
            DisplayCustomerUser(customer2);
            
            Console.WriteLine("\nPress any key to continue to Task 5...");
            Console.ReadKey();
        }
        
        // Helper method to display admin user details
        private static void DisplayAdminUser(AdminUser admin)
        {
            Console.WriteLine($"ID: {admin.Id}");
            Console.WriteLine($"Name: {admin.Name}");
            Console.WriteLine($"Email: {admin.Email}");
            Console.WriteLine($"Age: {admin.Age}");
            Console.WriteLine($"Department: {admin.Department}");
            Console.WriteLine($"Is Super Admin: {admin.IsSuperAdmin}");
            Console.WriteLine("Permissions: " + string.Join(", ", admin.Permissions));
        }
        
        // Helper method to display customer user details
        private static void DisplayCustomerUser(CustomerUser customer)
        {
            Console.WriteLine($"ID: {customer.Id}");
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"Email: {customer.Email}");
            Console.WriteLine($"Age: {customer.Age}");
            Console.WriteLine($"Customer Type: {customer.CustomerType}");
            Console.WriteLine($"Registration Date: {customer.RegistrationDate.ToShortDateString()}");
            Console.WriteLine($"Loyalty Points: {customer.LoyaltyPoints}");
        }
    }
}