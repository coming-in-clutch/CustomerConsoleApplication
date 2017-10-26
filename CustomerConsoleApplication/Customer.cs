using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsoleApplication
{
    //Customer Class Definition
    class Customer
    {
        //Class Variables Go Here
        private static int versionNumber;

        //Instance Variables Go Here
        private string customerName;
        private string customerAddress;
        private int customerZip;

        //Constructor Method Goes Here
        public Customer()
        {
            Console.WriteLine("Customer Object Created!");
        }
        //Class Methods Go Here
        public static int GetVersionNumber()
        {
            return versionNumber;
        }//end method

        public static void setVersionNumber(int newVersionNumber)
        {
            versionNumber = newVersionNumber;
        }//end method

        //Instance Methods Go Here

        //retrieve the customer name
        public string getCustomerName()
        {
            return customerName;
        }//end of getCustomerName method

        //set the customer name
        public void setCustomerName(string newName)
        {
            customerName = newName;
        }//end of setCustomerName method

        //retrieve the customer address
        public string getCustomerAddress()
        {
            return customerAddress;
        }//end of getCustomerAddress method

        //set the customer address
        public void setCustomerAddress(string newAddress)
        {
            customerAddress = newAddress;
        }//end of setCustomerAddress

        //retrieve the customer zip
        public int getCustomerZip()
        {
            return customerZip;
        }//end of getCustomerZip method

        //set the customer zip
        public void setCustomerZip(int newZip)
        {
            customerZip = newZip;
        }//end of setCustomerZip method


    }//end of Customer Class definition

}//end of namespace definition
