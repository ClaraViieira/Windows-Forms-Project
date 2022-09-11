using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            int valor1 = int.Parse(textBox1.Text);
            int valor2 = int.Parse(textBox2.Text);
            Calculos calc = new Calculos();
            label3.Text = calc.Somar(valor1, valor2).ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            int valor1 = int.Parse(textBox1.Text);
            int valor2 = int.Parse(textBox2.Text);
            Calculos calc = new Calculos();
            label3.Text = calc.Subtrair(valor1, valor2).ToString();
        }

        private void button3_Click(object sender, EventArgs e) {
            int valor1 = int.Parse(textBox1.Text);
            int valor2 = int.Parse(textBox2.Text);
            Calculos calc = new Calculos();
            label3.Text = calc.Multiplicar(valor1, valor2).ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            int valor1 = int.Parse(textBox1.Text);
            int valor2 = int.Parse(textBox2.Text);
            Calculos calc = new Calculos();
            label3.Text = calc.Dividir(valor1, valor2).ToString();
        }

        private void button5_Click(object sender, EventArgs e) {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }
    }
}
