using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            double altura = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            double peso = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            IMC imc = new IMC();
            string resultado = imc.CalculoIMC(altura, peso);
            label3.Text = resultado;
        }

        private void button2_Click(object sender, EventArgs e) {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }
    }
}
