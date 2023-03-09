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
            this.Close();   
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

            1  " nome_Parceiro= '" + txtNome.Text + "'," +
             2 " Cnpj_Parceiro='" + mtbCnpj.Text + "'," +
              3" Status_Parceiro='" + cboStatus.SelectedIndex + "'," +
              4" Logradouro_Parceiro='" + txtLogradouro.Text + "'" +              
              5" Numero_Parceiro= '" + txtNumero.Text + "'," +
              6" Complemento_Parceiro='" + txtComplemento.Text + "'," +
              7" Bairro_Parceiro='" + txtBairro.Text + "'," +
              8" Cep_Parceiro='" + mtbCep.Text + "'," +
              9" Cidade_Parceiro= '" + txtCidade.Text + "'," +
              10" UF_Parceiro='" + cboUF.SelectedIndex + "'," +
              11" Telefone1_Parceiro='" + mtbTelefone1.Text + "'," +
              12" Telefone2_Parceiro='" + mtbTelefone2.Text + "'," +
              13" Email_Parceiro= '" + txtEmail.Text + "'," +
              14" HorarioFuncionamento_Parceiro='" + mtbHorario.Text + "'," +
              15" TipoServico_Parceiro='" + txtTipoServico.Text + "'," +
              16" Especialidade_Parceiro='" + cboEspecialidade.SelectedItem + "'," +
              17" Login_Parceiro=" + txtLogin.Text + "'," +
              18 "Senha_Parceiro= '" + txtSenha.Text + "'," +
              19" Observacao_Parceiro='" + txtObservacao.Text + "'," +
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
