using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Water_Bill_Analysis
{
    class WaterBillAnalysis
    {
        public WaterBillAnalysis(double average, double total)
        {
          
        }
      
        //Properties
        public string average { get; set; }
        public string total { get; set; }

        public List<Bill> AllBills { get; set; }

        public double getAverage()
        {
            double sum = 0;
            for (int i = 0; i < AllBills.Count; i++) 
            {
               sum += quarterLists[i];
                // add on each Bill's amount to the sum
            }

            double average = sum / AllBills.Count; // calculate average by dividing sum with arrary list

            //txtAverage.Text = "$" + average; // Display average  bill on text box 

            return average;

        }

        public void getTotals(double[] bill)
        {
            double total = 0;
            for (int i = 0; i <quarterLists.Length; i++)
                total += quarterLists[i];//add 4 bills in the array 
            txtTotal.Text = "$" + total; //display total on text box total
        }

    }
}
