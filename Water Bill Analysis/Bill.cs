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
        //Create constructor
        public Bill(string billingPeriod, double amount)
        {
            BillingPeriod = billingPeriod;
            Amount = amount;
        }

        // Auto Preperties
        public string BillingPeriod { get; set; }
        public double Amount { get; set; }
                         
    }
}

        
    

