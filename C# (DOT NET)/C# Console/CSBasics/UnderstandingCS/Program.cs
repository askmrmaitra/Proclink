using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingCS
{
    struct book
    {
        public int id;
        public string name;
        public string ReturnName()
        {
            return name;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            #region Understand Comment Lines in C#
            //Single Line Comment 
            /* *************************************************
             * Multi-Line Comment.............................
             * ************************************************ */

            //Third type of comment line, Code Documentation 
            #endregion

            #region Printing Hello World...
            //Intellisense 
            //Console.WriteLine("Hello World....");

            #endregion

            #region Understanding Variables

            //// If Both the word's Firstr Letter in Cap, we call it Pascal Case ; Like FirstNumber 
            ////// If First Word's First Letter in Small and Second Word's First Letter in Cap, we call it Camel Case 

            ////int FirstNumber, SecondNumber;
            ////int addNumber;

            ////////Camel Casing firstNumber, Alternatively you can use 
            ////////Pascal Case: FirstNumber
            //int firstNumber, secondNumber, addResult;
            //Console.Write("Enter First Value: ");
            //firstNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Value: ");
            //secondNumber = Convert.ToInt32(Console.ReadLine());

            ////// BEDMAS->A ==> Bracket => Exponentiation => Div,Mul, Add, Sub ==> Assignment

            //addResult = firstNumber + secondNumber;
            //Console.WriteLine("Addition Result: " + addResult.ToString());
            #endregion

            #region Variable Range
            //Console.WriteLine("Integer Maximum Value: " + int.MaxValue);
            //Console.WriteLine("Integer Minimum Value: " + int.MinValue);

            #endregion

            #region Type Casting - Implicit and Explicit
            //float pi = 3.14159f;
            //double pid = pi; //Implicit Casting 

            //double pid = 3.14159;
            //float pi = (float)pid; //Explicit Casting 

            #endregion

            #region Branching 
            #region if-elseif-else

            //int firstNumber = 55;
            //int secondNumber = 58;

            ////Logical Operators 
            //if (firstNumber > secondNumber)
            //{
            //    Console.WriteLine("First Number is bigger");
            //}
            //else if (secondNumber > firstNumber)
            //{
            //    Console.WriteLine("Second Number is Bigger");
            //}
            //else
            //{
            //    Console.WriteLine("Both are same");
            //}


            #endregion

            #region Ternary Operator

            //int firstNumber = 15;
            //int secondNumber = 12;

            ////Ternary Operator: ? and : 
            //int tVar = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            //Console.WriteLine(tVar + " is bigger");
            #endregion

            #region Switch Case 
            //int Number;
            //Console.Write("Enter A Value between 1-4: ");
            //Number = int.Parse(Console.ReadLine());

            //switch (Number)
            //{
            //    case 1:
            //        Console.WriteLine("You have typed 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("You have typed 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("You have typed 3");
            //        break;
            //    case 4:
            //        Console.WriteLine("You have typed 4");
            //        break;
            //    default:
            //        Console.WriteLine("GO To Hell!!!");
            //        break;
            //}
            #endregion

            #region Group Switch 
            //string MonthName;
            //Console.Write("Enter Month Name: ");
            //MonthName = Console.ReadLine();

            //switch (MonthName)
            //{
            //    case "January":
            //    case "March":
            //    case "May":
            //    case "July":
            //    case "October":
            //    case "December":
            //        Console.WriteLine(MonthName + " has got 31 days");
            //        break;

            //    case "April":
            //    case "June":
            //    case "August":
            //    case "September":
            //    case "November":
            //        Console.WriteLine(MonthName + " has got 30 Days");
            //        break;
            //    case "February":
            //        Console.WriteLine(MonthName + " has got 28/29 days");
            //        break;
            //    default:
            //        Console.WriteLine("Please check the spelling of the month");
            //        break;
            //}
            #endregion
            #endregion

            #region Looping 

            #region while

            ////Step 1: Initialize Counter Variables

            //int counterVar = 1;

            ////Step 2: Do Verification 
            //while (counterVar < 10)
            //{
            //    Console.WriteLine("I am executing for counterVar = " + counterVar);
            //    //Step 3: Increment or Decrement the Counter 
            //    counterVar++; //counterVar = counterVar+1

            //}
            //Console.WriteLine("I am executing for counterVar = " + counterVar);

            #endregion

            #region do-while
            ////Step 1: Initialize Counter Variables
            //int counterVar = 15;

            //do
            //{
            //    Console.WriteLine("I am executing for counterVar = " + counterVar);
            //    //Step 2: Increment or Decrement the Counter 
            //    counterVar++; //counterVar = counterVar+1

            //} while (counterVar < 10);//Step 3: Do Verification 

            #endregion

            #region for Loop 

            //for (int counterVar = 1; counterVar < 10; counterVar++)
            //{
            //    Console.WriteLine("I am executing for counterVar = " + counterVar);
            //}
            #endregion

            #region Foreach Loop
            ////In C Programs ==> int arr[10];
            //int[] arr1D = new int[10];

            //int i;
            //for (i = 0; i < 10; i++)
            //{
            //    //How to take Input
            //    Console.Write("Input Value for arr1D[{0}]", i);
            //    arr1D[i] = int.Parse(Console.ReadLine());
            //}
            ////Print the Values

            //foreach (int item in arr1D)
            //    Console.WriteLine("Value ==> {0}", item);




            #endregion

            #endregion

            #region Array in C#

            #region 1D Array 
            ////In C Programs ==> int arr[10];
            //int[] arr1D = new int[3];
            //int i;
            //for (i = 0; i < 3; i++)
            //{
            //    //How to take Input
            //    Console.Write("Input Value for arr1D[{0}]: ", i);
            //    arr1D[i] = int.Parse(Console.ReadLine());
            //}
            ////Print the Values
            //for (i = 0; i < 3; i++)
            //{
            //    ////How to Display
            //    //Console.WriteLine("Value @arr1D[{0}] ==> {1}", i, arr1D[i]);
            //    Console.WriteLine($"Value @arr1D[{i}] ==> {arr1D[i]}");
            //}

            #endregion

            #region Dynamic Arrary Size
            //Console.WriteLine("Input Array Size: ");
            //int arrSize = int.Parse(Console.ReadLine());

            //int[] ints = new int[arrSize];
            //for (int i = 0; i < arrSize; i++)
            //{
            //    Console.WriteLine("Input Element No{0}: ", i);
            //    ints[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}
            #endregion

            #region M-D Array
            ////In C Programs ==> int arr[10][10];
            //int[,] arr2D = new int[3, 3];
            //int row, col;
            //for (row = 0; row < 3; row++)
            //{
            //    for (col = 0; col < 3; col++)
            //    {
            //        //How to take Input
            //        Console.Write("Input Value for arr2D[{0},{1}]", row, col);
            //        arr2D[row, col] = int.Parse(Console.ReadLine());
            //    }
            //}
            ////Print the Values
            //Console.WriteLine("The Input Matrix is as follows....");
            //for (row = 0; row < 3; row++)
            //{
            //    for (col = 0; col < 3; col++)
            //    {
            //        //How to take Input
            //        Console.Write("\t" + arr2D[row, col]);

            //    }
            //    Console.Write("\n");
            //}
            //Console.WriteLine("Transpose Matrix is as follows....");
            //for (row = 0; row < 3; row++)
            //{
            //    for (col = 0; col < 3; col++)
            //    {
            //        //How to take Input
            //        Console.Write("\t" + arr2D[col, row]);

            //    }
            //    Console.Write("\n");
            //}

            #endregion

            #region Jagged Arrary
            #endregion
            #endregion

            #region RowSum and Col Sum
            //int rows = 2;
            //int cols = 3;
            //int[,] array = new int[rows, cols];
            //bool reEnterValues;

            //do
            //{
            //    // Input the array values
            //    Console.WriteLine("Enter the values for the 2x3 array:");

            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write($"Enter value for [{i},{j}]: ");
            //            array[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }


            //    Console.WriteLine("\nSum of each row:");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        int rowSum = 0;
            //        for (int j = 0; j < cols; j++)
            //        {
            //            rowSum += array[i, j];
            //        }
            //        Console.WriteLine($"Row {i + 1}: {rowSum}");
            //    }


            //    Console.WriteLine("\nSum of each column:");
            //    for (int j = 0; j < cols; j++)
            //    {
            //        int colSum = 0;
            //        for (int i = 0; i < rows; i++)
            //        {
            //            colSum += array[i, j];
            //        }
            //        Console.WriteLine($"Column {j + 1}: {colSum}");
            //    }


            //    Console.WriteLine("\nDo you want to re-enter the array values? (yes/no)");
            //    string userResponse = Console.ReadLine().ToLower();
            //    reEnterValues = userResponse == "yes";

            //} while (reEnterValues);

            #endregion

            #region Playing with Function/Method
            #region Simple Function
            //PrintHello();

            ////Instantiate Object to call non-static methods
            //Program o = new Program();
            //o.PrintMessage();

            #endregion

            #region Function with Argument
            ////////Call Add2Numbers with Params 
            //int firstNumber, secondNumber, addResult;
            //Console.Write("Enter First Value: ");
            //firstNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Value: ");

            //secondNumber = int.Parse(Console.ReadLine());


            ////Add2Numbers(firstNumber, secondNumber);
            //addResult = Add2Nos(firstNumber, secondNumber);
            //Console.WriteLine("Addition Result:{0}", addResult);
            //addResult = AddValues(firstNumber, secondNumber);
            //Console.WriteLine("Addition Result is: " + addResult);
            //Console.Write("Enter Third Value: ");
            //int thirdNumber = int.Parse(Console.ReadLine());
            //addResult = AddValues(firstNumber, secondNumber, thirdNumber);

            //Console.WriteLine("Addition Result:{0}", addResult);
            #endregion
            #endregion

            #region String Related Ops
            //Console.WriteLine("Write Your Name IN \"CAPITAL\": ");
            //string Name = Console.ReadLine();
            //Console.WriteLine(StringLower(Name));
            //Console.WriteLine(StringUpper(Name));
            //Console.WriteLine(GetStringLength(Name));

            //Console.WriteLine("Write India is a great country: ");
            //string inputString = Console.ReadLine();
            //string substringResult = GetSubstring(inputString, 6, 5);
            //Console.WriteLine("Substring: " + substringResult);

            //string replacedString = ReplaceSubstring(inputString, "India", "Pakistan");
            //Console.WriteLine("String Replaced': " + replacedString);
            #endregion

            #region String Array
            //string[] arrNames = { "Delhi", "MuMbai", "BengaAluru", "Kolkata" };

            string[] arrNames = new string[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine($"Enter A String for Array[{i}]: ");
                arrNames[i] = Console.ReadLine();
            }

            string[] arrLowerCase = ConvertStringArray(arrNames);

            foreach (string s in arrLowerCase)
            {
                Console.WriteLine(s);
            }
            #endregion

            #region Factorial W/O Recursion
            //int aNumber = 5;
            //Console.WriteLine("Factorial of 5 is: {0}", FactorialR(aNumber));
            //Console.WriteLine("Factorial of 5 is: {0}", Factorial(aNumber));
            #endregion


            Console.Write("PRESS ENTER TO TERMINATE");
            Console.ReadLine();
        }

        #region Function/Method
        #region Function without Argument and does not return anything
        static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        #endregion

        #region Function without Static
        void PrintMessage()
        {
            Console.WriteLine("Hello, I am Print Message");
        }
        #endregion

        #region Function with Arguments
       
        public static void Add2Numbers(int FNo,int SNo)
        {
            Console.WriteLine("Addition Result: {0}",(FNo+SNo));
        }
        #endregion

        #region Function with Arguments and Return Types
       
        /// <summary>
        /// Add two Integer Numbers
        /// </summary>
        /// <param name="FNo">First Input</param>
        /// <param name="SNo">Second Input</param>
        /// <returns>Int32</returns>
        public static int Add2Nos(int FNo,int SNo)
        {
            int addR = FNo + SNo;
           return addR;
        }
        #endregion

        #region Function with Default Argument 
        public static int AddValues(int FNo,int SNo,int TNo=0) {
               return FNo + SNo + TNo;
        }

        #region Use Case where Default Argument can be used 

        /////public static int SaveStudent(string Name, string Phone, string Email, int ID = 0, string SaveOperation = "I")
        //////{

        /// <summary>
        /// ///    // Save Related Signature... 
        /// </summary>
        /// <param name="ValueToBeConverted"></param>
        /// <returns></returns>

        ////}

        #endregion

        #endregion

        #region String Related Functions 
        #region String Lower 
        public static string StringLower(string ValueToBeConverted)
        {
            return ValueToBeConverted.ToLower();
        }
        #endregion

        #region String Upper
        public static string StringUpper(string ValueToBeConverted)
        {
            return ValueToBeConverted.ToUpper();
        }
        #endregion

        #region String Length 
       public static int GetStringLength(string input)
        {
            return input.Length;
        }
        #endregion

        #region Fetch Substring
       public static string GetSubstring(string input, int startIndex, int length)
        {
            return input.Substring(startIndex, length);
        }
        #endregion

        #region Replace String 
        public static string ReplaceSubstring(string input, string oldValue, string newValue)
        {
            return input.Replace(oldValue, newValue);
        }

        #endregion
        #endregion

        #region Function Accepts String Array as Argument and Return String Array
        public static string[] ConvertStringArray(string[] input)
        {
            int NumberOfValues = input.Length;
            string[] ConvertedArrary = new string[NumberOfValues];

            for (int s = 0; s < NumberOfValues; s++)
            {
                ConvertedArrary[s] = input[s].ToLower();
            }

            //foreach (string value in input)
            //{
            //    ConvertedArrary.Append(value.ToLower());
            //}

            return ConvertedArrary;
        }
        #endregion

        #region Recursion
        public static int FactorialR(int Number)
        {
            Console.WriteLine("Now calculating for {0}!",Number);
            if (Number == 1)
            {

                return 1;
            }
            else
            {

              return Number * FactorialR(Number - 1);
            }
        }
        public static int Factorial(int Number)
        {
            int FactorialN = 1;

            for (int i = Number; i >= 1; i--)
            {
                FactorialN = FactorialN * i;
            }
            return FactorialN;
        }

        #endregion

        
        #endregion

    }
}
