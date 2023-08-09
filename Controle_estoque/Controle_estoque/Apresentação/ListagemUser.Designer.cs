namespace Controle_estoque
{
    partial class ListagemUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListagemUser));
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sair = new System.Windows.Forms.Button();
            this.btnetiqueta = new System.Windows.Forms.Button();
            this.btncomprimir = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "produto";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioLogado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(220, 22);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(52, 18);
            this.lblUsuarioLogado.TabIndex = 104;
            this.lblUsuarioLogado.Text = "label1";
            this.lblUsuarioLogado.MouseHover += new System.EventHandler(this.lblUsuarioLogado_MouseHover);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 60);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1175, 425);
            this.listView1.TabIndex = 105;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Controle_estoque.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(59, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 111;
            this.pictureBox2.TabStop = false;
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.Crimson;
            this.sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sair.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.ForeColor = System.Drawing.Color.White;
            this.sair.Location = new System.Drawing.Point(12, 15);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(32, 33);
            this.sair.TabIndex = 110;
            this.sair.Text = "<";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            this.sair.MouseHover += new System.EventHandler(this.sair_MouseHover);
            // 
            // btnetiqueta
            // 
            this.btnetiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnetiqueta.BackColor = System.Drawing.Color.White;
            this.btnetiqueta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnetiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnetiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnetiqueta.ForeColor = System.Drawing.Color.Black;
            this.btnetiqueta.Location = new System.Drawing.Point(987, 10);
            this.btnetiqueta.Name = "btnetiqueta";
            this.btnetiqueta.Size = new System.Drawing.Size(102, 43);
            this.btnetiqueta.TabIndex = 109;
            this.btnetiqueta.Text = "|||||||||||";
            this.btnetiqueta.UseVisualStyleBackColor = false;
            this.btnetiqueta.Click += new System.EventHandler(this.btnetiqueta_Click);
            this.btnetiqueta.MouseHover += new System.EventHandler(this.btnetiqueta_MouseHover);
            // 
            // btncomprimir
            // 
            this.btncomprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncomprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(79)))));
            this.btncomprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncomprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncomprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.btncomprimir.ForeColor = System.Drawing.Color.White;
            this.btncomprimir.Location = new System.Drawing.Point(1096, 10);
            this.btncomprimir.Name = "btncomprimir";
            this.btncomprimir.Size = new System.Drawing.Size(92, 43);
            this.btncomprimir.TabIndex = 108;
            this.btncomprimir.Text = "Excel";
            this.btncomprimir.UseVisualStyleBackColor = false;
            this.btncomprimir.Click += new System.EventHandler(this.btncomprimir_Click);
            this.btncomprimir.MouseHover += new System.EventHandler(this.btncomprimir_MouseHover);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(858, 11);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 40);
            this.numericUpDown1.TabIndex = 147;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ListagemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1197, 507);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.btnetiqueta);
            this.Controls.Add(this.btncomprimir);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListagemUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de produto";
            this.Load += new System.EventHandler(this.ListagemUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdatualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailforDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private string usuarioLogado;

        public ListagemUser(string usuarioLogado)
        {
            this.usuarioLogado = usuarioLogado;
        }

        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button btnetiqueta;
        private System.Windows.Forms.Button btncomprimir;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
    }
}

