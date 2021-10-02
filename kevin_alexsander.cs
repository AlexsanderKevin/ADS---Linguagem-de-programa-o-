using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {

        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textNum1.Text);
            int num2 = Convert.ToInt32(textNum2.Text);

            textResult.Text = Convert.ToString(num1 + num2);
        }

        private void radioSub_CheckedChanged(object sender, EventArgs e)
        {
            float num1 = Convert.ToInt32(textNum1.Text);
            int num2 = Convert.ToInt32(textNum2.Text);

            textResult.Text = Convert.ToString(num1 - num2);
        }

        private void radioMulti_CheckedChanged(object sender, EventArgs e)
        {
            float num1 = Convert.ToInt32(textNum1.Text);
            int num2 = Convert.ToInt32(textNum2.Text);

            textResult.Text = Convert.ToString(num1 * num2);
        }

        private void radioDiv_CheckedChanged(object sender, EventArgs e)
        {
            float num1 = Convert.ToInt32(textNum1.Text);
            int num2 = Convert.ToInt32(textNum2.Text);

            textResult.Text = Convert.ToString(num1 / num2);
        }
    }
}
