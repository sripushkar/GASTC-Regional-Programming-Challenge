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
    public partial class orderNumbers : Form
    {
        public orderNumbers()
        {
            InitializeComponent();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu mainForm = new mainMenu();
            mainForm.Show();
        }


        List<int> numbers = new List<int>();
        private void submitBtn_Click(object sender, EventArgs e)
        {
            
            bool validateInput = Int32.TryParse(numberInput.Text, out int validInput);

            if (validateInput == true && validInput != 0)
            {
                numbers.Add(validInput);
                numbers.Sort();
            }
            else if (validateInput == true && validInput == 0)
            {
                numbers.Clear();
            }

            else
            {
                MessageBox.Show("Please enter a valid number");
            }

            string text = string.Join(" ", numbers.ToArray());

            orderNumbersLbl.Text = text;
            numberInput.Clear();
        }

        private void orderNumbers_Load(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            string text = string.Join(" ", numbers.ToArray());

            orderNumbersLbl.Text = text;
        }
    }
}
