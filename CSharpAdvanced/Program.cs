
using System.Threading.Tasks;

#region TaskBasedAsynchronousPattern
//namespace CSharpAdvanced
//{
//    internal class Program
//    {
//        // Task-Based Asynchronous Pattern (TAP)
//        // Introduced in C# 5.0, TAP is the preferred way to write asynchronous code using async and await keywords.
//        // It simplifies asynchronous programming by allowing developers to write code that looks synchronous while being asynchronous under the hood.
//        // This pattern improves code readability and maintainability.

//        private static async Task GetTask()
//        {
//            await Task.Delay(1000);
//            Console.WriteLine("Task 1 Completed");
//        }
//        private static async Task GetTask2()
//        {
//            await Task.Delay(1500);
//            Console.WriteLine("Task 2 Completed");
//        }

//        private static void PrintMessage()
//        {
//            Console.WriteLine("Ladies and Gentelmans, I'm Hatim Rajab :) ");
//        }   
//        static async Task Main(string[] args)
//        {
//            PrintMessage();
//            await Task.WhenAll(GetTask(), GetTask2()); // Await both tasks to complete
//                                                       // This ensures the Main method waits for both asynchronous operations to finish
//                                                       // before exiting the program.

//            await Task.Delay(500); // Additional delay to ensure all messages are printed before the program exits
//            Console.WriteLine("---------------------------------------------------");
//            await Task.WhenAny(GetTask(), GetTask2()); // Await the first task to complete
//                                                       // This demonstrates how to proceed as soon as one of the asynchronous operations finishes.
//                                                       // The other task will continue to run in the background.
//        }

//        // Note: In C# 7.1 and later, the Main method can be declared as async Task or async Task<int>,
//        // allowing for asynchronous operations directly within the entry point of the application.
//        // This feature enhances the ability to write asynchronous code from the very start of the program.
//        // In this example, we demonstrate the use of async Main method to perform asynchronous tasks.
//        // The use of Task.WhenAll and Task.WhenAny showcases how to manage multiple asynchronous operations effectively.
//        // This approach is particularly useful in scenarios where multiple independent tasks need to be executed concurrently.
//        // It improves the overall responsiveness and efficiency of applications, especially in I/O-bound operations.
//        // By leveraging the async and await keywords, developers can write cleaner and more maintainable code,
//        // reducing the complexity associated with traditional asynchronous programming models.
//        // Overall, the Task-Based Asynchronous Pattern is a powerful feature in C# that enhances the language's capabilities for building modern, responsive applications.
//    }
//}
#endregion

#region Enumerables
//namespace CSharpAdvanced
//{
//    internal class Program
//    {
//        // Example of using IEnumerable<T> to represent a collection of employees
//        // IEnumerable<T> is a fundamental interface in C# that allows iteration over a collection of a specified type.
//        // It provides a way to access elements sequentially without exposing the underlying collection's structure.
//        // This example demonstrates how to create a list of employees and iterate through them using foreach and for loops.
//        // This approach is useful for scenarios where you need to work with collections in a read-only manner,
//        // allowing for flexibility and abstraction in handling different types of data sources.
//        static async Task Main(string[] args)
//        {
//            IEnumerable<Employee> employees = new List<Employee>
//            {
//               new Employee { Name = "Hatim", Salary = 60000 },
//               new Employee { Name = "Rajab", Salary = 55000 },
//               new Employee { Name = "Rabea", Salary = 70000 }
//            };

//            // Display all employees
//            Console.WriteLine("All Employees:");
//            foreach (var emp in employees)
//                Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");


//            // Display employees by for loop
//            Console.WriteLine("\nEmployees using for loop:");
//            var empList = employees.ToList();
//            for (int i = 0; i < empList.Count; i++)
//                Console.WriteLine($"Name: {empList[i].Name}, Salary: {empList[i].Salary}");

//        }

//        // Note: In this example, we create a list of Employee objects and assign it to an IEnumerable<Employee> variable.
//        // We then demonstrate two common ways to iterate over the collection: using a foreach loop and a for loop.
//        // This showcases the versatility of IEnumerable<T> in handling collections in C#.
//        // The use of IEnumerable<T> allows for easy integration with LINQ queries and other collection manipulation techniques,
//        // making it a powerful tool for working with data in C# applications.
//    }
//}
#endregion