using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2_sayılı_hesap_makınesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, sonuc;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 + sayı2;
            label4.Text = sonuc.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double sayı1, sayı2, sonuc;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 - sayı2;
            label4.Text = sonuc.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double sayı1, sayı2, sonuc;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 * sayı2;
            label4.Text = sonuc.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double sayı1, sayı2, sonuc;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 / sayı2;
            label4.Text = sonuc.ToString();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
