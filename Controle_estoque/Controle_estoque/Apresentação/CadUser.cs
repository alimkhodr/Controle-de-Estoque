using Controle_estoque.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_estoque
{
    public partial class CadUser : Form
    {

        public CadUser()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            if (txtnome.Text == string.Empty || txtregistro.Text == string.Empty || txtsetor.Text == string.Empty || txtsenha.Text == string.Empty || txtconfsenha.Text == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtnome.Text, txtregistro.Text, txtsetor.Text, txtsenha.Text, txtconfsenha.Text, tipousercb.Text);

            if (IsValid())
            {
                if (controle.tem)//mensagem de sucesso
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listagem FrmMain = new Listagem();
                    FrmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(controle.mensagem);//mensagem de erro
                }
            }
        }

        private void btnolho1_MouseDown(object sender, MouseEventArgs e)
        {
            txtsenha.UseSystemPasswordChar = false;
        }

        private void btnolho1_MouseUp(object sender, MouseEventArgs e)
        {
            txtsenha.UseSystemPasswordChar = true;
        }

        private void btnolho2_MouseDown(object sender, MouseEventArgs e)
        {
            txtconfsenha.UseSystemPasswordChar = false;
        }

        private void btnolho2_MouseUp(object sender, MouseEventArgs e)
        {
            txtconfsenha.UseSystemPasswordChar = true;
        }

        private void txtregistro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sair_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(sair, "sair");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
