// 3 subjects marks phy , chem, maths for each student get percentage 
using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

public class Program_task
{

    #region FindSquare() Function
    //static int FindSquare(int N)
    //{
    //    return N * N;
    //} 
    #endregion

    #region IsEven() Function
    //static Boolean IsEven(int N)
    //{
    //    if (N % 2 == 0) return true; return false;
    //}

    #endregion

    #region FindLargest() Function
    //static int FindLargest(int max,int[]arr){
    //    for(int i = 0; i < 3; i++)
    //    {
    //        if (arr[i] > max)
    //        {
    //            max = arr[i];
    //        }
    //    }
    //    return max;

    //} 
    #endregion

    #region CalculateArea() Function
    //static int CalculateArea(int l , int w)
    //{
    //    return l * w;
    //} 
    #endregion

    #region CountCharacters() Function
    //static int CountCharacters(string input)
    //{
    //    int count = 0;

    //    foreach (char c in input)
    //    {
    //        count++;
    //    }

    //    return count;
    //} 
    #endregion

    #region ConvertToUpper() Function
    //static string ConvertToUpper(string i)
    //{
    //    return i.ToUpper();
    //} 
    #endregion

    #region  FindAverage() Function
    //static int FindAverage(int[] a)
    //{
    //    int sum = 0;
    //    int avg;
    //    for (int i = 0; i < 5; i++)
    //    {
    //        sum = sum + a[i];
    //    }
    //    return sum / 5;
    //} 
    #endregion

    #region CountPositiveNumbers() Function
    //static int CountPositiveNumbers(int[] a)
    //{
    //    int count = 0;
    //    for(int i = 0; i < 5; i++)
    //    {
    //        if (a[i] > 0)
    //        {
    //            count++;
    //        }
    //    }
    //    return count;
    //} 
    #endregion

    #region CalculateGrade() Function
    //static string CalculateGrade(int M)
    //{
    //    if (M >= 90)
    //    {
    //        return "A-Grade";
    //    }
    //    else if (M >= 80 && M < 90)
    //    {
    //        return "B-Grade";
    //    }
    //    else if (M >= 70 && M < 80)
    //    {
    //        return "C-Grade";
    //    }
    //    else if (M >= 60 && M < 70)
    //    {
    //        return "D-Grade";
    //    }
    //    else if (M >= 50 && M < 60)
    //    {
    //        return "E-Grade";
    //    }
    //    else
    //    {
    //        return "You Are Failed For This Subject";
    //    }

    //} 
    #endregion

