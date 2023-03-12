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
     "data source=DESKTOP-UKENASA\\SQLEXPRESS;" +
    "initial Catalog= ProjetoIntegradorT_13;" +
    "User ID=admwellington;" +
    "password=elaine1988";


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
            if (validar())
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

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from Parceiro where id_Parceiro=" + txtID.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader Reader;
            conexao.Open();
            try
            {
                Reader = cmd.ExecuteReader();
                if (Reader.Read())
                {

                    mtbDataCadastro.Text = Reader[1].ToString();
                    cboStatus.SelectedItem = Reader[2].ToString();
                    txtNome.Text = Reader[3].ToString();
                    mtbCnpj.Text = Reader[4].ToString();
                    txtLogin.Text = Reader[5].ToString();
                    txtSenha.Text = Reader[6].ToString();
                    cboEspecialidade.SelectedItem = Reader[7].ToString();
                    txtTipoServico.Text = Reader[8].ToString();
                    mtbCep.Text = Reader[9].ToString();
                    txtLogradouro.Text = Reader[10].ToString();
                    txtNumero.Text = Reader[11].ToString();
                    txtBairro.Text = Reader[12].ToString();
                    txtCidade.Text = Reader[13].ToString();
                    cboUF.SelectedItem = Reader[14].ToString();
                    txtComplemento.Text = Reader[15].ToString();
                    mtbHorario.Text = Reader[16].ToString();
                    mtbTelefone1.Text = Reader[17].ToString();
                    mtbTelefone2.Text = Reader[18].ToString();
                    txtEmail.Text = Reader[19].ToString();
                    txtObservacao.Text = Reader[20].ToString();
                }
                else
                {
                    MessageBox.Show("codigo de usuario Inválido!");
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

        private void FrmUsuarioDepartamento_Load(object sender, EventArgs e)
        {
            testarConexao();
        }
        private bool validar()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Erro,Preencha o campo nome");
                txtNome.Text = "";
                txtNome.Focus();
                return false;
            }
            if (cboStatus.Text == "")
            {
                MessageBox.Show("Erro.Preencha o campo Status");
                cboStatus.SelectedIndex = -1;
                cboStatus.Focus();
                return false;
            }
            if (mtbCnpj.Text == "")
            {
                MessageBox.Show("Erro,Preencha o campo CNPJ");
                mtbCnpj.Text = "";
                mtbCnpj.Focus();
                return false;
            }
            if (txtLogradouro.Text == "")
            {
                MessageBox.Show("Erro,Preencha o campo Logradouro'Nome da Rua'");
                txtLogradouro.Text = "";
                txtLogradouro.Focus();
                return false;
            }
            if (txtNumero.Text == "")
            {
                {
                    MessageBox.Show("Erro, Preencha o campo  Numero ");
                    txtNumero.Text = "";
                    txtNumero.Focus();
                    return false;
                }
            }
            if (txtBairro.Text == "")
            {
                {
                    MessageBox.Show("Erro, Preencha o campo bairro");
                    txtBairro.Text = "";
                    txtBairro.Focus();
                    return false;
                }
            }
            if (mtbCep.Text == "")
            {
                MessageBox.Show("Erro,Preencha o campo Cep");
                mtbCep.Text = "";
                mtbCep.Focus();
                return false;
            }
            if (txtCidade.Text == "")
            {
                MessageBox.Show("Erro, Preencha o campo Status");
                txtCidade.Text = "";
                txtCidade.Focus();
                return false;
            }
            if (cboUF.Text == "")
            {
                MessageBox.Show("Erro, Selecione o campo UF");
                cboUF.Text = "";
                cboUF.Focus();
                return false;
            }
            if (mtbTelefone1.Text == "")
            {
                MessageBox.Show("Erro, Preencha o campo Telefone1");
                mtbTelefone1.Text = "";
                mtbTelefone1.Focus();
                return false;
            }
            if (txtEmail.Text == "")
            {
                {
                    MessageBox.Show("Erro, Preencha o campo bairro");
                    txtEmail.Text = "";
                    txtEmail.Focus();
                    return false;
                }
            }
            if (mtbHorario.Text == "")
            {
                {
                    MessageBox.Show("Erro, Preencha o campo Horario de Funcionamento");
                    mtbHorario.Text = "";
                    mtbHorario.Focus();
                    return false;
                }
            }
            //if (txtTipoServico.Text == "")
            //{
            //MessageBox.Show("Erro,");
            //txtTipoServico.Text = "";
            //txtTipoServico.Focus();
            //return false;
            //}
            //if (cboEspecialidade.Text == "")
            //{
            //MessageBox.Show("Erro,");
            //cboEspecialidade.Text = "";
            //cboEspecialidade.Focus();
            //return false;
            //}
            if (txtLogin.Text != txtLogin.Text)
            {
                {
                    MessageBox.Show("Erro, Preencha o campo Login");
                    txtLogin.Text = "";
                    txtLogin.Focus();
                    return false;
                }
            }
            if (txtSenha.Text != txtSenha.Text)
            {
                {
                    MessageBox.Show("Erro, Preencha o campo Senha, Invalido Senhas Diferentes ");
                    txtSenha.Text = "";
                    txtSenha.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            //if (validar())
            //{
                string sql = "insert into Parceiro" +
             "(" +
                  " nome_Parceiro," +
                  " CNPJ_Parceiro," +
                  " Status_Parceiro," +
                  " logradouro_Parceiro," +
                  " Numero_Parceiro," +
                  " Complemento_Parceiro," +
                  " bairro_Parceiro," +
                  " cep_Parceiro," +
                  " cidade_Parceiro," +
                  " uf_Parceiro," +
                  " telefone1_Parceiro," +
                  " telefone2_Parceiro," +
                  " email_Parceiro," +
                  " HorarioFuncionamento_Parceiro," +
                  " TipoServico_Parceiro," +
                  " Especialidade_Parceiro," +
                  " Login_Parceiro," +
                  " Senha_Parceiro," +
                  " Obs_Parceiro" +

               ")" +
                " values" +
                "(" +
                "'" + txtNome.Text + "'," +
                "'" + mtbCnpj.Text + "'," +
                "'" + cboStatus.SelectedItem + "'," +
                "'" + txtLogradouro.Text + "'" +
                "'" + txtNumero.Text + "'," +
                "'" + txtComplemento.Text + "'," +
                "'" + txtBairro.Text + "'," +
                "'" + mtbCep.Text + "'," +
                "'" + txtCidade.Text + "'," +
                "'" + cboUF.SelectedItem + "'," +
                "'" + mtbTelefone1.Text + "'," +
                "'" + mtbTelefone2.Text + "'," +
                "'" + txtEmail.Text + "'," +
                "'" + mtbHorario.Text + "'," +
                "'" + txtTipoServico.Text + "'," +
                "'" + cboEspecialidade.SelectedItem + "'," +
                "'" + txtLogin.Text + "'," +
                "'" + txtSenha.Text + "'," +
                "'" + txtObservacao.Text + "'" +

                ")";
                SqlConnection conn = new SqlConnection(stringConexao);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            //}
        }
    }
}

