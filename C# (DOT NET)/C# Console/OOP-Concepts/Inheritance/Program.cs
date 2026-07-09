namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Inheritance Basics
            //////Create a Base Class Object
            //Console.WriteLine("I am going to access a Base Class Object:");
            //BaseClass bc = new BaseClass(); //Instantiate 
            //bc.DataMember = 1;
            //Console.WriteLine("Value at bc = " + bc.DataMember);
            //bc.BaseClassMethod();

            //BaseClass baseClass = new BaseClass();  
            //DerivedClass dc = new DerivedClass();
            //dc.DataMember = 2;
            //dc.DataMemberS = 5;
            //dc.BaseClassMethod();
            //dc.DerivedClassMethod();

            //Console.WriteLine($"Value At DataMember: {dc.DataMember} and DataMembers: {dc.DataMemberS}");

            //////Overwriting
            //dc.DataMember = 4;

            ////Reinstantiation
            //bc = new BaseClass();
            //Console.WriteLine("Value at bc = " + bc.DataMember); 
            #endregion

            #region Multiple Inheritance
            //AccesInterface app = new AccesInterface();
            //((IBook)app).Next();

            //app.Previous();
            //app.Chapter();

            //((IChannel)app).Next();

            #endregion

            #region Inheriting Interface
            //InterfaceImplementer MyObj = new InterfaceImplementer();
            //MyObj.GetPersonalDetail();
            //MyObj.GetContactDetail();
            //MyObj.ShowDetail();

            #endregion

            Console.WriteLine("PRESS ANY KEY TO TERMINATE!");
            Console.ReadKey();
        }
    }

}
