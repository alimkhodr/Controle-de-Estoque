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

namespace Controle_estoque.Apresentação
{
    public partial class CadProd : Form
    {
        public CadProd()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"sua_conexão");
        public int id;

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO produto (nome, descricao, validade, setor, qtdmin, qtdmax,qtdatual, emailfor, emailcom) values (@nome,@descricao,@validade,@setor,@qtdmin,@qtdmax,@qtdatual,@emailfor,@emailcom);", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                cmd.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                cmd.Parameters.AddWithValue("@validade", txtvalidade.Text);
                cmd.Parameters.AddWithValue("@setor", txtsetor.Text);
                cmd.Parameters.AddWithValue("@qtdmin", txtqtdmin.Text);
                cmd.Parameters.AddWithValue("@qtdmax", txtqtdmax.Text);
                cmd.Parameters.AddWithValue("@qtdatual", txtqtdatual.Text);
                cmd.Parameters.AddWithValue("@emailfor", txtemailfor.Text);
                cmd.Parameters.AddWithValue("@emailcom", txtemailcom.Text);

                if (txtemailfor.Text.Contains("@") & txtemailcom.Text.Contains("@"))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Cadastrado com sucesso!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Listagem FrmMain = new Listagem();
                    FrmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Por favor, digite um endereço de email válido.", "Erro de entrada");
                }
            }
        }

        private bool IsValid()
        {
            if (txtnome.Text == string.Empty  || txtvalidade.Text == string.Empty || txtsetor.Text == string.Empty || txtqtdmin.Text == string.Empty || txtqtdmax.Text == string.Empty || txtqtdatual.Text == string.Empty || txtemailfor.Text == string.Empty || txtemailcom.Text == string.Empty)
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

        private void sair_Click(object sender, EventArgs e)
        {
            Listagem FrmMain = new Listagem();
            FrmMain.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sair_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(sair, "sair");
        }

        private void CadProd_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
