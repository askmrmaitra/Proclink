using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ConstructorAndDestructor
{
    public class Sandwitch
    {
        string _breadCat = string.Empty;

        //Default Constructor, P.Constructor, Constructor Overloading 
        public Sandwitch()
        {
            _breadCat = "White Bread";
        }

        //Paramerterized Constructor...
        public Sandwitch(string BreadType)
        {
            _breadCat = BreadType;
        }

        ~Sandwitch()
        {
            Console.WriteLine("Sandwitch Object is being Garbage Collected...");
        }
        public string CreateSandwitch()
        {
            return "Sandwitch with " + _breadCat + " will be delivered Shortly...";
        }


    }
}
