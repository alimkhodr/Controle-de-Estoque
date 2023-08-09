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
using static Controle_estoque.Program;

namespace Controle_estoque.Apresentação
{
    public partial class EditProd : Form
    {

        public EditProd()
        {
            InitializeComponent();
            SqlDataReader dataReader;
            SqlCommand comandosql = con.CreateCommand();
            con.Open();
            comandosql.CommandText = "SELECT * FROM produto WHERE id = @id";
            comandosql.Parameters.AddWithValue("@id", Variaveis.id_produto);
            dataReader = comandosql.ExecuteReader();
            if (dataReader.Read())
            {
                // Preencha as TextBoxes com os valores do banco de dados
                txtnome.Text = dataReader["nome"].ToString();
                txtdescricao.Text = dataReader["descricao"].ToString();
                txtvalidade.Text = dataReader["validade"].ToString();
                txtsetor.Text = dataReader["setor"].ToString();
                txtqtdmin.Text = dataReader["qtdmin"].ToString();
                txtqtdmax.Text = dataReader["qtdmax"].ToString();
                txtqtdatual.Text = dataReader["qtdatual"].ToString();
                txtemailfor.Text = dataReader["emailfor"].ToString();
                txtemailcom.Text = dataReader["emailcom"].ToString();
            }
            con.Close();
        }

        SqlConnection con = new SqlConnection(@"Data Source=10.251.24.11;Initial Catalog=TESTE1;Persist Security Info=True;User ID=sa;Password=P@ssw0rd");
        private bool IsValid()
        {
            if (txtnome.Text == string.Empty || txtvalidade.Text == string.Empty || txtsetor.Text == string.Empty || txtqtdmin.Text == string.Empty || txtqtdmax.Text == string.Empty || txtqtdatual.Text == string.Empty || txtemailfor.Text == string.Empty || txtemailcom.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void txtqtdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txtqtdmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txtqtdatual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }


        private void txtvalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.TextTexto(e);
        }

        private void sair_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(sair, "sair");
        }

        private void CadProd_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string connectionString = "Data Source=10.251.24.11;Initial Catalog=TESTE1;Persist Security Info=True;User ID=sa;Password=P@ssw0rd"; // substitua pela sua string de conexão

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE produto SET nome = @nome, descricao = @descricao, validade = @validade, setor = @setor, qtdmin = @qtdmin, qtdmax = @qtdmax, qtdatual = @qtdatual, emailfor = @emailfor, emailcom = @emailcom WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", Variaveis.id_produto);
                    cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                    cmd.Parameters.AddWithValue("@validade", txtvalidade.Text);
                    cmd.Parameters.AddWithValue("@setor", txtsetor.Text);
                    cmd.Parameters.AddWithValue("@qtdmin", txtqtdmin.Text);
                    cmd.Parameters.AddWithValue("@qtdmax", txtqtdmax.Text);
                    cmd.Parameters.AddWithValue("@qtdatual", txtqtdatual.Text);
                    cmd.Parameters.AddWithValue("@emailfor", txtemailfor.Text);
                    cmd.Parameters.AddWithValue("@emailcom", txtemailcom.Text);

                    if (txtemailfor.Text.Contains("@") && txtemailcom.Text.Contains("@"))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Editado com sucesso!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listagem FrmMain = new Listagem();
                        this.Hide();
                        FrmMain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, digite um endereço de email válido.", "Erro de entrada");
                    }
                }
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Listagem FrmMain = new Listagem();
            FrmMain.Show();
            this.Hide();
        }
    }
}