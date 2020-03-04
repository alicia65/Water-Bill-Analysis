using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Bill_Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*int[] amountOfBills = new int[4]; // Create an array called amountOfBills

            for (int i = 0; i < amountOfBills.Length; i++)
                amountOfBills[i] = i;
            int sum = sum + amountOfBills;
            int average = sum / 4;
           
            /* int billssum = 0;
             * for (int i = 0; i < totals.Length; i++)
             * sum += totals[i];
             * int average = billssum/totals.Length;
            ----------
            */
            int totals = 0;
            int sum = 0;
            string billTotals = "";
            for (int i = 0; i < totals.Length; i++)
              billTotals += totals[i]  + "/n";
            MessageBox.Show("The totals are:/n" +
                billTotals + "/n" +
                "Sum: " + sum + "/n" +
                "Average: " average, "Totals Bill");

             
        }

        private void lblThirdQuarter_Click(object sender, EventArgs e)
        {

        }
    }
}