    static void Main(string[] args)
    {
        #region PCM PERCENTAGE
        //string StudentName;
        //float PhysicsMarks, ChemistryMarks, MathsMarks, PercentageMarks;
        //int Student_id;

        //Console.WriteLine("Enter Student Name");
        //StudentName = Console.ReadLine();
        //Console.WriteLine("Enter Student ID");
        //Student_id = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter Physics Marks");
        //PhysicsMarks = float.Parse(Console.ReadLine());
        //Console.WriteLine("Enter Chemistry Marks");
        //ChemistryMarks = float.Parse(Console.ReadLine());
        //Console.WriteLine("Enter Maths Marks");
        //MathsMarks = float.Parse(Console.ReadLine());
        //PercentageMarks = ((PhysicsMarks + ChemistryMarks + MathsMarks) / 300) * 100;
        //Console.WriteLine("Student: " + StudentName + " Student ID: " + Student_id + " GOT PCM PERCENTAGE OF " + PercentageMarks + "%"); 

        // or 


        //float BaseSalary, Hra, DA, Bonus, TSalaray, TA;
        //Console.WriteLine("PLEASE ENTER YOUR BASIC SALARY");
        //BaseSalary = float.Parse(Console.ReadLine());
        //if (BaseSalary <= 7000)
        //{
        //    Hra = (BaseSalary * 50) / 100;
        //    DA = (BaseSalary * 200) / 100;
        //    Bonus = (BaseSalary * 100) / 100;
        //    TA = (BaseSalary * 10) / 100;
        //}
        //else if (BaseSalary > 7000 && BaseSalary <= 10000)
        //{
        //    Hra = (BaseSalary * 50) / 100;
        //    DA = (BaseSalary * 100) / 100;
        //    Bonus = (BaseSalary * 50) / 100;
        //    TA = (BaseSalary * 20) / 100;
        //}
        //else if (BaseSalary > 10000 && BaseSalary <= 12000)
        //{
        //    Hra = (BaseSalary * 50) / 100;
        //    DA = (BaseSalary * 75) / 100;
        //    Bonus = (BaseSalary * 25) / 100;
        //    TA = (BaseSalary * 30) / 100;
        //}
        //else
        //{
        //    Hra = (BaseSalary * 50) / 100;
        //    DA = (BaseSalary * 75) / 100;
        //    Bonus = (BaseSalary * 25) / 100;
        //    TA = (BaseSalary * 40) / 100;
        //}
        //Console.WriteLine("UR HOUSE RENTAL ALLOENCE  :" + Hra);
        //Console.WriteLine("UR DA :" + DA);
        //Console.WriteLine("UR BONUS TAKEAWAY :" + Bonus);
        //Console.WriteLine("UR TRAVEL ALLOENCE CLAIMABLE :" + TA);
        //TSalaray = BaseSalary + Hra + DA + Bonus + TA;
        //Console.WriteLine("Total In Hand Salaray is : " + TSalaray);
        #endregion

        #region FindSquare()Main
        //1. Write a function FindSquare() that accepts an integer as a parameter and returns its square. Display the returned value in the calling code.
        //int Number = int.Parse(Console.ReadLine());
        //int result = FindSquare(Number);
        //Console.WriteLine(result); 
        #endregion

        #region IsEven()Main
        //2. Create a function IsEven() that accepts a number and returns true if the number is even, otherwise false. Display an appropriate message.
        //int Number = int.Parse(Console.ReadLine());
        //bool result = IsEven(Number);
        //Console.WriteLine(result); 
        #endregion

        #region FindLargest()Main
        //3. Write a function FindLargest() that accepts three integer values and returns the largest among them.
        //int[] largeArray = new int[3];
        //int maxValue = int.MinValue;
        //for (int i = 0; i < 3; i++)
        //{
        //    largeArray[i] = int.Parse(Console.ReadLine());
        //}
        //int result = FindLargest(maxValue, largeArray);
        //Console.WriteLine("Max Value Among Three Is :" + result); 
        #endregion

        #region CalculateArea()Main
        //4. Create a function CalculateArea() that accepts the length and width of a rectangle and returns its area.
        //int Length = int.Parse(Console.ReadLine());
        //int Width = int.Parse(Console.ReadLine());

        //int area = CalculateArea(Length, Width);
        //Console.WriteLine(area); 
        #endregion

        #region CountCharacters()Main
        //5. Write a function CountCharacters() that accepts a string and returns the total number of characters present in it
        //String Character = Console.ReadLine();
        //int Result = CountCharacters(Character);
        //Console.WriteLine(Result); 
        #endregion

        #region ConvertToUpper()Main
        // 6.Create a function ConvertToUpper() that accepts a string and returns the string in uppercase.Display the returned value
        //String Input = Console.ReadLine();
        // String CapsInput = ConvertToUpper(Input);
        // Console.WriteLine(CapsInput); 
        #endregion

        #region  FindAverage()Main
        //Write a function FindAverage() that accepts an integer array and returns the average of all elements in the array.
        //int[] Values = new int[5];
        //for (int i = 0; i < 5; i++)
        //{
        //    Values[i] = int.Parse(Console.ReadLine());
        //}
        //int avg = FindAverage(Values);
        //Console.WriteLine(avg); 
        #endregion

        #region CountPositiveNumbers()Main
        //8. Create a function CountPositiveNumbers() that accepts an integer array and returns the count of positive numbers present in it.
        //int[] Values = new int[5];
        //for(int i = 0; i < 5; i++)
        //{
        //    Values[i] = int.Parse(Console.ReadLine());
        //}
        //int result = CountPositiveNumbers(Values);
        //Console.WriteLine(result); 
        #endregion

        #region CalculateGrade()Main
        //9. Create a function CalculateGrade() that accepts a student's marks (0–100) and returns a grade (A, B, C, D, or F) based on your own grading logic.
        //int StudentMarks = int.Parse(Console.ReadLine());
        //String Grade = CalculateGrade(StudentMarks);
        //Console.WriteLine(Grade); 
        #endregion
    }
}
