namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exception Basics
            //try
            //{
            //    int fNo = 5;
            //    int sNo = 0;
            //    int result = fNo / sNo;
            //    Console.WriteLine($"Result:{result}");
            //}
            //catch (DivideByZeroException exp)
            //{
            //    Console.WriteLine("Cannot Divide by 0. Exception Thrown: {0}", exp.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("OOPS!!! Something wrong has happend. Exception Thrown: {0},exp.Message");
            //}

            //finally
            //{
            //    Console.WriteLine("Block Executed...");
            //}
            #endregion

            #region Exception Throw Concept 
            //try
            //{
            //    ValidateAge(-10);
            //}
            //catch (ArgumentException exp)
            //{
            //    Console.WriteLine($"Error: {exp.Message}");
            //}
            #endregion

            #region Custom Exception
            //try
            //{
            //    Withdrawmoney(10000, 200000);
            //}
            //catch (InsufficientBalanceException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
        }
        public static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Age Cannot be Negative");
            }
            else
            {
                Console.WriteLine("Age is Valid...");
            }
        }
        public static void Withdrawmoney(int balance,int amount)
        {
            if (balance < amount) {
                throw new InsufficientBalanceException("Insufficient Balance...");
            }
        }
    }

    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message):base(message)
        {
            
        }
    }
}
