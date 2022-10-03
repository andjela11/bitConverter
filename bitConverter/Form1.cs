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
            decimal br = numConvert.Value;
            decimal res = 0M; string r;

            if (radioBtnOkt.Checked)
                res = ConvertOct(br);
            else if (radioBtnHex.Checked)
                r = ConvertHex(br);
            else if (radioBtnBin.Checked)
                res = ConvertBin(br);
            else
                label1.Text = "Izaberi osnovu";

            txtConvert.Text = res.ToString();
        }

        private decimal ConvertBin(decimal br)
        {
            throw new NotImplementedException();
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

        private string ConvertHex(decimal num) //10 i 8
        {
            string res = "";
            decimal ost, r = 1, osn = 16, re=0M;

            if (num >= 0 || num <= 9)
                return num.ToString();
            else if (num > 9 || num < 16)
            {
                switch (num)
                {
                    case 10:
                        return res = "A";
                        break;
                    case 11:
                        return res = "B";
                        break;
                    case 12:
                        return res = "C";
                        break;
                    case 13:
                        return res = "D";
                        break;
                    case 14:
                        return res = "E";
                        break;
                    case 15:
                        return res = "F";
                        break;
                }
            }
            else
            {

                do
                {
                    ost = num % osn;
                    num /= osn;
                    re += r * ost;
                    r *= 10;

                }
                while (num != 0);

            }
            return res;


        }
    }
}
