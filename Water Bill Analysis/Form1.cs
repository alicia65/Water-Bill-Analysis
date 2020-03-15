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
        double[] quarterLists = new double[4];// Create new arrary to store data
        double firstQuarter = 0;
        double secondQuarter = 0;
        double thirdQuarter = 0;
        double fourthQuarter = 0;
        double billTotal = 0;
        double billAverage = 0;
        public Form1()
        {
            InitializeComponent();
            getTotals(billTotal);
            getAverage(billAverage);

        }        

                                  
        private void lblThirdQuarter_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            txtFirstQuarter.Clear();
            txtSecondQuarter.Clear();
            txtThirdQuarter.Clear();
            txtFourthQuarter.Clear();

            
            

            firstQuarter = double.Parse(txtFirstQuarter.Text);
            secondQuarter = double.Parse(txtSecondQuarter);
            thirdQuarter = double.Parse(txtThirdQuarter.Text);
            fourthQuarter = double.Parse(txtFourthQuarter.Text);

            for(double i = 0; i < 4; i++) 
            {
                quarterLists[i] = i + 1;
                txtTotal.Text = double.Parse(quarterLists[i]);
            }
           
            


        }

        

        public void getTotals(double bill) 
        {
            if (billTotal == bill)
            {
                billTotal = quarterLists[i]; 
            }

        }

        public void getAverage(double average)
        {
            if(billAverage == average) 
            {
                txtAverage.Text = double.Parse(quarterLists / 4);
            }
        }    
        
    }
}
