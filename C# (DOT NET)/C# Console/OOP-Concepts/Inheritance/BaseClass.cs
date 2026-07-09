using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseClass
    {
        public int DataMember;

        public BaseClass()
        {
            Console.WriteLine("Base Class Object Instantiated");
        }
        public void BaseClassMethod()
        {
            Console.WriteLine("I am a Base Class Method");
        }
    }
    public class DerivedClass : BaseClass
    {
        //public int ReturnDM()
        //{ return DataMember; }
        public DerivedClass()
        {
            Console.WriteLine("Derived Class Object Instantiated");
        }
        public int DataMemberS { set; get; }
        public void DerivedClassMethod()
        {
            Console.WriteLine("I am a Derived Class Method");
        }
    }


    #region Access Interface
    /* **************************************************
    *          Multiple Inheritance.... ****************
    * **************************************************/
    public interface IChannel
    {
        //Can't Define Methods
        void Next();
        void Previous();
    }
    public interface IBook
    {
        void Next();
        void Chapter();
    }

    //Syntax
    //Class <Class Name> : Interface Comma List
    class AccesInterface : IChannel, IBook
    {
        //Defining the methods in class
        void IChannel.Next()
        {
            Console.WriteLine("Channel Next");
        }
        void IBook.Next()
        {
            Console.WriteLine("Book Next");
        }
        public void Previous()
        {
            Console.WriteLine("Previous");
        }
        public void Chapter()
        {
            Console.WriteLine("Chapter");
        }
    }


    #endregion

    #region Inheriting Interface

    interface BaseInterface
    {
       
        void GetPersonalDetail();
        void GetContactDetail();
    }

    interface DerivedInterface : BaseInterface
    {
        void ShowDetail();
    }

    class InterfaceImplementer : DerivedInterface
    {
        string Name;
        int Age;
        string Address;
        long PhoneNumber;
        public void GetPersonalDetail()
        {
            Console.Write("Enter Your Name:");
            Name = Console.ReadLine();
            Console.Write("Enter Your Age:");
            Age = int.Parse(Console.ReadLine());

        }
        public void GetContactDetail()
        {

            Console.Write("Enter Your Address:");
            Address = Console.ReadLine();
            Console.Write("Enter Your Phone Number:");
            PhoneNumber = long.Parse(Console.ReadLine());
        }
        public void ShowDetail()
        {

            Random obj = new Random();
            int ID = obj.Next(11,99);

            //UUID
            Guid a = Guid.NewGuid();


            Console.WriteLine("");
            Console.WriteLine("Your Details are:");
            Console.WriteLine("Your New ID: " + ID);
            Console.WriteLine("Guid ID:" + a.ToString());
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address : " + Address);
            Console.WriteLine("Phone Number: " + PhoneNumber);
        }
    }

    #endregion
}
