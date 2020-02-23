using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Programming_Challenge
{
    public partial class stringSearching : Form
    {
        public stringSearching()
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
            MatchCollection matches = Regex.Matches(targetString.Text.ToLower(), searchString.Text.ToLower());
            int count = matches.Count;
            outputLbl.Text = "The search string has showed up " + count.ToString() + " times";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            targetString.Clear();
            searchString.Clear();
            outputLbl.Text = "";
        }
    }
}
