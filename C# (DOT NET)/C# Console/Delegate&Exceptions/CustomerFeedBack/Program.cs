using Exp;
using Feedback;
using FeedbackM;
using FileHandling;
using System;

namespace ThirdQues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeedbackManager manager = new FeedbackManager();
            FeedbackFile file = new FeedbackFile();

            try
            {
                file.CreateFile();

                Console.Write("Enter Number of Customers : ");
                int n = int.Parse(Console.ReadLine());

                CustomerFeedback[] customers = new CustomerFeedback[n];

                for (int i = 0; i < n; i++)
                {
                    CustomerFeedback customer = new CustomerFeedback();

                    Console.WriteLine("\nEnter Customer Details");

                    Console.Write("Customer Name : ");
                    customer.CustomerName = Console.ReadLine();

                    Console.Write("Rating (0-5) : ");
                    customer.Rating = int.Parse(Console.ReadLine());

                    customers[i] = customer;
                }

                foreach (CustomerFeedback customer in customers)
                {
                    try
                    {
                        if (customer.Rating < 0 || customer.Rating > 5)
                        {
                            throw new InvalidRatingException("Rating should be between 0 and 5.");
                        }

                        if (manager.IsPositive(customer))
                        {
                            Console.WriteLine("Customer Name : " + customer.CustomerName);
                            Console.WriteLine("Rating : " + customer.Rating);

                            string data = "Customer Name : " + customer.CustomerName + "\n" +
                                          "Rating : " + customer.Rating + "\n";

                            file.Save(data);
                        }
                    }
                    catch (InvalidRatingException ex)
                    {
                        Console.WriteLine("Customer Name : " + customer.CustomerName);
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("\nPositive feedback saved successfully.");
            }
            catch (FileOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}