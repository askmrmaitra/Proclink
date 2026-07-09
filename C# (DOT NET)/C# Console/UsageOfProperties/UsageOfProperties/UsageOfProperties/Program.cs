using StudentSystem;
namespace UsageOfProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            StudentManagement smObject = new StudentManagement();

            for (int i = 0; i < 3; i++)
            {

                Student aNewStudent = new Student();
                Console.WriteLine("Input ID: ");
                aNewStudent.id = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Name: ");
                aNewStudent.Name = Console.ReadLine();
                smObject.AddStudent(aNewStudent);
            }

            listOfStudents = smObject.FetchStudents();

            foreach(Student individualStudent in listOfStudents)
            {
                Console.WriteLine($"ID:{individualStudent.id} and Name:{individualStudent.Name}");
            }

        }
    }
}
