using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaFinal {
    public partial class Form1 : Form {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BancoNotas;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        public Form1() {
            InitializeComponent();
            ExibirDados();
        }

        public void ExibirDados() {
            try {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT * FROM Notas", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch {
                throw;
            }
            finally {
                con.Close();
            }
        }

        public void LimparDados() {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtNota1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            if (txtNota1.Text != "" && txtNota2.Text != "" && txtNota3.Text != "" && txtNota4.Text != "") {
                double nota1 = double.Parse(txtNota1.Text);
                double nota2 = double.Parse(txtNota2.Text);
                double nota3 = double.Parse(txtNota3.Text);
                double nota4 = double.Parse(txtNota4.Text);
                Calculos calc = new Calculos(nota1, nota2, nota3, nota4);
                lblMedia.Text = calc.Media().ToString("F2", CultureInfo.InstalledUICulture);
                lblMaiorNumero.Text = calc.MaiorNota().ToString();
                lblMenorNumero.Text = calc.MenorNota().ToString();
                lblSomaPar.Text = calc.SomaPar().ToString();
                lblSomaImpar.Text = calc.SomaImpar().ToString();
                lblMaiorIgualSete.Text = calc.MaiorIgualSete().ToString();
            }
            else {
                MessageBox.Show("Informe todas as notas nos campos solicitados");
                txtNota1.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Deseja sair do programa?", "Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
            else
                txtNota1.Focus();

        }

        private void btnSalvarNotas_Click(object sender, EventArgs e) {
            if (txtNota1.Text != "" && txtNota2.Text != "" && txtNota3.Text != "" && txtNota4.Text != "") {
                try {
                    cmd = new SqlCommand("INSERT INTO Notas(nota1, nota2, nota3, nota4) VALUES (@nota1, @nota2, @nota3, @nota4)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@nota1", txtNota1.Text);
                    cmd.Parameters.AddWithValue("@nota2", txtNota2.Text);
                    cmd.Parameters.AddWithValue("@nota3", txtNota3.Text);
                    cmd.Parameters.AddWithValue("@nota4", txtNota4.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso");
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally {
                    con.Close();
                    ExibirDados();
                    LimparDados();
                }
            }
            else
                MessageBox.Show("Informe as notas nos campos requeridos");
        }

        private void btnLimparNotas_Click(object sender, EventArgs e) {
            if (ID != 0) {
                if (MessageBox.Show("Deseja deletar estas notas?", "Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    try {
                        cmd = new SqlCommand("DELETE Notas WHERE id=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Notas deletadas com sucesso");
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                    finally {
                        con.Close();
                        ExibirDados();
                        LimparDados();
                    }
                }
                else
                    MessageBox.Show("Selecione uma nota para deletar");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            try {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNota1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNota2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNota3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNota4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch { }
        }

        private void btnLerNotas_Click(object sender, EventArgs e) {
            LimparDados();
        }
    }
}
