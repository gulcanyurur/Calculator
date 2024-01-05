using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Char _islem;
        private bool _ekranTemizlenecekMi;
        int _ilkSayi;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1Button_Click(object sender, EventArgs e)

        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "1";
        }

        private void rakam2Buttton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "4";
        }

        private void rakam5Buttton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "5";
        }

        private void rakam6Buttton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "8";
        }

        private void rakam9Buttton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            ekranlabel.Text += "0";
        }

        private void artıButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlabel.Text);

        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranlabel.Text);
            int sonuc = 0;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikincisayi;
                    break;
            }

            ekranlabel.Text = Convert.ToString(sonuc);

        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlabel.Text);

        }

        private void çarpıButton_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlabel.Text);

        }

        private void bölüButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlabel.Text);

        }
    }
}
