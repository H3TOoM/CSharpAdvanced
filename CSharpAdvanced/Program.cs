
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    internal class Program
    {
        // Task-Based Asynchronous Pattern (TAP)
        // Introduced in C# 5.0, TAP is the preferred way to write asynchronous code using async and await keywords.
        // It simplifies asynchronous programming by allowing developers to write code that looks synchronous while being asynchronous under the hood.
        // This pattern improves code readability and maintainability.

        private static async Task GetTask()
        {
            await Task.Delay(1000);
            Console.WriteLine("Task 1 Completed");
        }
        private static async Task GetTask2()
        {
            await Task.Delay(1500);
            Console.WriteLine("Task 2 Completed");
        }

        private static void PrintMessage()
        {
            Console.WriteLine("Ladies and Gentelmans, I'm Hatim Rajab :) ");
        }   
        static async Task Main(string[] args)
        {
            PrintMessage();
            await Task.WhenAll(GetTask(), GetTask2()); // Await both tasks to complete
                                                       // This ensures the Main method waits for both asynchronous operations to finish
                                                       // before exiting the program.

            await Task.Delay(500); // Additional delay to ensure all messages are printed before the program exits
            Console.WriteLine("---------------------------------------------------");
            await Task.WhenAny(GetTask(), GetTask2()); // Await the first task to complete
                                                       // This demonstrates how to proceed as soon as one of the asynchronous operations finishes.
                                                       // The other task will continue to run in the background.
        }

        // Note: In C# 7.1 and later, the Main method can be declared as async Task or async Task<int>,
        // allowing for asynchronous operations directly within the entry point of the application.
        // This feature enhances the ability to write asynchronous code from the very start of the program.
        // In this example, we demonstrate the use of async Main method to perform asynchronous tasks.
        // The use of Task.WhenAll and Task.WhenAny showcases how to manage multiple asynchronous operations effectively.
        // This approach is particularly useful in scenarios where multiple independent tasks need to be executed concurrently.
        // It improves the overall responsiveness and efficiency of applications, especially in I/O-bound operations.
        // By leveraging the async and await keywords, developers can write cleaner and more maintainable code,
        // reducing the complexity associated with traditional asynchronous programming models.
        // Overall, the Task-Based Asynchronous Pattern is a powerful feature in C# that enhances the language's capabilities for building modern, responsive applications.
    }
}

