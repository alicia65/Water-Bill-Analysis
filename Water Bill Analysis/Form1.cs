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
        //initialize global variables and assign zero values to them
        double firstQuarter = 0;
        double secondQuarter = 0;
        double thirdQuarter = 0;
        double fourthQuarter = 0;
        double billTotal = 0;
        double billAverage = 0;
        public Form1()
        {
            InitializeComponent();
            //getTotals(billTotal);
            //getAverage(billAverage);

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            //Read the numbers from the four TextBoxes
            try
            {
                firstQuarter = double.Parse(txtFirstQuarter.Text);
                secondQuarter = double.Parse(txtSecondQuarter.Text);
                thirdQuarter = double.Parse(txtThirdQuarter.Text);
                fourthQuarter = double.Parse(txtFourthQuarter.Text);

                txtFirstQuarter.Focus();//starting point is textbox first quarter. 
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid numberic format. Please check all entries.", "Entry Error");
            }

            // add 4 bills into the array called quarterList and place them in index orders
            quarterLists[0] = firstQuarter;
            quarterLists[1] = secondQuarter;
            quarterLists[2] = thirdQuarter;
            quarterLists[3] = fourthQuarter;

            getTotals(quarterLists);//call method to compute the total
            getAverage(billAverage);// call method to get average
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            //checks for a required field
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public void getTotals(double[] bill)
        {
            double total = 0;
            for (int i = 0; i < quarterLists.Length; i++)
                total += quarterLists[i];//add 4 bills in the array 
            txtTotal.Text = double.Parse(bill);//display total on text box total
        }          
       
        public void getAverage(double average)
        {
            if(billAverage == average) 
            {
                txtAverage.Text = double.Parse(total/quarterLists.Length);// Display average  bill on text box 
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
