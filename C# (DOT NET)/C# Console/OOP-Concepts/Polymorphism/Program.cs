namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Function/Method Overloading
            //Shape shape = new Shape();
            //shape.Area(15);
            //shape.Area(10.5);

            //shape.Area(15.5, 20.4);
            //shape.Area(10, 20);

            #endregion

            #region Function Overriding

            //Person p = new Person();
            //p.setAge(12);
            //AdultPerson ap = new AdultPerson();
            //Console.WriteLine("\nInput Adult Person's Age:- ");
            //int age = int.Parse(Console.ReadLine());
            //ap.setAge(age);
            //Console.WriteLine("\n\tPersons Age: {0}\n\t And Adult Person's Age:{1}", p.getAge(), ap.getAge());

            ////Person b = new AdultPerson();
            ////b.setAge(12);
            #endregion

            #region Operator Overloading

            //int fNo, sNo;
            //Console.WriteLine("\nInput Two Numbers...Separate by Enter...");
            //fNo = int.Parse(Console.ReadLine());
            //sNo = int.Parse(Console.ReadLine());

            //////parameterized Constructor will be called in the following case....
            //MySpecialClass opr1 = new MySpecialClass(fNo, sNo);
            //Console.WriteLine("Before Operator Overloading");
            //Console.WriteLine("*****************************");
            //opr1.ShowData();

            //////Non - parameterized(default) Constructor will be called in the following case .. ..
            //MySpecialClass opr2 = new MySpecialClass();
            //MySpecialClass opr3 = new MySpecialClass();

            //opr1 = -opr1;

            //opr2 = -opr1; //It's perfect...Coz., - operator has been overloaded...
            //opr3 = -opr2;

            //Console.WriteLine("After Operator Overloading");
            //Console.WriteLine("---------------------------");
            //opr2.ShowData();
            //opr3.ShowData();

            //MySpecialClass opr1 = new MySpecialClass(5, 7);
            //MySpecialClass opr2 = new MySpecialClass(7, 6);
            //MySpecialClass opr3 = new MySpecialClass();
            //Console.WriteLine("Before Operator Overloading respectively");
            //Console.WriteLine("---------------------------");
            //opr1.ShowData();
            //opr2.ShowData();

            //Console.WriteLine("After Operator Overloading");
            //Console.WriteLine("---------------------------");
            //opr3 = opr1 + opr2;
            //opr3.ShowData();
            //opr3 = opr1 * opr2;
            //opr3.ShowData();

            #endregion

            Console.ReadKey();
        }
    }
}
