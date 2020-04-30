namespace FFM.Visual.Forms
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.FrmLoginBody = new System.Windows.Forms.Panel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnEsqueciSenha = new System.Windows.Forms.Label();
            this.imgLogoLogin = new System.Windows.Forms.PictureBox();
            this.imgUsuarioLogin = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FrmLoginBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuarioLogin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrmLoginBody
            // 
            this.FrmLoginBody.BackColor = System.Drawing.Color.White;
            this.FrmLoginBody.Controls.Add(this.txtSenha);
            this.FrmLoginBody.Controls.Add(this.txtUsuario);
            this.FrmLoginBody.Controls.Add(this.imgUsuarioLogin);
            this.FrmLoginBody.Controls.Add(this.imgLogoLogin);
            this.FrmLoginBody.Controls.Add(this.btnEsqueciSenha);
            this.FrmLoginBody.Controls.Add(this.lblUsuario);
            this.FrmLoginBody.Controls.Add(this.btnEntrar);
            this.FrmLoginBody.Controls.Add(this.lblSenha);
            this.FrmLoginBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrmLoginBody.Location = new System.Drawing.Point(0, 0);
            this.FrmLoginBody.Name = "FrmLoginBody";
            this.FrmLoginBody.Size = new System.Drawing.Size(305, 401);
            this.FrmLoginBody.TabIndex = 16;
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(127, 222);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 18);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEntrar.BackColor = System.Drawing.Color.HotPink;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.Color.Purple;
            this.btnEntrar.Location = new System.Drawing.Point(46, 306);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(208, 31);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(121, 162);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 18);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // btnEsqueciSenha
            // 
            this.btnEsqueciSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEsqueciSenha.AutoSize = true;
            this.btnEsqueciSenha.BackColor = System.Drawing.Color.White;
            this.btnEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqueciSenha.ForeColor = System.Drawing.Color.Navy;
            this.btnEsqueciSenha.Location = new System.Drawing.Point(75, 344);
            this.btnEsqueciSenha.Name = "btnEsqueciSenha";
            this.btnEsqueciSenha.Size = new System.Drawing.Size(149, 18);
            this.btnEsqueciSenha.TabIndex = 10;
            this.btnEsqueciSenha.Text = "Esqueci minha senha";
            // 
            // imgLogoLogin
            // 
            this.imgLogoLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgLogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoLogin.Image")));
            this.imgLogoLogin.Location = new System.Drawing.Point(60, 8);
            this.imgLogoLogin.Name = "imgLogoLogin";
            this.imgLogoLogin.Size = new System.Drawing.Size(182, 87);
            this.imgLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoLogin.TabIndex = 0;
            this.imgLogoLogin.TabStop = false;
            // 
            // imgUsuarioLogin
            // 
            this.imgUsuarioLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgUsuarioLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgUsuarioLogin.Image")));
            this.imgUsuarioLogin.Location = new System.Drawing.Point(123, 81);
            this.imgUsuarioLogin.Name = "imgUsuarioLogin";
            this.imgUsuarioLogin.Size = new System.Drawing.Size(64, 61);
            this.imgUsuarioLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUsuarioLogin.TabIndex = 9;
            this.imgUsuarioLogin.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsuario.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtUsuario.LineIdleColor = System.Drawing.Color.Purple;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtUsuario.LineThickness = 2;
            this.txtUsuario.Location = new System.Drawing.Point(46, 185);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(208, 28);
            this.txtUsuario.TabIndex = 11;
            this.txtUsuario.Text = "USUÁRIO";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSenha.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.HintForeColor = System.Drawing.Color.Empty;
            this.txtSenha.HintText = "";
            this.txtSenha.isPassword = false;
            this.txtSenha.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtSenha.LineIdleColor = System.Drawing.Color.Purple;
            this.txtSenha.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtSenha.LineThickness = 2;
            this.txtSenha.Location = new System.Drawing.Point(47, 246);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(208, 28);
            this.txtSenha.TabIndex = 12;
            this.txtSenha.Text = "USUÁRIO";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FrmLoginBody);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 401);
            this.panel1.TabIndex = 3;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 401);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.Text = "frm_Login";
            this.FrmLoginBody.ResumeLayout(false);
            this.FrmLoginBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuarioLogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FrmLoginBody;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private System.Windows.Forms.PictureBox imgUsuarioLogin;
        private System.Windows.Forms.PictureBox imgLogoLogin;
        private System.Windows.Forms.Label btnEsqueciSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel panel1;
    }
}