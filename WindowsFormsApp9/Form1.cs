using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name_1;
            DateTime vek_1 = DateTime.Now;
            name_1 = textBox1.Text;
            if (textBox2.Text != string.Empty)
            {
                vek_1 = DateTime.Parse(textBox2.Text);
            }

            string name_2;
            DateTime vek_2 = DateTime.Now;
            name_2 = textBox3.Text;
            if(textBox4.Text != string.Empty)
            {
                vek_2 = DateTime.Parse(textBox4.Text);
            }

            Clovek clovek = new Clovek(name_1, vek_1);
            string Y = clovek.Vypis_jmeno();
            MessageBox.Show(Y);
            string X = clovek.ToString();
            MessageBox.Show(X);
            string K = clovek.Starsi(name_2, vek_2);
            MessageBox.Show(K);
        }
    }
}
