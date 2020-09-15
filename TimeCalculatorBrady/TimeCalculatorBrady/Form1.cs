using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Time Calculator
* Author      : Kabrina Brady
* Created     : 9/16/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : X
*               Input:  X
*               Output: X
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/


namespace TimeCalculatorBrady
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //exits the program
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //sets output equal to 0 to clear TextBoxes
            lblDaysOutput.Text = "0";
            lblHoursOutput.Text = "0";
            lblMinutesOutput.Text = "0";
            lblSecondsOutput.Text = "0";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double SEC_IN_MIN = 60;
            double SEC_IN_HR = 3600;
            double SEC_IN_DAY = 86400;
            double seconds; //variable that will hold TextBox input

            if (double.TryParse(txtInput.Text, out seconds)) //converts string to int if int entered
            {
                if (seconds > 0) //ensures number is greater than 0
                {
                    if (seconds < 60) //displays number of seconds if less than a minute
                    {
                        lblSecondsOutput.Text = txtInput.Text;
                    }
                    else if (seconds >= 60 && seconds < 3600) //displays number of minutes if less than an hour
                    {
                        double minutes = seconds / SEC_IN_MIN; //calculates number of minutes (number of sec/60 sec in min)
                        lblMinutesOutput.Text = minutes.ToString(); //displays number of minutes
                        double leftoverSeconds = seconds % SEC_IN_MIN; //calculates leftover seconds (gets remainder of [number of sec/60 sec in min])
                        lblSecondsOutput.Text = leftoverSeconds.ToString(); //displays leftover seconds
                    }
                    else if (seconds >= 3600 && seconds < 86400) //displays number of hours if less than a day
                    {
                        double hours = seconds / SEC_IN_HR; //calculates number of hours (number of sec/3600 sec in hour)
                        lblHoursOutput.Text = hours.ToString(); //displays number of hours
                        double leftoverMinutes = (seconds % SEC_IN_HR) / 60;
                        lblMinutesOutput.Text = leftoverMinutes.ToString();
                        //I only want the following two lines to execute IF leftoverMinutes above has a remainder.
                        double leftoverSeconds = leftoverMinutes % 60; //calculates leftover seconds (gets remainder of [number of sec/60 sec in min])
                        lblSecondsOutput.Text = leftoverSeconds.ToString(); //displays leftover seconds
                    }
                    else if (seconds >= 86400) 
                    {
                        double days = seconds / SEC_IN_DAY; //displays number of days (number of sec/86400 sec in a day)
                        lblDaysOutput.Text = days.ToString(); //displays number of days
                    }
                }
            }
        }
    }
}
