using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        string girilen1, girilen2;
        double sayi1, sayi2;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void zerobutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (screenlabel.Text == "0")
            {
                screenlabel.Text = "";
            }
            screenlabel.Text += "0";
        }

        private void onebutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (screenlabel.Text == "0")
            {
                screenlabel.Text = "";
            }
            screenlabel.Text += "1";
        }

        private void twobutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (screenlabel.Text == "0")
            {
                screenlabel.Text = "";
            }
            screenlabel.Text += "2";
        }

        private void threebutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (screenlabel.Text == "0")
            {
                screenlabel.Text = "";
            }
            screenlabel.Text += "3";
        }

        private void fourbutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (screenlabel.Text == "0")
            {
                screenlabel.Text = "";
            }
            screenlabel.Text += "4";
        }

        private void fivebutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (screenlabel.Text == "0")
            {
                screenlabel.Text = "";
            }
            screenlabel.Text += "5";
        }

        private void sixbutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (screenlabel.Text == "0")
            {
                screenlabel.Text = "";
            }
            screenlabel.Text += "6";
        }

        private void sevenbutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (screenlabel.Text == "0")
            {
                screenlabel.Text = "";
            }
            screenlabel.Text += "7";
        }

        private void eightbutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (screenlabel.Text == "0")
            {
                screenlabel.Text = "";
            }
            screenlabel.Text += "8";
        }       

        private void ninebutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (screenlabel.Text == "0")
            {
                screenlabel.Text = "";
            }
            screenlabel.Text += "9";
        }
       
        private void clearbutton_MouseClick(object sender, MouseEventArgs e)
        {
            islem = "";
            sayi1 = 0;
            sayi2 = 0;
            girilen1 = "";
            girilen2 = "";
            screenlabel.Text = "0";
        }
        private void minusbutton_MouseClick(object sender, MouseEventArgs e)
        {
            double gecici;
            gecici = Convert.ToDouble(screenlabel.Text);
            gecici *= -1;
            screenlabel.Text = Convert.ToString(gecici);
        }
        private void commabutton_MouseClick(object sender, MouseEventArgs e)
        {
            screenlabel.Text += ",";
        }

        private void subtractionbutton_MouseClick(object sender, MouseEventArgs e)
        {
            islem = "topla";
            girilen1 = screenlabel.Text;
            screenlabel.Text = "";
        }


        private void additionbutton_MouseClick(object sender, MouseEventArgs e)
        {
            islem = "cikar";
            girilen1 = screenlabel.Text;
            screenlabel.Text = "";
        }
        
        private void multiplybutton_MouseClick(object sender, MouseEventArgs e)
        {
            islem = "carp";
            girilen1 = screenlabel.Text;
            screenlabel.Text = "";
        }
        

        private void dividebutton_MouseClick(object sender, MouseEventArgs e)
        {
            islem = "bol";
            girilen1 = screenlabel.Text;
            screenlabel.Text = "";
        }

       
        private void percentbutton_MouseClick(object sender, MouseEventArgs e)
        {
            islem = "yuzde";
            girilen1 = screenlabel.Text;
            screenlabel.Text = "";
        }       

        private void powbutton_MouseClick(object sender, MouseEventArgs e)
        {
            islem = "kare";
            girilen1 = screenlabel.Text;
            girilen2 = "0";
            screenlabel.Text = "";
        }
      

        private void squarebutton_MouseClick(object sender, MouseEventArgs e)
        {
            islem = "karekok";
            girilen1 = screenlabel.Text;
            girilen2 = "0";
            screenlabel.Text = "";
        }

        private void equalbutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (islem == "topla" || islem == "cikar" || islem == "carp" || islem == "bol" || islem == "yuzde")
            {
                girilen2 = screenlabel.Text;
                sayi2 = Convert.ToDouble(girilen2);
            }
            screenlabel.Text = "";
            sayi1 = Convert.ToDouble(girilen1);
            double sonuc;
            if (islem == "topla")
            {
                sonuc = sayi1 + sayi2;
                screenlabel.Text = sonuc.ToString();
            }
            else if (islem == "cikar")
            {
                sonuc = sayi1 - sayi2;
                screenlabel.Text = sonuc.ToString();
            }
            else if (islem == "carp")
            {
                sonuc = sayi1 * sayi2;
                screenlabel.Text = sonuc.ToString();
            }
            else if (islem == "bol")
            {
                sonuc = sayi1 / sayi2;
                screenlabel.Text = sonuc.ToString();
            }
            else if (islem == "yuzde")
            {
                sonuc = (sayi1 * sayi2) / 100;
                screenlabel.Text = sonuc.ToString();
            }
            else if (islem == "kare")
            {
                sonuc = sayi1 * sayi1;
                screenlabel.Text = sonuc.ToString();
            }
            else if (islem == "karekok")
            {
                sonuc = Math.Sqrt(sayi1);
                screenlabel.Text = sonuc.ToString();
            }
        }
    }
}