//Sabrina Turney
//C# I
//Module 2 Assignment 3-14: Stadium Seating
//Last edited: August 30, 2019


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class stadiumSeating : Form
    {
        public stadiumSeating()
        {
            InitializeComponent();
        }

        //Here is calculating the actual data used in the program
        //I start by declaring my variables like I did in the tutorials in chapter 3.
        private void CalculateRevenue_Click(object sender, EventArgs e)
        {
            //Seat cost is as follows:
            //Class A: $15
            //Class B: $12
            //Class C: $9

            //Only be looking for numbers (integers)
            //Declare totals for each class, then total for all classes together.
            //Assigning variables to classes as seat costs are defined in the program.
            int totalA;
            int totalB;
            int totalC;
            int totalclassRevenue;

            //Using namespaces of integer variables defined above to calculate classes
            //Using Parse method as defined in the third chapter
            totalA = int.Parse(classABox.Text) * 15;
            totalB = int.Parse(classBBox.Text) * 12;
            totalC = int.Parse(classCBox.Text) * 9;
            totalclassRevenue = totalA + totalB + totalC;
            //Using previous seat cost values of 15, 12, and 9 on values to perform calculations
            //totalRevenue is the easy part- just add the integers together that are calculated together.

            //Like in previous tutorials in chapter 3, we use the "c" conversion to convert
            //the int values we create into currency to display calculations into.
            classARevenue.Text = totalA.ToString("c");
            classBRevenue.Text = totalB.ToString("c");
            classCRevenue.Text = totalC.ToString("c");
            totalRevenue.Text = totalclassRevenue.ToString("c");
            //These values appear automatically in our pre-generated boxes.
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clicking the "clear" button on the form
            //ALL text boxes are just made into empty strings.
            classABox.Text = "";
            classBBox.Text = "";
            classCBox.Text = "";
            classARevenue.Text = "";
            classBRevenue.Text = "";
            classCRevenue.Text = "";
            totalRevenue.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //exits program.
            this.Close();
        }
    }
}
