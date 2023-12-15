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
    public partial class EditUser : Form
    {
        SqlConnection con = new SqlConnection(@"sua_conexão");
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM usuario WHERE registro_usuario = @registro";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Registro", Login.UsuarioLogado.Registro);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                // Preencher os campos do formulário com os dados do usuário
                txtnome.Text = reader["nome_usuario"].ToString();
                txtsetor.Text = reader["setor_usuario"].ToString();
                // Outros campos do usuário...
            }
            reader.Close();
            con.Close();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (txtnovasenha.Text.Equals(txtconfnovasenha.Text))
                {
                    con.Open();
                    string sql3 = "SELECT senha_usuario FROM usuario WHERE registro_usuario = @registro";
                    SqlCommand command3 = new SqlCommand(sql3, con);
                    command3.Parameters.AddWithValue("@registro", Login.UsuarioLogado.Registro);
                    string senhausuario = (string)command3.ExecuteScalar();
                    con.Close();

                    if (txtnovasenha.Text != senhausuario)
                    {
                        con.Open();
                        string sql = "UPDATE usuario SET nome_usuario = @nome, setor_usuario = @setor, senha_usuario = @senha WHERE registro_usuario = @registro";
                        SqlCommand command = new SqlCommand(sql, con);
                        command.Parameters.AddWithValue("@nome", txtnome.Text);
                        command.Parameters.AddWithValue("@registro", Login.UsuarioLogado.Registro);
                        command.Parameters.AddWithValue("@setor", txtsetor.Text);
                        command.Parameters.AddWithValue("@senha", txtnovasenha.Text);
                        command.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Editado com sucesso!", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.Open();
                        string sql2 = "SELECT tipo_usuario FROM usuario WHERE registro_usuario = @registro";
                        SqlCommand command2 = new SqlCommand(sql2, con);
                        command2.Parameters.AddWithValue("@registro", Login.UsuarioLogado.Registro);
                        string tipoUsuario = (string)command2.ExecuteScalar();
                        con.Close();

                        if (tipoUsuario == "Administrador")
                        {
                            Listagem FrmMain = new Listagem();
                            FrmMain.Show();
                            this.Hide();
                        }
                        else
                        {
                            ListagemUser FrmMain = new ListagemUser();
                            FrmMain.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha já existente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Senhas divirgentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValid()
        {
            if (txtnome.Text == string.Empty || txtsetor.Text == string.Empty || txtnovasenha.Text == string.Empty || txtconfnovasenha.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void sair_Click(object sender, EventArgs e)
        {
            string sql = "SELECT tipo_usuario FROM usuario WHERE registro_usuario = @registro";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@registro", Login.UsuarioLogado.Registro);
            con.Open();
            string tipoUsuario = (string)command.ExecuteScalar();
            con.Close();

            if (tipoUsuario == "Administrador")
            {
                Listagem FrmMain = new Listagem();
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                ListagemUser FrmMain = new ListagemUser();
                FrmMain.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnolho2_MouseDown(object sender, MouseEventArgs e)
        {
            txtnovasenha.UseSystemPasswordChar = false;
        }

        private void btnolho2_MouseUp(object sender, MouseEventArgs e)
        {
            txtnovasenha.UseSystemPasswordChar = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtconfnovasenha.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtconfnovasenha.UseSystemPasswordChar = true;
        }

        private void sair_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(sair, "sair");
        }

        private void btnsalvar_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnsalvar, "salvar edição");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
