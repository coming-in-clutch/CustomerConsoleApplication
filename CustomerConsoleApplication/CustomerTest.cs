using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Customer console application
namespace CustomerConsoleApplication
{
    class CustomerTest
    {
        //main method
        static void Main(string[] args)
        {
            //Create a Customer Object
            Customer myCustObj = new Customer();

            //set Customer version number
            Customer.setVersionNumber(1); //set versionNo to 1

            //display the Customer version number
            Console.WriteLine(); //display a blank line
            Console.WriteLine("Customer Version Number: " + Customer.GetVersionNumber());

            //set the customer instance variables
            myCustObj.setCustomerName("Rick Birney");
            myCustObj.setCustomerAddress("12 West Street");
            myCustObj.setCustomerZip(12345);

            //display the entered customer information
            Console.WriteLine("Customer Name: " + myCustObj.getCustomerName());
            Console.WriteLine("Customer Address: " + myCustObj.getCustomerAddress());
            Console.WriteLine("Customer Zip: " + myCustObj.getCustomerZip());
            
            //Pause DOS Display Window
            Console.WriteLine();
            Console.WriteLine("Press any key to Exit.");
            Console.ReadLine();

        }//end main method

    } //end CustomerTest class definition
} //end namespace
