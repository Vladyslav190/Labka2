using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_kyrs_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 2);

            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 2);

            int intC = intP ^ intKey;

            string strC = Convert.ToString(intC, 2);
            textBox_C.Text = strC.PadLeft(strP.Length, '0');

            string hh = "hex: 0x" + Convert.ToString(intC, 16).ToUpper() + "\ndec: " + Convert.ToString(intC, 10);
            toolTip1.SetToolTip(this.textBox_C, hh);

            textBox_C3.Text = textBox_C.Text;
            string strC3 = textBox_C3.Text;
            int intC3 = Convert.ToInt32(strC3, 2);

            textBox_Key3.Text = textBox_Key.Text;
            string strKey3 = textBox_Key.Text;
            int intKey3 = Convert.ToInt32(strKey3, 2);

            int intP3 = intC3 ^ intKey3;
            string strP3 = Convert.ToString(intP3, 2);
            textBox_P3.Text = strP3;
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
        }
    }
}
