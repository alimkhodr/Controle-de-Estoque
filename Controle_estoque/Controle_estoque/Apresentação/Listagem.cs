using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using RawDataPrint;
using System.Drawing;
using Controle_estoque.Apresentação;
using System.Diagnostics;
using System.Security.Principal;
using static Controle_estoque.Program;

namespace Controle_estoque
{
    public partial class Listagem : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=10.251.24.11;Initial Catalog=TESTE1;Persist Security Info=True;User ID=sa;Password=P@ssw0rd");
        public Listagem()
        {
            InitializeComponent();
            list();
        }

        private void Listagem_Load(object sender, EventArgs e)
        {
            // Exibir o nome de usuário logado em um label ou outro controle
            lblUsuarioLogado.Text = "Usuário: " + Login.UsuarioLogado.Registro;
        }

        // Edição do usuario
        private void lblUsuarioLogado_Click(object sender, EventArgs e)
        {
            EditUser FrmMain = new EditUser();
            FrmMain.Show();
            this.Hide();
        }

        //Listagem do produto no listview
        public void list()
        {
            int cont = 0;
            while (cont <= 24)
            {
                cont = cont + 1;
            }

            SqlDataReader dataReader;
            SqlCommand comandosql = con.CreateCommand();
            listView1.Clear();
            con.Open();
            comandosql.CommandText = "SELECT * FROM produto";
            dataReader = comandosql.ExecuteReader();

            listView1.View = View.Details;
            listView1.Columns.Add("", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("ID", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Nome", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("Descrição", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("Validade", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("Setor", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("Qtd. Mín", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Qtd. Max", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Qtd. Atual", 70, HorizontalAlignment.Center);
            listView1.Columns.Add("Email Fornecedor", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("Email Comprador", 130, HorizontalAlignment.Center);
            listView1.Columns.Add("Data Cadastro", 130, HorizontalAlignment.Center);
            cont = 0;
            while (dataReader.Read())
            {
                ListViewItem ls = new ListViewItem("", 0);
                ls.SubItems.Add(dataReader["id"].ToString());
                ls.SubItems.Add(dataReader["nome"].ToString());
                ls.SubItems.Add(dataReader["descricao"].ToString());
                ls.SubItems.Add(dataReader["validade"].ToString());
                ls.SubItems.Add(dataReader["setor"].ToString());
                ls.SubItems.Add(dataReader["qtdmin"].ToString());
                ls.SubItems.Add(dataReader["qtdmax"].ToString());
                ls.SubItems.Add(dataReader["qtdatual"].ToString());
                ls.SubItems.Add(dataReader["emailfor"].ToString());
                ls.SubItems.Add(dataReader["emailcom"].ToString());
                ls.SubItems.Add(dataReader["data"].ToString());
                listView1.Items.Add(ls);

                DateTime dataAtual = DateTime.Now;
                listView1.Items[cont].UseItemStyleForSubItems = false;
                foreach (ListViewItem row in listView1.Items)
                {
                    DateTime validade = DateTime.Parse(row.SubItems[4].Text);

                    if (validade < dataAtual)
                    {
                        // Se a validade for menor que a data atual, pintar a célula de vermelho
                        row.SubItems[4].BackColor = Color.Red;
                    }
                }

                foreach (ListViewItem row in listView1.Items)
                {
                    float qtdmin = float.Parse(row.SubItems[6].Text);
                    float qtdmax = float.Parse(row.SubItems[7].Text);
                    float qtdatual = float.Parse(row.SubItems[8].Text);

                    if (qtdatual < qtdmin || qtdatual > qtdmax)
                    {
                        // Se a quantidade atual estiver fora dos limites, pintar a célula de vermelho
                        row.SubItems[8].BackColor = Color.Red;
                    }
                    else if (qtdatual == qtdmin || qtdatual == qtdmax)
                    {
                        // Se a quantidade atual estiver igual a um dos limites, pintar a célula de amarelo
                        row.SubItems[8].BackColor = Color.Gold;
                    }
                }
                cont = cont + 1;
            }
            con.Close();
            dataReader.Close();
            comandosql.Dispose();
        }

        //Escolhe uma linha para excluir ou gerar etiqueta
        private void listView1_Click(object sender, EventArgs e)
        {
            Variaveis.id_produto = Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text);

        }

        //Mnada para página de edição de produto da linha selecionada
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Variaveis.id_produto = Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text);
                EditProd FrmMain = new EditProd();
                this.Hide();
                FrmMain.Show();
            }
        }

        //Mnada para página de cadastro de produto
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            CadProd FrmMain = new CadProd();
            FrmMain.Show();
            this.Hide();
        }

        //Excluir produto
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (Variaveis.id_produto > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o produto?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM produto WHERE id = @id;", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", Variaveis.id_produto);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Excluído com sucesso!", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto", "Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Etiqueta do produto
        private void btnetiqueta_Click(object sender, EventArgs e)
        {
            if (Variaveis.id_produto > 0)
            {
                // Verifica se os firewalls estão desativados
                bool isPublicFirewallDisabled = IsFirewallDisabled("public");
                bool isDomainFirewallDisabled = IsFirewallDisabled("domain");

                if (isPublicFirewallDisabled && isDomainFirewallDisabled)
                {
                    etiqueta();
                }
                else
                {
                    // Verifica se o usuário possui privilégios administrativos
                    if (!IsUserAdministrator())
                    {
                        MessageBox.Show("Este programa requer privilégios administrativos para desativar os firewalls.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Desativa os firewalls
                    if (!isPublicFirewallDisabled)
                        DisableFirewall("public");

                    if (!isDomainFirewallDisabled)
                        DisableFirewall("domain");

                    etiqueta();
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static bool IsUserAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        static bool IsFirewallDisabled(string profile)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "netsh";
            startInfo.Arguments = $"advfirewall show {profile}profile state";
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return output.Contains("State: OFF");
            }
        }

        static void DisableFirewall(string profile)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "netsh";
            startInfo.Arguments = $"advfirewall set {profile}profile state off";
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
        }

        private void etiqueta()
        {
            Console.ReadLine();
            SqlCommand cmd = new SqlCommand("SELECT nome, setor, data, qtdmin, qtdmax, qtdatual FROM produto WHERE id = @id;", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", Variaveis.id_produto);

            con.Open();

            SqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();

            string dadosImpressao = "^XA";
            dadosImpressao += "^MMT";
            dadosImpressao += "^PW1063";
            dadosImpressao += "^LL0827";
            dadosImpressao += "^LS0";
            dadosImpressao += @"^FT42,288^A0N,42,40^FH\^FDAPTIV - JAMBEIRO^FS";
            dadosImpressao += "^BY6,3,132^FT259,681^BCN,,Y,N";
            dadosImpressao += "^FD>:" + Variaveis.id_produto + "^FS";
            dadosImpressao += @"^FT494,369^A0N,29,28^FH\^FD" + dataReader["qtdmin"].ToString() + "^FS";
            dadosImpressao += @"^FT452,333^A0N,29,28^FH\^FD" + dataReader["data"].ToString() + "^FS";
            dadosImpressao += @"^FT162,368^A0N,29,28^FH\^FD" + dataReader["qtdmax"].ToString() + "^FS";
            dadosImpressao += @"^FT377,370^A0N,29,28^FH\^FDQTD MIN:^FS";
            dadosImpressao += @"^FT378,332^A0N,29,28^FH\^FDDATA:^FS";
            dadosImpressao += @"^FT40,368^A0N,29,28^FH\^FDQTD MAX:^FS";
            dadosImpressao += @"^FT123,332^A0N,29,28^FH\^FD" + dataReader["nome"].ToString() + "^FS";
            dadosImpressao += @"^FT41,334^A0N,29,28^FH\^FDNOME:^FS";
            dadosImpressao += "^PQ1,0,1,Y^XZ";

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtém a impressora selecionada pelo usuário
                string printerName = printDialog.PrinterSettings.PrinterName;

                // Imprime na impressora selecionada
                if (RawPrinterHelper.SendStringToPrinter(printerName, dadosImpressao))
                {
                    MessageBox.Show("Etiqueta gerada com sucesso!", "Etiqueta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao imprimir etiqueta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
            dataReader.Close();
            cmd.Dispose();
        }

        //Comprimir para excel
        private void ExportToExcel()
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No data to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                int headerIndex = 1;
                foreach (ColumnHeader column in listView1.Columns)
                {
                    worksheet.Cells[1, headerIndex] = column.Text;
                    headerIndex++;
                }
                int rowIndex = 2;
                foreach (ListViewItem item in listView1.Items)
                {
                    int columnIndex = 1;
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        worksheet.Cells[rowIndex, columnIndex] = subItem.Text;
                        columnIndex++;
                    }
                    rowIndex++;
                }
                worksheet.UsedRange.Columns.AutoFit();
                string filePath = "Controle_Estoque  " + DateTime.Now.ToString("yyyy-MM-dd HH-mm") + ".xlsx";
                workbook.SaveAs(filePath);
                MessageBox.Show("Documento gerado na pasta Documentos", "Document", MessageBoxButtons.OK, MessageBoxIcon.Information);
                workbook.Close();
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while exporting the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Comprime a tabela produto para o excel
        private void btncomprimir_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        //Volta para a tela de login
        private void sair_Click(object sender, EventArgs e)
        {
            Login FrmMain = new Login();
            FrmMain.Show();
            this.Hide();
        }

        //Cadastro de usuario
        private void button1_Click(object sender, EventArgs e)
        {
            CadUser FrmMain = new CadUser();
            FrmMain.Show();
            this.Hide();
        }

        //Cadastro de produto
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CadProd FrmMain = new CadProd();
            FrmMain.Show();
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button1, "Cadastrar Usuário");
        }

        private void btnetiqueta_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnetiqueta, "Gerar Etiqueta");
        }

        private void btncomprimir_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btncomprimir, "Gerar Excel");
        }

        private void btncadastrar_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btncadastrar, "Cadastrar Produto");
        }

        private void btnexcluir_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnexcluir, "Exluir Produto");
        }

        private void sair_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(sair, "Sair");
        }

        private void lblUsuarioLogado_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(lblUsuarioLogado, "Editar usuário");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            list();
        }

        private void Listagem_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            CadProd FrmMain = new CadProd();
            FrmMain.Show();
            this.Hide();
        }
    }
}