namespace Controle_estoque
{
    partial class CadUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadUser));
            this.txtsetor = new System.Windows.Forms.TextBox();
            this.labelsetor = new System.Windows.Forms.Label();
            this.txtregistro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtconfsenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnolho2 = new System.Windows.Forms.PictureBox();
            this.btnolho1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sair = new System.Windows.Forms.Button();
            this.tipousercb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnolho2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnolho1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsetor
            // 
            this.txtsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsetor.Location = new System.Drawing.Point(323, 162);
            this.txtsetor.Name = "txtsetor";
            this.txtsetor.Size = new System.Drawing.Size(238, 26);
            this.txtsetor.TabIndex = 30;
            // 
            // labelsetor
            // 
            this.labelsetor.AutoSize = true;
            this.labelsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.labelsetor.Location = new System.Drawing.Point(319, 139);
            this.labelsetor.Name = "labelsetor";
            this.labelsetor.Size = new System.Drawing.Size(54, 20);
            this.labelsetor.TabIndex = 29;
            this.labelsetor.Text = "Setor";
            // 
            // txtregistro
            // 
            this.txtregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregistro.Location = new System.Drawing.Point(59, 162);
            this.txtregistro.Name = "txtregistro";
            this.txtregistro.Size = new System.Drawing.Size(244, 26);
            this.txtregistro.TabIndex = 26;
            this.txtregistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtregistro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(55, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Registro";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(64)))), ((int)(((byte)(23)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(456, 363);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(105, 33);
            this.btnlogin.TabIndex = 24;
            this.btnlogin.Text = "Cadatrar";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(59, 214);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(502, 26);
            this.txtsenha.TabIndex = 23;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblsenha.Location = new System.Drawing.Point(55, 191);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(61, 20);
            this.lblsenha.TabIndex = 22;
            this.lblsenha.Text = "Senha";
            // 
            // txtconfsenha
            // 
            this.txtconfsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfsenha.Location = new System.Drawing.Point(59, 269);
            this.txtconfsenha.Name = "txtconfsenha";
            this.txtconfsenha.Size = new System.Drawing.Size(502, 26);
            this.txtconfsenha.TabIndex = 32;
            this.txtconfsenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Confirmar senha";
            // 
            // btnolho2
            // 
            this.btnolho2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnolho2.Image = global::Controle_estoque.Properties.Resources._3;
            this.btnolho2.Location = new System.Drawing.Point(537, 271);
            this.btnolho2.Name = "btnolho2";
            this.btnolho2.Size = new System.Drawing.Size(21, 20);
            this.btnolho2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnolho2.TabIndex = 34;
            this.btnolho2.TabStop = false;
            this.btnolho2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnolho2_MouseDown);
            this.btnolho2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnolho2_MouseUp);
            // 
            // btnolho1
            // 
            this.btnolho1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnolho1.Image = global::Controle_estoque.Properties.Resources._3;
            this.btnolho1.Location = new System.Drawing.Point(537, 217);
            this.btnolho1.Name = "btnolho1";
            this.btnolho1.Size = new System.Drawing.Size(21, 20);
            this.btnolho1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnolho1.TabIndex = 35;
            this.btnolho1.TabStop = false;
            this.btnolho1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnolho1_MouseDown);
            this.btnolho1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnolho1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Controle_estoque.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(59, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
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
            this.sair.TabIndex = 87;
            this.sair.Text = "<";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            this.sair.MouseHover += new System.EventHandler(this.sair_MouseHover);
            // 
            // tipousercb
            // 
            this.tipousercb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tipousercb.FormattingEnabled = true;
            this.tipousercb.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.tipousercb.Location = new System.Drawing.Point(59, 325);
            this.tipousercb.Name = "tipousercb";
            this.tipousercb.Size = new System.Drawing.Size(502, 28);
            this.tipousercb.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(55, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(59, 108);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(502, 26);
            this.txtnome.TabIndex = 28;
            this.txtnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnome_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(55, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Tipo de Usuario";
            // 
            // CadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(621, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tipousercb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.btnolho1);
            this.Controls.Add(this.btnolho2);
            this.Controls.Add(this.txtconfsenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsetor);
            this.Controls.Add(this.labelsetor);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtregistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.lblsenha);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuário";
            ((System.ComponentModel.ISupportInitialize)(this.btnolho2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnolho1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsetor;
        private System.Windows.Forms.Label labelsetor;
        private System.Windows.Forms.TextBox txtregistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtconfsenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnolho2;
        private System.Windows.Forms.PictureBox btnolho1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.ComboBox tipousercb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label4;
    }
}