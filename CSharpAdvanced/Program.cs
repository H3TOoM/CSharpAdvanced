#region Delegates

namespace CSharpAdvanced
{
    internal class Program
    {
        delegate int MathOperation(int a, int b);
        static void PerformOperation(int a, int b, MathOperation operation)
        {
            int result = operation(a, b);
            Console.WriteLine($"Result: {result}");
        }
        static void Main(string[] args)
        {
            PerformOperation(10, 5, (x, y) => x + y); // Addition // Lambda Expression
            PerformOperation(10, 5, (x, y) => x - y); // Subtraction
            PerformOperation(10, 5, (x, y) => x * y); // Multiplication
            PerformOperation(10, 5, (x, y) => x / y); // Division
        }
    }
}

#endregion