using System;
using System.Data;

namespace CMC_Three_Layer_Arch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. View Customers");
                Console.WriteLine("3. Update Customer");
                Console.WriteLine("4. Delete Customer");
                Console.WriteLine("5. Add Address");
                Console.WriteLine("6. View Addresses");
                Console.WriteLine("7. Update Address");
                Console.WriteLine("8. Delete Address");
                Console.WriteLine("9. View Customer With Address");
                Console.WriteLine("10. View Address By Customer");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddCustomer(); break;
                    case 2: DisplayCustomers(); break;
                    case 3: UpdateCustomer(); break;
                    case 4: DeleteCustomer(); break;
                    case 5: AddAddress(); break;
                    case 6: DisplayAddresses(); break;
                    case 7: UpdateAddress(); break;
                    case 8: DeleteAddress(); break;
                    case 9: DisplayCustomerAddress(); break;
                    case 10: DisplayAddressByCustomer(); break;
                    case 0: break;
                    default: Console.WriteLine("Invalid Choice."); break;
                }

            } while (choice != 0);
        }

        static void AddCustomer()
        {
            Customer customer = new Customer();

            Console.Write("Name: ");
            customer.CustomerName = Console.ReadLine();

            Console.Write("Email: ");
            customer.Email = Console.ReadLine();

            Console.Write("Phone: ");
            customer.PhoneNumber = Console.ReadLine();

            int status = customer.SaveCustomer();

            Console.WriteLine(status == 1 ? "Added Successfully." : "Failed To Add.");
        }
        static void DisplayCustomers()
        {
            Customer customer = new Customer();

            DataTable dt = customer.FetchCustomers();

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"ID: {dr["CustomerID"]} | Name: {dr["CustomerName"]} | Email: {dr["Email"]} | Phone: {dr["PhoneNumber"]}");
            }
        }
        static void UpdateCustomer()
        {
            Customer customer = new Customer();

            Console.Write("Customer ID: ");
            customer.CustomerID = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            customer.CustomerName = Console.ReadLine();

            Console.Write("Email: ");
            customer.Email = Console.ReadLine();

            Console.Write("Phone: ");
            customer.PhoneNumber = Console.ReadLine();

            int status = customer.UpdateCustomer();

            Console.WriteLine(status == 1 ? "Updated Successfully." : "Failed To Update.");
        }
        static void DeleteCustomer()
        {
            Customer customer = new Customer();

            Console.Write("Customer ID: ");
            customer.CustomerID = int.Parse(Console.ReadLine());

            int status = customer.DeleteCustomer();

            Console.WriteLine(status == 1 ? "Deleted Successfully." : "Failed To Delete.");
        }
        static void AddAddress()
        {
            CustomerAddress address = new CustomerAddress();

            Console.Write("Customer ID: ");
            address.CustomerID = int.Parse(Console.ReadLine());

            Console.Write("Address: ");
            address.AddressLine = Console.ReadLine();

            Console.Write("City: ");
            address.City = Console.ReadLine();

            Console.Write("State: ");
            address.State = Console.ReadLine();

            Console.Write("Pincode: ");
            address.Pincode = Console.ReadLine();

            int status = address.SaveAddress();

            Console.WriteLine(status == 1 ? "Added Successfully." : "Failed To Add.");
        }
        static void DisplayAddresses()
        {
            CustomerAddress address = new CustomerAddress();

            DataTable dt = address.FetchAddresses();

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"Addr ID: {dr["AddressID"]} | Cust ID: {dr["CustomerID"]} | {dr["AddressLine"]}, {dr["City"]}, {dr["State"]} {dr["Pincode"]}");
            }
        }
        static void UpdateAddress()
        {
            CustomerAddress address = new CustomerAddress();

            Console.Write("Address ID: ");
            address.AddressID = int.Parse(Console.ReadLine());

            Console.Write("Customer ID: ");
            address.CustomerID = int.Parse(Console.ReadLine());

            Console.Write("Address: ");
            address.AddressLine = Console.ReadLine();

            Console.Write("City: ");
            address.City = Console.ReadLine();

            Console.Write("State: ");
            address.State = Console.ReadLine();

            Console.Write("Pincode: ");
            address.Pincode = Console.ReadLine();

            int status = address.UpdateAddress();

            Console.WriteLine(status == 1 ? "Updated Successfully." : "Failed To Update.");
        }
        static void DeleteAddress()
        {
            CustomerAddress address = new CustomerAddress();

            Console.Write("Address ID: ");
            address.AddressID = int.Parse(Console.ReadLine());

            int status = address.DeleteAddress();

            Console.WriteLine(status == 1 ? "Deleted Successfully." : "Failed To Delete.");
        }
        static void DisplayCustomerAddress()
        {
            CustomerAddress address = new CustomerAddress();

            DataTable dt = address.FetchCustomerAddressDetails();

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"Cust ID: {dr["CustomerID"]} | Name: {dr["CustomerName"]} | Addr ID: {dr["AddressID"]} | {dr["AddressLine"]}, {dr["City"]}");
            }
        }
        static void DisplayAddressByCustomer()
        {
            CustomerAddress address = new CustomerAddress();

            Console.Write("Customer ID: ");
            int id = int.Parse(Console.ReadLine());

            DataTable dt = address.FetchAddressByCustomer(id);

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"Addr ID: {dr["AddressID"]} | {dr["AddressLine"]}, {dr["City"]}, {dr["State"]} {dr["Pincode"]}");
            }
        }
    }
}