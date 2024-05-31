using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cast_Operator
{
    public partial class castOperator1 : Form
    {
        public castOperator1()
        {
            InitializeComponent();
        }

        private void outputLabelWholeNUmber_Click(object sender, EventArgs e)
        {

        }

        private void wholeNumber1_Click(object sender, EventArgs e)
        {

        }

        private void realNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            int wholeNumber;
            double realNumber = 3.0;
            wholeNumber = (int)realNumber;
        }

        private void wholeNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            int wholeNumber;
            double realNumber = 3.0;
            wholeNumber = (int)realNumber;
        }

        private void caluclateButton_Click(object sender, EventArgs e)
        {
            int wholeNumber;
            double realNumber = 3.0;
            realNumber = double.Parse(realNumberTextBox.Text);
            wholeNumber = (int)realNumber;
            outputLabelWholeNumber.Text = wholeNumber.ToString();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            realNumberTextBox.Text = "";
        }

    }
}
