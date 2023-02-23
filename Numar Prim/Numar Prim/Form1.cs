using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Gray;
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            int number;
            bool isNumber = int.TryParse(numberTextBox.Text, out number);

            if (!isNumber)
            {
                this.BackColor = Color.Yellow;
                MessageBox.Show("Ceea ce ati introdus nu este un numar!");
                numberTextBox.Text = "";
            }
            else
            {
                if (IsPrime(number))
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}