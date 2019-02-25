using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class CustomerRecord
    {
        #region Variables
        private string lastName;
        private string firstName;
        private double customerNumber;
               

        public string LastName
        {
            get { return lastName; }
        }

        public string FistName
        {
            get { return firstName; }
        }
        public double CustomerNumber
        {
            get { return customerNumber; }
        }

        #endregion


        #region Constructor
        public CustomerRecord (string last, string first, double num)
        {
            lastName = last;
            firstName = first;
            customerNumber = num;
        }
        #endregion

        #region methods

        public new string ToString()
        {
            return ($"{LastName}, {FistName}: {CustomerNumber}");
        }
        #endregion
    }
}
