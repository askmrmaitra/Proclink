using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassAndObjects
{
    public class Employee
    {
        #region Properties in C# - .Net 1.0 
        //private int _id;

        //public int ID
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}
        #endregion

        #region Auto Implemented Property
        public int EID { get; set; }
        #endregion
        public int Save(int EID, string Name, string Phone, string LaptopSerialNo)
        {
            return 0;
        }
    }
}