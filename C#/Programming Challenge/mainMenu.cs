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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void evenNumbersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            evenNumbers evenForm = new evenNumbers();
            evenForm.Show();
        }

        private void orderNumbersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderNumbers orderForm = new orderNumbers();
            orderForm.Show();
        }

        private void stringSearchingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            stringSearching stringSearchForm = new stringSearching();
            stringSearchForm.Show();
        }

        private void telephoneConverterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            telephoneConverter teleConvForm = new telephoneConverter();
            teleConvForm.Show();
        }
    }
}
