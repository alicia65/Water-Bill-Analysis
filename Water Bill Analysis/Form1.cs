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
            
            double[] quarters = new double[4];
            foreach(double i in quarters) 
            
            {
                lblFirstQuarter(Convert.ToDouble(i));//change data type from text to integer using convert method
                MessageBox.Show(txtFirstQuarter);

                lblSecondQuarter(Convert.ToDouble(i));
                MessageBox.Show(txtSecondQuarter);
                
                lblThirdQuarter(Convert.ToDouble(i));
                MessageBox.Show(txtThirdQuarter);
                
                lblFourthQuarter(Convert.ToDouble(i));
                MessageBox.Show(txtFourthQuarter);
                                       
                   
            }

            getBillAverage();//Call method to get average
            getBillTotals();// Call method to get totals

        }

        public void getBillTotals(double t) 
        {
            double[] quarters = new double[4];
            t = 0;
            for (double k = 0; k< quarters.Length; k++)
                t += quarters[k];
            txtTotal.Text = t;
        }

        public void getBillAverage(double average) 
        {
            double[] quarters = new double[4];
            average = 0;
            if (average > 0)
            {
                average = quarters[0] + quarters[1] + quarters[2] + quarters[3] / quarters.Length;
                txtAverage.Text = TryParse.ToDouble(average);
            }
            else 
            {
                MessageBox.Show("Try again", "error");
            }
        }
        
    }
}
