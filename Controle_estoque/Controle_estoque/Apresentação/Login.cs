using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Controle_estoque.Modelo;
using System.Security.Principal;
using System.Diagnostics;

namespace Controle_estoque
{
    public partial class Login : Form
    {
        public int id_usuario;

        public static class UsuarioLogado
        {
            public static string Registro { get; set; }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnolho_MouseDown(object sender, MouseEventArgs e)
        {
            txtsenha.UseSystemPasswordChar = false;
        }

        private void btnolho_MouseUp(object sender, MouseEventArgs e)
        {
            txtsenha.UseSystemPasswordChar = true;
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string registro = txtregistro.Text;
            Controle controle = new Controle();
            controle.acessar(txtregistro.Text, txtsenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Acesso liberado!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string connectionString = "Data Source=10.251.24.11;Initial Catalog=TESTE1;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
                    SqlConnection con = new SqlConnection(connectionString);
                    string query = "SELECT tipo_usuario, nome_usuario FROM usuario WHERE registro_usuario = @registro";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@registro", txtregistro.Text);

                    con.Open();
                    string tipoUsuario = (string)cmd.ExecuteScalar();
                    con.Close();

                    if (tipoUsuario == "Administrador")
                    {
                        string RegistroUsuario = ObterNomeUsuario(registro);
                        UsuarioLogado.Registro = RegistroUsuario;
                        Listagem FrmMain = new Listagem();
                        FrmMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        string RegistroUsuario = ObterNomeUsuario(registro);
                        UsuarioLogado.Registro = RegistroUsuario;
                        ListagemUser FrmMain = new ListagemUser();
                        FrmMain.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("registro ou senha incorreta", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }

        private void txtregistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string ObterNomeUsuario(string registro)
        {
            string connectionString = "Data Source=10.251.24.11;Initial Catalog=TESTE1;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT registro_usuario = @registro FROM usuario", con);
                command.Parameters.AddWithValue("@registro", registro);
                return (string)command.ExecuteScalar();
            }
        }

        private void btnlogin_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnlogin, "Fazer Login");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
