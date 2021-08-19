using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validador_de_pontes
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
            double pa, aat, av, vb, ct,  pt;


            if(comboBox1.SelectedIndex == 0)
            {
                pa = 150;

                aat = 80;
            }


            else if (comboBox1.SelectedIndex == 1)
            {
                pa = 40;

                aat = 50;
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                pa = 100;

                aat = 30;
            }

            else
            {
                MessageBox.Show("Selecione a ponte desejada", "ops!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            if (Double.TryParse(textBox1.Text,out av) == false || Double.TryParse(textBox3.Text, out vb)==false || Double.TryParse(textBox4.Text, out ct)==false) {

                MessageBox.Show("Insira todos os dados necessários", "ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            if (av >= aat)
            {
                MessageBox.Show("Altura Insuficiente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Altura Suportada", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if ((vb + ct) >= pa)
            {
                MessageBox.Show("pesso maior que o suportado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            else
            {
                MessageBox.Show("peso Suportado", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
    }
}
