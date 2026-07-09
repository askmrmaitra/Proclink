namespace _2_ConstructorAndDestructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sandwitch sandwitch = new Sandwitch();
            //string msg = sandwitch.CreateSandwitch();
            //Console.WriteLine("First Sandwitch with: " + msg);

            ////Using Destructor
            //sandwitch = null;

            ////Console.WriteLine("First Sandwitch with: " + sandwitch.CreateSandwitch());
            //GC.Collect();
            ////Wait For Garbage Collector to Finish 
            //GC.WaitForPendingFinalizers();

            //Sandwitch sandwitch1 = new Sandwitch("CheeseBase");
            //string msg = sandwitch1.CreateSandwitch();
            //Console.WriteLine("Second Sandwitch with: " + msg);

            Console.WriteLine("PRESS ANY KEY TO TERMINATE");
            Console.ReadKey();
        }
    }
}
