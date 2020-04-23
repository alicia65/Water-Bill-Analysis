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
        double firstQuarter = 0.0;
        double secondQuarter = 0.0;
        double thirdQuarter = 0.0;
        double fourthQuarter = 0.0;
        double billTotal = 0.0;
        double billAverage = 0.0;

        WaterBillAnalysis wBillAnalysis = new WaterBillAnalysis();

        public Form1()
        {
            InitializeComponent();

            
        }


        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
           

            // Create bill object for four text fields
            List<Bill> billOjb = new List<Bill>();

                       
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
            //quarterLists[0] = firstQuarter;
            //quarterLists[1] = secondQuarter;
            //quarterLists[2] = thirdQuarter;
            //quarterLists[3] = fourthQuarter;

            // Make Bill objects, one for each quarter 
            Bill q1 = new Bill("First Quarter", firstQuarter);
            // etc. 

            wBillAnalysis.AllBills.Add(q1);
            // etc. 


           // wBillAnalysis.getTotals();//call method to compute the total
            double average = wBillAnalysis.getAverage();// call method to get average
            txtAverage.Text = average.ToString();
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
                   
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
