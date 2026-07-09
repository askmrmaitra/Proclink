namespace varVsdynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var: - It determines the type at Compile Time 
            var no = 10;
            var aSimpleTest = "Linde";
            Console.WriteLine($"Number: {no} and Data Type:{no.GetType()}");
            Console.WriteLine($"Text: {aSimpleTest} and Data Type:{aSimpleTest.GetType()}");
            
            // dynamic: - It determines the type at Run Time 
            dynamic Number = 10;
            dynamic aSimpleString = "Linde";
            Console.WriteLine($"Number: {Number} and Data Type:{Number.GetType()}");
            Console.WriteLine($"Text: {aSimpleString} and Data Type:{aSimpleString.GetType()}");


            Console.ReadKey();
        }
    }
}
