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
    public partial class FrmUsuarioDepartamento : Form
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

        public FrmUsuarioDepartamento()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();   
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNome.Text = "";
            mtbCnpj.Text = "";
            cboStatus.SelectedIndex = -1;
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            mtbCep.Text = "";
            txtCidade.Text = "";
            cboUF.SelectedIndex = -1;
            mtbTelefone1.Text = "";
            mtbTelefone2.Text = "";
            txtEmail.Text = "";
            txtEmail.Text = "";
            mtbHorario.Text = "";
            txtTipoServico.Text = "";
            cboEspecialidade.SelectedIndex = -1;
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtObservacao.Text = "";    
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update Parceiro set" +

              " nome_Parceiro= '" + txtNome.Text + "'," +
              " Cnpj_Parceiro='" + mtbCnpj.Text + "'," +
              " Status_Parceiro='" + cboStatus.SelectedIndex + "'," +
              " Logradouro_Parceiro='" + txtLogradouro.Text + "'" +              
              " Numero_Parceiro= '" + txtNumero.Text + "'," +
              " Complemento_Parceiro='" + txtComplemento.Text + "'," +
              " Bairro_Parceiro='" + txtBairro.Text + "'," +
              " Cep_Parceiro='" + mtbCep.Text + "'," +
              " Cidade_Parceiro= '" + txtCidade.Text + "'," +
              " UF_Parceiro='" + cboUF.SelectedIndex + "'," +
              " Telefone1_Parceiro='" + mtbTelefone1.Text + "'," +
              " Telefone2_Parceiro='" + mtbTelefone2.Text + "'," +
              " Email_Parceiro= '" + txtEmail.Text + "'," +
              " HorarioFuncionamento_Parceiro='" + mtbHorario.Text + "'," +
              " TipoServico_Parceiro='" + txtTipoServico.Text + "'," +
              " Especialidade_Parceiro='" + cboEspecialidade.SelectedItem + "'," +
              " Login_Parceiro=" + txtLogin.Text + "'," +
              "Senha_Parceiro= '" + txtSenha.Text + "'," +
              " Observacao_Parceiro='" + txtObservacao.Text + "'," +
              " where id_Parceiro=" + txtID.Text;

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
