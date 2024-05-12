using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMOD12_1302223138
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parameterValue;
            if (!int.TryParse(textBox1.Text, out parameterValue))
            {
                return;
            }

            string result = CariTandaBilangan(parameterValue);

            label1.Text = result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string CariTandaBilangan(int a)
        {
            if (a == 0)
            {
                return "Nol";
            }
            else if (a < 0)
            {
                return "Negatif";
            }
            else if (a > 0)
            {
                return "Positif";
            }
            return " ";
        }
    }
}
