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
                  
        private void lblThirdQuarter_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            string[] quarters = {"first quarter", "second quarter", "third quarter", "fourth quarter" };
            foreach(string i in quarters) 
            
            {
                lblFirstQuarter(Convert.ToInt32(i));//change data type from text to integer using convert method
                lblSecondQuarter(Convert.ToInt32(i));
                lblThirdQuarter(Convert.ToInt32(i));
                lblFourthQuarter(Convert.ToInt32(i));
            }

        }
    }
}
