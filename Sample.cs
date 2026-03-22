using System;
using System.Collections.Generic;
using System.Text;

namespace SahasraDebuggingMaster
{
    using System;

    public class Calculator
    {
        // Method 1: Without parameters & without return type
        public void SayHello()
        {
            Console.WriteLine("Welcome to Calculator");
        }

        // Method 2: With parameters & without return type
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition: " + result);
        }

        // Method 3: Without parameters & with return type
        public int GetNumber()
        {
            return 10;
        }

        // Method 4: With parameters & with return type
        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }

    class Program1
    {
        static void Main()
        {
            // Object creation
            Calculator calc = new Calculator();

            // Calling method without parameters & without return
            calc.SayHello();

            // Calling method with parameters & without return
            calc.Add(5, 3);

            // Calling method without parameters & with return
            int num = calc.GetNumber();
            Console.WriteLine("Number: " + num);

            // Calling method with parameters & with return
            int mul = calc.Multiply(4, 5);
            Console.WriteLine("Multiplication: " + mul);
        }
    }
}
