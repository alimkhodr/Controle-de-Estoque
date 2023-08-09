namespace Controle_estoque.Apresentação
{
    partial class CadProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProd));
            this.sair = new System.Windows.Forms.Button();
            this.txtsetor = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemailcom = new System.Windows.Forms.TextBox();
            this.txtemailfor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtqtdatual = new System.Windows.Forms.NumericUpDown();
            this.txtqtdmax = new System.Windows.Forms.NumericUpDown();
            this.txtvalidade = new System.Windows.Forms.DateTimePicker();
            this.txtqtdmin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtdatual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtdmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.Color.Crimson;
            this.sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sair.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.ForeColor = System.Drawing.Color.White;
            this.sair.Location = new System.Drawing.Point(12, 12);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(32, 33);
            this.sair.TabIndex = 103;
            this.sair.Text = "<";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            this.sair.MouseHover += new System.EventHandler(this.sair_MouseHover);
            // 
            // txtsetor
            // 
            this.txtsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsetor.Location = new System.Drawing.Point(309, 181);
            this.txtsetor.MaxLength = 40;
            this.txtsetor.Name = "txtsetor";
            this.txtsetor.Size = new System.Drawing.Size(252, 26);
            this.txtsetor.TabIndex = 112;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(59, 130);
            this.txtdescricao.MaxLength = 40;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(502, 26);
            this.txtdescricao.TabIndex = 110;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(59, 79);
            this.txtnome.MaxLength = 40;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(502, 26);
            this.txtnome.TabIndex = 109;
            this.txtnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnome_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(306, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 108;
            this.label10.Text = "Setor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(56, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 107;
            this.label5.Text = "Validade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(56, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 106;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(57, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 105;
            this.label2.Text = "Nome";
            // 
            // txtemailcom
            // 
            this.txtemailcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailcom.Location = new System.Drawing.Point(59, 337);
            this.txtemailcom.MaxLength = 40;
            this.txtemailcom.Name = "txtemailcom";
            this.txtemailcom.Size = new System.Drawing.Size(502, 26);
            this.txtemailcom.TabIndex = 122;
            // 
            // txtemailfor
            // 
            this.txtemailfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailfor.Location = new System.Drawing.Point(59, 286);
            this.txtemailfor.MaxLength = 40;
            this.txtemailfor.Name = "txtemailfor";
            this.txtemailfor.Size = new System.Drawing.Size(502, 26);
            this.txtemailfor.TabIndex = 121;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(56, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 18);
            this.label11.TabIndex = 117;
            this.label11.Text = "Email Comprador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(56, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 18);
            this.label6.TabIndex = 116;
            this.label6.Text = "Email Fornecedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(401, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 115;
            this.label7.Text = "Qtd Atual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(229, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 114;
            this.label8.Text = "Qtd Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(56, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 113;
            this.label9.Text = "Qtd Min";
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btncadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.btncadastrar.ForeColor = System.Drawing.Color.White;
            this.btncadastrar.Location = new System.Drawing.Point(460, 372);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(101, 33);
            this.btncadastrar.TabIndex = 123;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Controle_estoque.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(59, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 104;
            this.pictureBox2.TabStop = false;
            // 
            // txtqtdatual
            // 
            this.txtqtdatual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtqtdatual.Location = new System.Drawing.Point(403, 235);
            this.txtqtdatual.Name = "txtqtdatual";
            this.txtqtdatual.Size = new System.Drawing.Size(158, 26);
            this.txtqtdatual.TabIndex = 151;
            // 
            // txtqtdmax
            // 
            this.txtqtdmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtqtdmax.Location = new System.Drawing.Point(232, 235);
            this.txtqtdmax.Name = "txtqtdmax";
            this.txtqtdmax.Size = new System.Drawing.Size(158, 26);
            this.txtqtdmax.TabIndex = 150;
            // 
            // txtvalidade
            // 
            this.txtvalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtvalidade.Location = new System.Drawing.Point(59, 181);
            this.txtvalidade.Name = "txtvalidade";
            this.txtvalidade.Size = new System.Drawing.Size(237, 26);
            this.txtvalidade.TabIndex = 152;
            // 
            // txtqtdmin
            // 
            this.txtqtdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtqtdmin.Location = new System.Drawing.Point(59, 235);
            this.txtqtdmin.Name = "txtqtdmin";
            this.txtqtdmin.Size = new System.Drawing.Size(158, 26);
            this.txtqtdmin.TabIndex = 149;
            // 
            // CadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(617, 445);
            this.Controls.Add(this.txtvalidade);
            this.Controls.Add(this.txtqtdatual);
            this.Controls.Add(this.txtqtdmax);
            this.Controls.Add(this.txtqtdmin);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtemailcom);
            this.Controls.Add(this.txtemailfor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsetor);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadProd";
            this.Load += new System.EventHandler(this.CadProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtdatual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtdmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox txtsetor;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemailcom;
        private System.Windows.Forms.TextBox txtemailfor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.NumericUpDown txtqtdatual;
        private System.Windows.Forms.NumericUpDown txtqtdmax;
        private System.Windows.Forms.DateTimePicker txtvalidade;
        private System.Windows.Forms.NumericUpDown txtqtdmin;
    }
}