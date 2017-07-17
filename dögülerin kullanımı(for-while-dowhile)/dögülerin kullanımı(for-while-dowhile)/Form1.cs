using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dögülerin_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
           int kaçkere;
          kaçkere = int.Parse(textBox1.Text);
          string neyazılacak = textBox2.Text;

            for (int i = 0; i < kaçkere; i++)
            {
                listBox1.Items.Add(neyazılacak);
            }
            }
            catch { MessageBox.Show("Alanları Boş Bırakma."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int kaçkere;
            kaçkere = int.Parse(textBox4.Text);
            string neyazılcak = textBox3.Text;
            int i = 0;

            while (i < kaçkere)
            {
                i++;
                listBox2.Items.Add(neyazılcak);
            }
            }
            catch { MessageBox.Show("Alanları Boş Bırakma."); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int kaçkere;
            kaçkere = int.Parse(textBox6.Text);
            string neyazılacak = textBox5.Text;
            int i = 0;
            do
            {
             i++;
                listBox3.Items.Add(neyazılacak);
            }
            while(i < kaçkere);
            }
            catch { MessageBox.Show("Alanları Boş Bırakma."); }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }
    }
}
