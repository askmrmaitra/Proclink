namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static Class Can't be instantiated......
            //Means the following line is not allowed...
            ////testStaticClass obj = new testStaticClass();

            string msg = testStaticClass.returnMsg();
            Console.Write("\nMessage:- " + msg);

            Console.ReadLine();
        }
    }
}
