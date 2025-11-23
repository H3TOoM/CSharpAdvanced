
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

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

#region Generics
//namespace CSharpAdvanced
//{
//    Notes — what this shows and why
//      •	List<T>: a built-in generic collection. It stores elements with compile-time type safety (no boxing/unboxing, no casts).
//      •	Box<T>: a custom generic class. T is a placeholder type that is supplied when the class is used(Box<int>, Box<string>).
//      •	GenericRepository<T>: demonstrates a reusable component that works with any type T.
//      •	Swap<T>: a generic method that operates on any type without duplicating code.

//    Benefits:
//      •	Type safety: compiler enforces correct types.
//      •	Reusability: write once, use for many types.
//      •	Performance: avoids boxing/unboxing and runtime casts.

//    When to use:
//      •	Collections, utilities, repositories, and APIs that should work with many types.
//      •	Constraints (not shown): you can restrict T (e.g., where T : class, where T : new (), or an interface) when you need specific capabilities.

//    What changed
//      •	Replaced the previous example in Program.cs with a concise generics demonstration including a generic class (Box<T>), a generic repository(GenericRepository<T>), and a generic method(Swap<T>). The examples are small, self-contained, and compile under the project's C# and .NET settings.


// Simple generic container
//public class Box<T>
//{
//    public T Value { get; set; }
//    public Box(T value) => Value = value;
//    public override string ToString() => $"Box contains: {Value}";
//}

// Simple generic repository (in-memory)
//public class GenericRepository<T>
//{
//    private readonly List<T> _items = new();
//    public void Add(T item) => _items.Add(item);
//    public IEnumerable<T> GetAll() => _items;
//}

//    internal class Program
//    {
//        // Generic method example
//        static void Swap<T>(ref T a, ref T b)
//        {
//            T temp = a;
//            a = b;
//            b = temp;
//        }

//        static void Main(string[] args)
//        {
//            // 1) Generic List<T> - strongly typed collection
//            var names = new List<string> { "Hatim", "Ahmed" };
//            Console.WriteLine("List<string> contents:");
//            foreach (var name in names)
//                Console.WriteLine($" - {name}");

//            Console.WriteLine();

//            // 2) Generic class: Box<T>
//            var intBox = new Box<int>(42);
//            var stringBox = new Box<string>("Hello Generics");
//            Console.WriteLine(intBox);
//            Console.WriteLine(stringBox);

//            Console.WriteLine();

//            // 3) Generic repository
//            var repo = new GenericRepository<string>();
//            repo.Add("First");
//            repo.Add("Second");
//            Console.WriteLine("GenericRepository<string> contents:");
//            foreach (var item in repo.GetAll())
//                Console.WriteLine($" * {item}");

//            Console.WriteLine();

//            // 4) Generic method: Swap<T>
//            int x = 1, y = 2;
//            Console.WriteLine($"Before swap: x = {x}, y = {y}");
//            Swap(ref x, ref y);
//            Console.WriteLine($"After swap:  x = {x}, y = {y}");

//            string a = "A", b = "B";
//            Console.WriteLine($"Before swap: a = {a}, b = {b}");
//            Swap(ref a, ref b);
//            Console.WriteLine($"After swap:  a={a}, b = {b}");
//        }
//    }
//}
#endregion

#region Operator Overloading
//namespace CSharpAdvanced
//{
// Operator overloading allows custom types to define how operators behave with their instances.
// This enhances code readability and expressiveness by enabling intuitive operations on user-defined types.
// In this example, we define a Complex class representing complex numbers and overload the + and * operators
// to perform addition and multiplication of complex numbers.
// This allows us to use the standard arithmetic operators directly with Complex instances.
// Operator overloading is particularly useful in mathematical and scientific applications where custom data types often require specific operations.
// It improves code clarity by allowing developers to use familiar operators with their own types, making the code more intuitive and easier to understand.
// Note: Not all operators can be overloaded, and certain rules apply to operator overloading in C#.
// For example, if you overload one operator, you must also overload its corresponding operator (e.g., if you overload +, you must also overload -).
// Additionally, operator overloading should be used judiciously to avoid confusion and maintain code readability.
// In this example, we demonstrate operator overloading with a Complex class that supports addition and multiplication of complex numbers.
//    public class Complex
//    {
//        public double Real { get; }
//        public double Imaginary { get; }
//        public Complex(double real, double imaginary)
//        {
//            Real = real;
//            Imaginary = imaginary;
//        }
//        // Overloading the + operator
//        public static Complex operator +(Complex c1, Complex c2)
//        {
//            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
//        }
//        // Overloading the * operator
//        public static Complex operator *(Complex c1, Complex c2)
//        {
//            return new Complex(
//                c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
//                c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
//        }
//        public override string ToString()
//        {
//            return $"{Real} + {Imaginary}i";
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var c1 = new Complex(2, 3);
//            var c2 = new Complex(4, 5);
//            var sum = c1 + c2; // Using overloaded +
//            var product = c1 * c2; // Using overloaded *
//            Console.WriteLine($"c1: {c1}");
//            Console.WriteLine($"c2: {c2}");
//            Console.WriteLine($"Sum: {sum}");
//            Console.WriteLine($"Product: {product}");
//        }
//    }
//}
#endregion

