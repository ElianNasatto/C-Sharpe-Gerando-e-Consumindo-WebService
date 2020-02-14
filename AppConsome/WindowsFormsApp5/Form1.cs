using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ws = new MeuServico.MeuServico();
            richTextBox1.Text = ws.HelloWorld();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ws = new MeuServico.MeuServico();
            richTextBox2.Text = ws.RetornaParametro(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ws = new MeuServico.MeuServico();
            MeuServico.Carro carro = ws.RetornaCarro();
            richTextBox3.Text = carro.Nome;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var wb = new Calculator.Calculator();
            textBox4.Text = wb.Add(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var wb = new Calculator.Calculator();
            textBox4.Text = wb.Subtract(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)).ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var wb = new Calculator.Calculator();
            textBox4.Text = wb.Divide(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var wb = new Calculator.Calculator();
            textBox4.Text = wb.Multiply(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)).ToString();
        }
    }
}
