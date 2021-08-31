using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADS4_24_08_2021_A
{
    public partial class Form1 : Form
    {
        //  Pessoa P1 = new Pessoa(); // errado "funciona"
        Pessoa P1; // coreto

        public Form1()
        {
            InitializeComponent();
            P1 = new Pessoa(); // correto
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //    textBox2.Text = textBox1.Text;

            //Pessoa P1;
            //P1 = new Pessoa();
            //P1 = new Pessoa("Ola Mundo");
            //P1 = new Pessoa(textBox1.Text);

            Pessoa P1 = new Pessoa();

            P1.Nome = textBox1.Text;
            P1.SetCPF(Convert.ToDouble(textBox2.Text));
            P1.RA = Convert.ToInt32(textBox3.Text);

            textBox4.Text = P1.Nome;
            textBox5.Text = Convert.ToString(P1.GetCPF());
            textBox6.Text = Convert.ToString(P1.RA);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  Pessoa P1 = new Pessoa();
           

            P1.Nome = textBox1.Text;
            P1.SetCPF(Convert.ToDouble(textBox2.Text));
            P1.RA = Convert.ToInt32(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
         //   Pessoa P1 = new Pessoa();

            textBox4.Text = P1.Nome;
            textBox5.Text = Convert.ToString(P1.GetCPF());
            textBox6.Text = Convert.ToString(P1.RA);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
