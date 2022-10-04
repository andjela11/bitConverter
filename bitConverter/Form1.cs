using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            decimal br = numConvert.Value;
            decimal res = 0M; 

            if (radioBtnOkt.Checked)
                txtConvert.Text = ConvertOct(br).ToString();
            else if (radioBtnHex.Checked)
            {
                txtConvert.Text = ConvertHex(br);
            }
            else if (radioBtnBin.Checked)
                txtConvert.Text = ConvertBin(br).ToString();
            else
                label1.Text = "Izaberi osnovu";
            
           
        }

        private decimal ConvertBin(decimal num)
        {
            decimal res = 0, ost, r = 1;
            int osn = 2;

            int br = Decimal.ToInt32(num);

            do
            {
                ost = br % osn; //ost = 1
                br /= osn; //num = 0
                res += r * ost;
                r *= 10;

            }
            while (br != 0);

            return res;
        }

        private decimal ConvertOct(decimal num) //10 i 8
        {
            decimal res = 0, ost, r = 1, osn = 8;

            if (num >= 0 || num <= 7)
                return num;
            else
            {

                do
                {
                    ost = num % osn; //ost = 2 
                    num /= osn; //num = 1
                    res += r * ost;
                    r *= 10;

                }
                while (num != 0);

            }
            return res;
        }

        private string ConvertHex(decimal num) 
        {
            int br = Decimal.ToInt32(num);
            
            string hex = br.ToString("X");
            

            return hex;


        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = numCalc1.Value.ToString();
            label4.Text = numCalc2.Value.ToString();
            int br1 = Decimal.ToInt32(numCalc1.Value), br2 = Decimal.ToInt32(numCalc2.Value);

            txtCalcFirst.Text = ConvertBin(numCalc1.Value).ToString();
            txtCalcSecond.Text = ConvertBin(numCalc2.Value).ToString();

            int r = 0;
            if (radioBtnAND.Checked)
                r = Calc(br1, br2, '&');
            else if (radioBtnOR.Checked)
                r = Calc(br1, br2, '|');
            else if (radioBtnXOR.Checked)
                r = Calc(br1, br2, '^');
            else
                label2.Text = "Izaberi operaciju";

            label5.Text = r.ToString();
            txtResult.Text = ConvertBin(r).ToString();

        }

        private int Calc(int br1, int br2, char op)
        { 
            switch(op)
            {
                case '&':
                    return br1 & br2;
                    break;

                case '|':
                    return br1 | br2;
                    break;

                case '^':
                    return br1 ^ br2;
                    break;

                default: return -1;
            }
        }
    }
}
