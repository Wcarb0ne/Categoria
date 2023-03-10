using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class frmCriarDepartamento : Form
    {
        string stringConexao = "" +
    "data source=localhost;" +
    "initial Catalog= ProjetoIntegradorT_13;" +
    "User ID=sa;" +
    "password=123456";


        private void testarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
                Application.Exit();
            }
        }
        public frmCriarDepartamento()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btoSair_Click(object sender, EventArgs e)
        {

        }

        private void btoSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            mtbDataCadastro.Text = string.Empty;
            txtNomeDepartamento.Text = string.Empty;
            cboStatus.SelectedIndex = -1;
            txtDescricao.Text = string.Empty;
            txtObs.Text = string.Empty;
            txtCodigo.Focus();

        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update Departamento set" +

             " nome_Departamento= '" + txtNomeDepartamento.Text + "'," +
             " status_Departamento='" + cboStatus.SelectedIndex + "'," +
             " descricao_Departamento= '" + txtDescricao.Text + "'," +
             " observacao_Departamento='" + txtObs.Text + "'," +
             " where id_Departamento=" + txtCodigo.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            try
            {
                conexao.Open();

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados alterados com sucesso.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
