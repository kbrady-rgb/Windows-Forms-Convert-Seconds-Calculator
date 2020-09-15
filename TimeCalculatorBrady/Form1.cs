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
* Copyright   : This is my own original work, based on math provided by this tutorial: https://www.geeksforgeeks.org/converting-seconds-into-days-hours-minutes-and-seconds/
* Description : Program takes number of seconds provided by user and divides them up into days, hours, minutes, and seconds
*               Input:  Number of seconds, mouse/keyboard clicks
*               Output: Number of days, hours, minutes, seconds
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
            int seconds; //variable that will hold TextBox input

            if (int.TryParse(txtInput.Text, out seconds)) //converts string to int if int entered
            {
                if (seconds > 0) //ensures number is greater than 0
                {
                    int day = seconds / (24 * 3600); //calculates number of days
                    lblDaysOutput.Text = day.ToString(); //displays result

                    seconds = seconds % (24 * 3600); //calculates leftover seconds
                    int hour = seconds / 3600; //calculates number of hours
                    lblHoursOutput.Text = hour.ToString(); //displays result

                    seconds %= 3600; //calculates leftover seconds
                    int minutes = seconds / 60; //calculates number of minutes
                    lblMinutesOutput.Text = minutes.ToString(); //displays result

                    seconds %= 60; //calculates leftover seconds
                    int seconds2 = seconds; //prints number of seconds
                    lblSecondsOutput.Text = seconds2.ToString(); //displays result
                }
            else if (!(seconds >= 0)) //checks if number is less than 0
                {
                    MessageBox.Show("Please enter a valid number."); //tells user to enter valid number if number is negative
                }
            }
        }
    }
}
