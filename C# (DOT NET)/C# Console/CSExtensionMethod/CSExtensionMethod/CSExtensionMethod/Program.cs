namespace CSExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aString = "Hello, World!";
            int Vowels = aString.CountVowels();
            Console.WriteLine($"Number of Vowels: {Vowels.ToString()}");
            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static int CountVowels(this string str)
        {
            if(string.IsNullOrEmpty(str)) return 0;
            int count = 0;

            foreach (char c in str.ToLower()) { 
               if("aeiou".Contains(c)) 
                    count++;

            }
            return count;
        }
    }

}
