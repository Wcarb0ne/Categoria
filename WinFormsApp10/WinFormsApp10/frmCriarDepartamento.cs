using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp10
{
    public partial class frmCriarDepartamento : Form
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

        public frmCriarDepartamento()
        {
            InitializeComponent();
        }
        private bool validar()
        {

            if (txtNomeDepartamento.Text == "")
            {
                MessageBox.Show("Erro, Preencha o Campo Nome do Departamento");
                txtNomeDepartamento.Text = "";
                txtNomeDepartamento.Focus();
                return false;
            }
            if (cboStatus.Text == "")
            {
                MessageBox.Show("Erro, Preencha o campo Status do Departamento");
                cboStatus.SelectedIndex = -1;
                cboStatus.Focus();
                return false;
            }
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Erro, Preencha o campo Descrição do Departamento");
                txtDescricao.Text = "";
                txtDescricao.Focus();
                return false;
            }
            return true;
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
            txtCodigo.Text = "";
            mtbDataCadastro.Text = "";
            txtNomeDepartamento.Text = "";
            cboStatus.SelectedIndex = -1;
            txtDescricao.Text = "";
            txtObs.Text = "";
            txtCodigo.Focus();

        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                string sql = "update departamento set" +

             " nome_departamento= '" + txtNomeDepartamento.Text + "'," +
               //" login_departamento='" + txtLogin.Text + "'," +
               " descricao_departamento='" + txtDescricao.Text + "'," +
               " observacao_departamento='" + txtObs.Text + "'," +
               " status_departamento='" + cboStatus.SelectedItem + "'" +
               " where id_departamento=" + txtCodigo.Text;



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

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from departamento where id_departamento= " + txtCodigo.Text;


            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            try
            {
                conexao.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show(" Area do Departamento excluido com sucesso");
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

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
           // if (validar())
            //{
                string sql = "insert into departamento" +
            "(" +
              " nome_departamento," +
              " status_departamento," +
              " descricao_departamento," +
              " observacao_departamento" +
              ")" +
               " values" +
               "(" +
               "'" + txtNomeDepartamento.Text + "'," +
               "'" + cboStatus.SelectedItem + "'," +
               "'" + txtDescricao.Text + "'," +
               "'" + txtObs.Text + "'" +
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
                        MessageBox.Show("Departamento Cadastrado com sucesso");
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

        private void frmCriarDepartamento_Load(object sender, EventArgs e)
        {
            testarConexao();
        }

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from departamento where id_departamento=" + txtCodigo.Text;

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

                    txtNomeDepartamento.Text = Reader[1].ToString();
                    cboStatus.SelectedItem = Reader[2].ToString();
                    txtDescricao.Text = Reader[3].ToString();
                    txtObs.Text = Reader[4].ToString();
                }
                else
                {
                    MessageBox.Show("Codigo de Departamento Invalido!");
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
