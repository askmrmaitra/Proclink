using LINQToObject.LINQToObjectDemo;

namespace LINQToObject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //WhereExample();

            //OrderByExample();

            //SelectExample();

            //GroupByExample();

            //AggregateExample();

            //ElementOperatorsExample();

            //QueueLINQExample();

            //StackLINQExample();

            //EmployeeQuerySyntaxExample();

            //QueueQuerySyntaxExample();


            Console.WriteLine("Press Enter to Terminate");
            Console.ReadKey();
        }
        public static void QueueLINQExample()
        {
            Console.WriteLine("QUEUE WITH LINQ");
            Console.WriteLine("----------------------------");

            Queue<int> numbers = new Queue<int>();

            // Insert 50 Elements
            for (int i = 1; i <= 50; i++)
            {
                numbers.Enqueue(i);
            }

            // LINQ Query
            var result = numbers
                            .Where(n => n % 2 == 0)
                            .OrderByDescending(n => n);

            Console.WriteLine("Even Numbers (Descending)");

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public static void StackLINQExample()
        {
            Console.WriteLine("STACK WITH LINQ");
            Console.WriteLine("----------------------------");

            Stack<int> numbers = new Stack<int>();

            // Insert 50 Elements
            for (int i = 1; i <= 50; i++)
            {
                numbers.Push(i);
            }

            // LINQ Query
            var result = numbers
                            .Where(n => n > 25)
                            .OrderBy(n => n);

            Console.WriteLine("Numbers Greater Than 25");

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
        public static void WhereExample()
        {
            Console.WriteLine("WHERE EXAMPLE");
            Console.WriteLine("-------------------------");

            var employees = EmployeeRepository.GetEmployees();

            var result = employees.Where(e => e.Department == "IT");

            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.Name} {emp.Department} {emp.Salary}");
                //Console.WriteLine($"{emp.Name,-10} {emp.Department,-10} {emp.Salary}");
            }

            Console.WriteLine();
        }
        public static void OrderByExample()
        {
            Console.WriteLine("ORDER BY EXAMPLE");
            Console.WriteLine("-------------------------");

            var employees = EmployeeRepository.GetEmployees();

            var result = employees
                            .OrderByDescending(e => e.Salary);
            
            //var result = employees
            //                .OrderBy(e => e.Salary);

            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.Name,-10} {emp.Salary}");
            }

            Console.WriteLine();
        }

        public static void SelectExample()
        {
            Console.WriteLine("SELECT EXAMPLE");
            Console.WriteLine("-------------------------");

            var employees = EmployeeRepository.GetEmployees();

            var result = employees
                            .Select(e => new
                            {
                                e.Name,
                                e.Designation,
                                e.Salary
                            });

            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.Name,-10} {emp.Designation,-20} {emp.Salary}");
            }

            Console.WriteLine();
        }

        public static void GroupByExample()
        {
            Console.WriteLine("GROUP BY EXAMPLE");
            Console.WriteLine("-------------------------");

            var employees = EmployeeRepository.GetEmployees();

            var result = employees.GroupBy(e => e.Department);

            foreach (var group in result)
            {
                Console.WriteLine($"\nDepartment : {group.Key}");

                foreach (var emp in group)
                {
                    Console.WriteLine($"{emp.Name,-10} {emp.Designation}");
                }
            }

            Console.WriteLine();
        }

        public static void AggregateExample()
        {
            Console.WriteLine("AGGREGATE FUNCTIONS");
            Console.WriteLine("-------------------------");

            var employees = EmployeeRepository.GetEmployees();

            Console.WriteLine($"Total Employees : {employees.Count()}");
            Console.WriteLine($"Maximum Salary  : {employees.Max(e => e.Salary)}");
            Console.WriteLine($"Minimum Salary  : {employees.Min(e => e.Salary)}");
            Console.WriteLine($"Average Salary  : {employees.Average(e => e.Salary)}");
            Console.WriteLine($"Total Salary    : {employees.Sum(e => e.Salary)}");

            Console.WriteLine();
        }

        public static void ElementOperatorsExample()
        {
            Console.WriteLine("ELEMENT OPERATORS");
            Console.WriteLine("-------------------------");

            var employees = EmployeeRepository.GetEmployees();

            var firstEmployee = employees.First();

            var lastEmployee = employees.Last();

            var employee = employees.Single(e => e.EmployeeId == 105);

            Console.WriteLine($"First Employee : {firstEmployee.Name}");
            Console.WriteLine($"Last Employee  : {lastEmployee.Name}");
            Console.WriteLine($"Single Employee: {employee.Name}");

            Console.WriteLine();
        }

        public static void EmployeeQuerySyntaxExample()
        {
            Console.WriteLine("EMPLOYEE - QUERY SYNTAX");
            Console.WriteLine("------------------------------");

            var employees = EmployeeRepository.GetEmployees();

            var result =
                from emp in employees
                where emp.Department == "IT"
                orderby emp.Salary descending
                select emp;

            foreach (var emp in result)
            {
                Console.WriteLine($"{emp.EmployeeId}  {emp.Name,-10} {emp.Department,-10} {emp.Salary}");
            }

            Console.WriteLine();
        }

        public static void QueueQuerySyntaxExample()
        {
            Console.WriteLine("QUEUE - QUERY SYNTAX");
            Console.WriteLine("------------------------------");

            Queue<int> numbers = new Queue<int>();

            for (int i = 1; i <= 50; i++)
            {
                numbers.Enqueue(i);
            }

            var result =
                from number in numbers
                where number % 5 == 0
                orderby number descending
                select number;

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
