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
            int[] amountOfBills = new int[4]; // Create an array called amountOfBills
              
            for (int i = 0; i < amountOfBills.Length; i++)
                amountOfBills[i] = i;
            int[] total = total + amountOfBills;
            int[] average = total / 4;

        }

             
        

        private void lblThirdQuarter_Click(object sender, EventArgs e)
        {

        }

        
    }
}
