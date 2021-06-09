using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        private int _sayi1, _sayi2, _islem;
        bool _temizle;
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void number1_Click(object sender, EventArgs e)
        {
            if (_temizle == true) textBox1.Text = "";
            _temizle = false;
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (_temizle == true) textBox1.Text = "";
            _temizle = false;
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (_temizle == true) textBox1.Text = "";
            _temizle = false;
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "3";
        }
        private void number4_Click(object sender, EventArgs e)
        {
            if (_temizle == true) textBox1.Text = "";
            _temizle = false;
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (_temizle == true) textBox1.Text = "";
            _temizle = false;
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (_temizle == true) textBox1.Text = "";
            _temizle = false;
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (_temizle == true) textBox1.Text = "";
            _temizle = false;
            if (textBox1.Text == "0") textBox1.Text = "";
             textBox1.Text += "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (_temizle == true) textBox1.Text = "";
            _temizle = false;
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (_temizle == true) textBox1.Text = "";
            _temizle = false;
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "9";
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (_temizle == true) textBox1.Text = "";
            _temizle = false;
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text += "0";
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            _sayi1 = Convert.ToInt32(textBox1.Text);
            _islem = 4;
            _temizle = true;
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            _islem = 1;
            _sayi1 = Convert.ToInt32(textBox1.Text);
            _temizle = true;

        }

        private void cıkarma_Click(object sender, EventArgs e)
        {
            _islem = 2;
            _sayi1 = Convert.ToInt32(textBox1.Text);
            _temizle = true;
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            _islem = 3;
            _sayi1 = Convert.ToInt32(textBox1.Text);
            _temizle = true;

        }
        private void esittir_Click(object sender, EventArgs e)
        {
            _sayi2 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            switch (_islem)
            {

                case 1:
                    textBox1.Text = (_sayi1 + _sayi2).ToString();
                    break;

                case 2:
                    textBox1.Text = (_sayi1 - _sayi2).ToString();
                    break;

                case 3:
                    textBox1.Text = (_sayi1 * _sayi2).ToString();
                    break;
                case 4:
                    textBox1.Text = (_sayi1 / _sayi2).ToString();
                    break;

                    
            }

        }

    }
}
