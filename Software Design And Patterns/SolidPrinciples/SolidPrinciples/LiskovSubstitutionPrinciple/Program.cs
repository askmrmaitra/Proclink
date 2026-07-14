using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== GOOD DESIGN =====");

            ILecturer math = new MathLecturer();
            ILecturer english = new EnglishLecturer();

            math.Teach();
            english.Teach();

            Console.WriteLine();

            Console.WriteLine("===== BAD DESIGN =====");

            Lecturer lecturer = new MathOnlyLecturer();

            lecturer.TeachMath();

            try
            {
                lecturer.TeachEnglish();   // Runtime Error
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }

    #region Good Design

    public interface ILecturer
    {
        void Teach();
    }

    public class MathLecturer : ILecturer
    {
        public void Teach()
        {
            Console.WriteLine("Math Lecturer teaches Mathematics.");
        }
    }

    public class EnglishLecturer : ILecturer
    {
        public void Teach()
        {
            Console.WriteLine("English Lecturer teaches English.");
        }
    }

    public class ScienceLecturer : ILecturer
    {
        public void Teach()
        {
            Console.WriteLine("Science Lecturer teaches Science.");
        }
    }

    #endregion

    #region Bad Design

    public class Lecturer
    {
        public virtual void TeachMath()
        {
            Console.WriteLine("Teaching Mathematics");
        }

        public virtual void TeachEnglish()
        {
            Console.WriteLine("Teaching English");
        }

        public virtual void TeachScience()
        {
            Console.WriteLine("Teaching Science");
        }
    }

    public class MathOnlyLecturer : Lecturer
    {
        public override void TeachMath()
        {
            Console.WriteLine("Math Lecturer teaches Mathematics.");
        }

        public override void TeachEnglish()
        {
            throw new NotSupportedException("Math Lecturer cannot teach English.");
        }

        public override void TeachScience()
        {
            throw new NotSupportedException("Math Lecturer cannot teach Science.");
        }
    }
    #endregion
}