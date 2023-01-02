using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sinav1;
            double sinav2;
            double proje;
            double sonuc;

            sinav1 = Convert.ToInt32(textBox1.Text);
            sinav2 = Convert.ToInt32(textBox2.Text);
            proje = Convert.ToInt32(textBox3.Text);
            //sonuc = Convert.ToInt32(textBox4.Text);

            sonuc = sinav1 * 0.3 + sinav2 * 0.5 + proje * 0.2;
            textBox4.Text = sonuc.ToString();

            if (sonuc >= 50)
            {
                label4.Text = "GEÇTİ";
            }
            else
            {
                label4.Text = "KALDI";
            }
        }
    }
}
