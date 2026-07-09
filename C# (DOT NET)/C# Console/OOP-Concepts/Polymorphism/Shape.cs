using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    #region Function/Method Overloading
    public class Shape
    {
        public void Area(int Side)
        {
            int SquareArea = Side * Side;
            Console.WriteLine("The Area of Square is: " + SquareArea);
        }
        public void Area(int Length, int Bredth)
        {
            int RectangleArea = Length * Bredth;
            Console.WriteLine("The Area of Rectangle is: " + RectangleArea);

        }
        public void Area(double Radius)
        {
            double CircleArea = 3.14 * Radius * Radius;
            Console.WriteLine("The Area of Circle is: " + CircleArea);
        }
        public double Area(double Base, double Height)
        {
            double TriangleArea = (Base * Height) / 2;
            Console.WriteLine("The Area of Triangle is: " + TriangleArea);
            return TriangleArea;
        }
    }
    #endregion

    #region Function/Method Overriding
    public class Person
    {
        int fAge;

        public Person()
        {
            fAge = 21;
            Console.WriteLine("Person Class's Constructor Called");
        }
        public string GeneID()
        {
            return "NormalVal1";
        }
        public virtual void setAge(int age)
        {
            fAge = age;
        }
        public virtual int getAge()
        {
            return fAge;
        }
    }

    public class AdultPerson : Person
    {
        public AdultPerson() { Console.WriteLine("Adult Person Class's Constructor Called"); }
        public override void setAge(int age)
        {
            if (age > 21)
                base.setAge(age);
            else
                Console.WriteLine("Adult Person's age can not be less than 21...");
        }
    }

    #endregion

    #region Operator Overloading
    class MySpecialClass
    {
        private int Number1;
        private int Number2;
        public MySpecialClass()
        {
        }
        public MySpecialClass(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }
        public void ShowData()
        {
            Console.WriteLine("The Numbers are: " + Number1 + " and " + Number2);
        }

        // The Block should be
        // 1. public
        //2. static
        //3. Use the operator keyword
        //4. Operator

        // First Let us Overload - Unary Operator
        public static MySpecialClass operator -(MySpecialClass opr)
        {
            //MySpecialClass obj = new MySpecialClass();
            //obj.Number1 = -opr.Number1;
            //obj.Number2 = -opr.Number2;
            //return obj;

            opr.Number1 = -opr.Number1;
            opr.Number2 = -opr.Number2;
            return opr;

        }

        //Binary + Operator Overloading
        public static MySpecialClass operator +(MySpecialClass opr1, MySpecialClass opr2)
        {
            MySpecialClass obj = new MySpecialClass();
            obj.Number1 = opr1.Number1 + opr2.Number1;
            obj.Number2 = opr1.Number2 + opr2.Number2;
            return obj;
        }

        //Binary Multiplication Operator Overloading
        public static MySpecialClass operator *(MySpecialClass opr1, MySpecialClass opr2)
        {
            MySpecialClass obj = new MySpecialClass();
            obj.Number1 = opr1.Number1 * opr2.Number1;
            obj.Number2 = opr1.Number2 * opr2.Number2;
            return obj;
        }


    }
    #endregion
}
