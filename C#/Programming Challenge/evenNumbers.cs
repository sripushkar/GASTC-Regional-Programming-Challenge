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
    public partial class evenNumbers : Form
    {
        public evenNumbers()
        {
            InitializeComponent();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu mainForm = new mainMenu();
            mainForm.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool validateInput = Int32.TryParse(numberInput.Text, out int validInput);

            if(validateInput == true)
            {
                int i = 0;
                List<int> numbers = new List<int>();
                while (i<= validInput)
                {
                    numbers.Add(i);
                    i += 2;
                }
                
                string text = string.Join(" ", numbers.ToArray());

                evenNumbersLbl.Text = text;
            }

            else
            {
                MessageBox.Show("Please enter a valid number");
            }
            numberInput.Clear();
        }
    }
}
