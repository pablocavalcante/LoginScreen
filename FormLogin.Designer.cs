namespace LoginScreen
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbOrgao = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picSenhaIcon = new System.Windows.Forms.PictureBox();
            this.picOrgaoIcon = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenhaIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrgaoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(48, 131);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ARCHON - Administração Pública";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(20, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 1);
            this.panel1.TabIndex = 3;
            // 
            // cmbOrgao
            // 
            this.cmbOrgao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrgao.FormattingEnabled = true;
            this.cmbOrgao.Location = new System.Drawing.Point(75, 288);
            this.cmbOrgao.Name = "cmbOrgao";
            this.cmbOrgao.Size = new System.Drawing.Size(188, 24);
            this.cmbOrgao.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(20, 337);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(243, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(75, 240);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(187, 24);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(74, 188);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(186, 24);
            this.txtUsername.TabIndex = 0;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(24, 376);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 16);
            this.lblErro.TabIndex = 8;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::LoginScreen.Properties.Resources.rh;
            this.picLogo.Location = new System.Drawing.Point(56, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(173, 106);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picUserIcon
            // 
            this.picUserIcon.Image = global::LoginScreen.Properties.Resources.user_color1;
            this.picUserIcon.Location = new System.Drawing.Point(18, 173);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(50, 41);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserIcon.TabIndex = 9;
            this.picUserIcon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(20, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 1);
            this.panel2.TabIndex = 3;
            // 
            // picSenhaIcon
            // 
            this.picSenhaIcon.Image = global::LoginScreen.Properties.Resources.seg_color;
            this.picSenhaIcon.Location = new System.Drawing.Point(20, 227);
            this.picSenhaIcon.Name = "picSenhaIcon";
            this.picSenhaIcon.Size = new System.Drawing.Size(50, 41);
            this.picSenhaIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSenhaIcon.TabIndex = 9;
            this.picSenhaIcon.TabStop = false;
            // 
            // picOrgaoIcon
            // 
            this.picOrgaoIcon.Image = global::LoginScreen.Properties.Resources.company_color;
            this.picOrgaoIcon.Location = new System.Drawing.Point(19, 277);
            this.picOrgaoIcon.Name = "picOrgaoIcon";
            this.picOrgaoIcon.Size = new System.Drawing.Size(50, 41);
            this.picOrgaoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrgaoIcon.TabIndex = 9;
            this.picOrgaoIcon.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 447);
            this.Controls.Add(this.picOrgaoIcon);
            this.Controls.Add(this.picSenhaIcon);
            this.Controls.Add(this.picUserIcon);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbOrgao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificação";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenhaIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrgaoIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbOrgao;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picSenhaIcon;
        private System.Windows.Forms.PictureBox picOrgaoIcon;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

