using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EntityFrameworkExamples;

namespace EntityFrameworkExamples
{
    class Program
    {
        static void Main()
        {
            const string filePath = "data.txt";

            // Check if the file exists, if not show a message and exit gracefully
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Data file '{filePath}' not found. Please ensure the file exists.");
                return; // Exit gracefully
            }

            // Configure Dependency Injection
            var serviceProvider = new ServiceCollection()
                .AddDbContext<StudentContext>(options =>
                    options.UseSqlServer("Data Source=LAPTOP-0P39KA33\\SQLEXPRESS;Initial Catalog=CSharpB18;User ID=csharpb18;Password=123456;TrustServerCertificate=True;"))
                .BuildServiceProvider();

            // Read Data from the file
            var lines = File.ReadAllLines(filePath);

            // Insert Data into the Database
            using var context = serviceProvider.GetService<StudentContext>();
            if (context == null)
            {
                Console.WriteLine("Failed to retrieve database context.");
                return;
            }

            foreach (var line in lines)
            {
                var data = line.Split(' ');
                if (data.Length == 3)
                {
                    var student = new Student
                    {
                        Name = data[0],
                        Age = int.Parse(data[1]),
                        CGPA = double.Parse(data[2])
                    };
                    context.Students?.Add(student);
                }
            }

            context.SaveChanges();
            Console.WriteLine("Data inserted successfully.");
        }
    }
}
