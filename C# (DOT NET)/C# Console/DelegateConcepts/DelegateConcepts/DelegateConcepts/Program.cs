using System;

namespace DelegateConcepts
{
    internal class Program
    {
        //Declaration
        public delegate int Calculations(int a, int b);
        public delegate void ArithmeticOperation(int x, int y);
        
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        
        public static void AddP(int x, int y)
        {
            Console.WriteLine("Addition: " + (x + y));
        }

        public static void Subtract(int x, int y)
        {
            Console.WriteLine("Subtraction: " + (x - y));
        }


        static void Main(string[] args)
        {

            #region Fundamental Concept
            ////Create Delegate Instance
            //Calculations addOperation;
            //addOperation = Add;
            ////addOperation = Add(3, 4);
            //Calculations multiplicationOperation = new Calculations(Multiply);
            //int result = multiplicationOperation(15, 2);
            //Console.WriteLine("Addition Result = {0}", addOperation(12, 14));
            //Console.WriteLine("Multiplication Result = {0}", result);
            #endregion

            #region Multicasting Delegate

            //ArithmeticOperation operations = AddP;

            //// Multicasting
            //operations += Subtract;

            //Console.WriteLine("Invoking Multicast Delegate:");
            //operations(20, 10);

            //operations -= Subtract;

            //// Invoke again 
            //Console.WriteLine("\nAfter Removing Subtract:");
            //operations(20, 10);

            #endregion

            #region Predefined Delegates
            #region Func
            ////Structure - Syntax
            ////public delegate TResult Func<in T1, in T2, ..., out TResult>(T1 arg1, T2 arg2, ...);

            ////two integers and returns their sum
            //Func<int, int, int> add = (a, b) => a + b;

            //// Consume
            //int result = add(10, 20);
            //Console.WriteLine($"The sum is: {result}");

            ////Second Scenario
            //Func<string, int> getLength = str => str.Length;
            //Console.WriteLine($"Length of 'Hello': {getLength("Hello")}");
            #endregion

            #region Func 2
            //Func<int, int, int, int> multiplyAndAdd = (a, b, c) => (a * b) + c;

            //int result = multiplyAndAdd(2, 3, 4);
            //Console.WriteLine($"Result: {result}");
            #endregion

            #region Action
            ////Structure 
            ////public delegate void Action<in T1, in T2, ...>(T1 arg1, T2 arg2, ...);

            //Action<string> printMessage = message => Console.WriteLine($"Message: {message}");

            //printMessage("Hello, Action!");

            //Action<int, int> printSum = (a, b) => Console.WriteLine($"Sum: {a + b}");
            //printSum(10, 20);
            #endregion

            #region Predicate Delegate
            ////Structure
            ////public delegate bool Predicate<in T>(T obj);

            //Predicate<int> isEven = number => number % 2 == 0;

            //Console.WriteLine(isEven(10)); // Output: True
            //Console.WriteLine(isEven(15)); // Output: False
            #endregion

            #endregion

            Console.ReadKey();
            

        }
    }
}
