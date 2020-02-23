using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Challenge
{
    public partial class telephoneConverter : Form
    {
        public telephoneConverter()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string formattedPhoneNumber = input.Text.ToUpper();

            formattedPhoneNumber = formattedPhoneNumber.Replace("A", "2");
            formattedPhoneNumber = formattedPhoneNumber.Replace("B", "2");
            formattedPhoneNumber = formattedPhoneNumber.Replace("C", "2");
            formattedPhoneNumber = formattedPhoneNumber.Replace("D", "3");
            formattedPhoneNumber = formattedPhoneNumber.Replace("E", "3");
            formattedPhoneNumber = formattedPhoneNumber.Replace("F", "3");
            formattedPhoneNumber = formattedPhoneNumber.Replace("G", "4");
            formattedPhoneNumber = formattedPhoneNumber.Replace("H", "4");
            formattedPhoneNumber = formattedPhoneNumber.Replace("I", "4");
            formattedPhoneNumber = formattedPhoneNumber.Replace("J", "5");
            formattedPhoneNumber = formattedPhoneNumber.Replace("K", "5");
            formattedPhoneNumber = formattedPhoneNumber.Replace("L", "5");
            formattedPhoneNumber = formattedPhoneNumber.Replace("M", "6");
            formattedPhoneNumber = formattedPhoneNumber.Replace("N", "6");
            formattedPhoneNumber = formattedPhoneNumber.Replace("O", "6");
            formattedPhoneNumber = formattedPhoneNumber.Replace("P", "7");
            formattedPhoneNumber = formattedPhoneNumber.Replace("Q", "7");
            formattedPhoneNumber = formattedPhoneNumber.Replace("R", "7");
            formattedPhoneNumber = formattedPhoneNumber.Replace("S", "7");
            formattedPhoneNumber = formattedPhoneNumber.Replace("T", "8");
            formattedPhoneNumber = formattedPhoneNumber.Replace("U", "8");
            formattedPhoneNumber = formattedPhoneNumber.Replace("V", "8");
            formattedPhoneNumber = formattedPhoneNumber.Replace("W", "9");
            formattedPhoneNumber = formattedPhoneNumber.Replace("X", "9");
            formattedPhoneNumber = formattedPhoneNumber.Replace("Y", "9");
            formattedPhoneNumber = formattedPhoneNumber.Replace("Z", "9");

            outputLbl.Text = "Your converted phone number is: " + formattedPhoneNumber;

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            outputLbl.Text = "";
            input.Clear();
        }
    }
}
