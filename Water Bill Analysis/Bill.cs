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
        public Bill(double firstQuarter, double secondQuarter, double thirdQuarter, double fourthQuarter)
        {
            FirstQuarter = firstQuarter;
            SecondQuarter = secondQuarter;
            ThirdQuarter = thirdQuarter;
            FourthQuarter = fourthQuarter;
        }

        // Auto Preperties
        public double FirstQuarter { get; set; }
        public double SecondQuarter { get; set; }
        public double ThirdQuarter { get; set; }
        public double FourthQuarter { get; set; }


    }
}

        
    

