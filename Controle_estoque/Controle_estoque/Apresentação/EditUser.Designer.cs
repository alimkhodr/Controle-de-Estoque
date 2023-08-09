namespace Controle_estoque.Apresentação
{
    partial class EditUser
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sair = new System.Windows.Forms.Button();
            this.btnolho2 = new System.Windows.Forms.PictureBox();
            this.txtnovasenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsetor = new System.Windows.Forms.TextBox();
            this.labelsetor = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtconfnovasenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnolho2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Controle_estoque.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(59, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 107;
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
            this.sair.TabIndex = 105;
            this.sair.Text = "<";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            this.sair.MouseHover += new System.EventHandler(this.sair_MouseHover);
            // 
            // btnolho2
            // 
            this.btnolho2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnolho2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnolho2.Image = global::Controle_estoque.Properties.Resources._3;
            this.btnolho2.Location = new System.Drawing.Point(537, 248);
            this.btnolho2.Name = "btnolho2";
            this.btnolho2.Size = new System.Drawing.Size(21, 20);
            this.btnolho2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnolho2.TabIndex = 108;
            this.btnolho2.TabStop = false;
            this.btnolho2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnolho2_MouseDown);
            this.btnolho2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnolho2_MouseUp);
            // 
            // txtnovasenha
            // 
            this.txtnovasenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnovasenha.Location = new System.Drawing.Point(59, 245);
            this.txtnovasenha.Name = "txtnovasenha";
            this.txtnovasenha.Size = new System.Drawing.Size(502, 26);
            this.txtnovasenha.TabIndex = 101;
            this.txtnovasenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(55, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 109;
            this.label1.Text = "Nova senha";
            // 
            // txtsetor
            // 
            this.txtsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsetor.Location = new System.Drawing.Point(59, 190);
            this.txtsetor.Name = "txtsetor";
            this.txtsetor.Size = new System.Drawing.Size(502, 26);
            this.txtsetor.TabIndex = 98;
            // 
            // labelsetor
            // 
            this.labelsetor.AutoSize = true;
            this.labelsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.labelsetor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelsetor.Location = new System.Drawing.Point(55, 167);
            this.labelsetor.Name = "labelsetor";
            this.labelsetor.Size = new System.Drawing.Size(54, 20);
            this.labelsetor.TabIndex = 110;
            this.labelsetor.Text = "Setor";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(59, 136);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(502, 26);
            this.txtnome.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(55, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Nome";
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Location = new System.Drawing.Point(455, 340);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(106, 33);
            this.btnsalvar.TabIndex = 104;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            this.btnsalvar.MouseHover += new System.EventHandler(this.btnsalvar_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Controle_estoque.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(537, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // txtconfnovasenha
            // 
            this.txtconfnovasenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfnovasenha.Location = new System.Drawing.Point(59, 302);
            this.txtconfnovasenha.Name = "txtconfnovasenha";
            this.txtconfnovasenha.Size = new System.Drawing.Size(502, 26);
            this.txtconfnovasenha.TabIndex = 103;
            this.txtconfnovasenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(55, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Confirme Nova senha";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(621, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtconfnovasenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.btnolho2);
            this.Controls.Add(this.txtnovasenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsetor);
            this.Controls.Add(this.labelsetor);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsalvar);
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnolho2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.PictureBox btnolho2;
        private System.Windows.Forms.TextBox txtnovasenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsetor;
        private System.Windows.Forms.Label labelsetor;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtconfnovasenha;
        private System.Windows.Forms.Label label4;
    }
}