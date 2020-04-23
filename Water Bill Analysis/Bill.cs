using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Bill_Analysis
{
    class Bill
    {
        /*Create a new class called Bill.  A bill object will store the name of the 
         * billing period, for example, "First quarter", and the amount of the bill. 
         * Store this data in properties with descriptive names.  */

        //Create constructor
        public Bill(string billingPeriod, double amount )
        {
            BillingPeriod = billingPeriod;
        }

        // Auto Preperties
        public string BillingPeriod { get; set; }   // "First Quarter"
        public double Amount { get; set; }     // for example 40 for $40
        //Create Bill ojbect for four fields
        
        
    }
}

        
    

