using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp10
{
    public partial class frmDepartamento : Form
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
            public frmDepartamento()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btoSair_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e) 
        {
            txtCodigo.Text = "";
            cboNomeDepartamento.SelectedIndex = -1;
            txtUsuario.Text = "";
            cboIdUsuario.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            txtCodigo.Focus();

        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from Categoria where id_Categoria= " + txtCodigo.Text;


            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            try
            {
                conexao.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Dados exluidos com sucesso");
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

        private void btoAtualizar_Click(object sender, EventArgs e)
        {
            string sql = "update Categoria set" +

             " nome_Departamento= '" + cboNomeDepartamento.SelectedIndex + "'," +
             " status_Departamento='" + cboStatus.SelectedItem + "'" +
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