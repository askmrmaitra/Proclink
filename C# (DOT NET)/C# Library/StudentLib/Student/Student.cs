using System;

namespace StudentLib
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public void GetData()
        {
            Console.Write("Enter Id: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Course: ");
            Course = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Course: {Course}";
        }
    }
}