#region Records
//namespace CSharpAdvanced
//{
// Records are a reference type introduced in C# 9.0 that provide built-in functionality for immutability and value-based equality.
// They are particularly useful for defining data-centric types where the primary purpose is to hold data.
// Records automatically generate methods like Equals, GetHashCode, and ToString based on their properties,
// making them ideal for scenarios where you want to compare instances based on their data rather than their references.
// In this example, we define a Person record with properties for Name and Age.
// We then create instances of the Person record and demonstrate value-based equality by comparing two instances with the same data.
//    public record Person(string Name, int Age);
//    internal class Program
//    {
//        // Equal methods and value-based equality are automatically implemented for records.
//        //public override bool Equals(object? obj)
//        //{
//        //    return base.Equals(obj);
//        //}
//        static void Main(string[] args)
//        {
//            var person1 = new Person("Hatim", 20);
//            var person2 = new Person("Hatim", 20);
//            var person3 = new Person("Rajab", 43);
//            Console.WriteLine($"Person 1: {person1}");
//            Console.WriteLine($"Person 2: {person2}");
//            Console.WriteLine($"Person 3: {person3}");

//            // Use value-based equality
//            Console.WriteLine($"person1 == person2: {person1 == person2}"); // True, same data
//            Console.WriteLine($"person1 == person3: {person1 == person3}"); // False, different data
//        }
//    }
//}

// Why use records?
//  •	Immutability: Records are immutable by default, promoting safer and more predictable code.
//  •	Value-based equality: Records compare instances based on their data, making them ideal for data-centric applications.
//  •	Concise syntax: Records provide a concise way to define data types with less boilerplate code.
//  •	Deconstruction: Records support deconstruction, allowing easy extraction of property values.

// When to use records?
//  •	Data transfer objects (DTOs) and models in applications.
//  •	Scenarios where immutability and value-based equality are desired.
//  •	Functional programming patterns where data is treated as immutable.
//  •	When you want to reduce boilerplate code for simple data-holding types.
//  •	When working with pattern matching and want to leverage the benefits of records in C#.

// What changed
//  •	Added a new example demonstrating the use of records in C#.
//  •	Included explanations of the benefits and use cases for records in C# applications.


#endregion

#region Reflection
namespace CSharpAdvanced
{
    using System.Reflection;
    internal class Program
    {
        // Reflection allows inspection of metadata about types at runtime.
        // It enables dynamic type discovery, method invocation, and attribute retrieval.
        // This is useful for scenarios like plugin systems, serialization, and testing frameworks.
        static void Main(string[] args)
        {
            Type type = typeof(SampleClass);
            // Get and display methods
            Console.WriteLine("Methods:");
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine($"- {method.Name}");
            }
            // Get and display properties
            Console.WriteLine("\nProperties:");
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine($"- {prop.Name} ({prop.PropertyType.Name})");
            }
            // Invoke a method dynamically
            var instance = Activator.CreateInstance(type);
            var greetMethod = type.GetMethod("Greet");
            greetMethod?.Invoke(instance, new object[] { "Hatim" });
        }
    }
    public class SampleClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}

// Why use Reflection?
//  •	Dynamic type discovery: Inspect types, methods, properties at runtime.
//  •	Plugin systems: Load and interact with types from external assemblies.
//  •	Serialization: Convert objects to/from different formats dynamically.
//  •	Testing frameworks: Create flexible test cases that adapt to different types.

// When to use Reflection?
//  •	When you need to work with types that are not known at compile time.
//  •	When building frameworks or libraries that require dynamic behavior.
//  •	When implementing serialization/deserialization mechanisms.
//  •	When creating tools that analyze or manipulate code at runtime.
//  •	When building plugin architectures that load modules dynamically.
//  •	When performing advanced debugging or diagnostics that require runtime type information.


#endregion