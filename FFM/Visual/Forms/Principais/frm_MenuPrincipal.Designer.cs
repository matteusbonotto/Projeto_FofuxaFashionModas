using System.Drawing;

namespace FFM.Visual.Forms.Principais
{
    partial class frm_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MenuPrincipal));
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.lblLicenca = new System.Windows.Forms.Label();
            this.lblDescricao_Licenca = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbllblDescricao_Autenticacao = new System.Windows.Forms.Label();
            this.lblAutenticacao = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Panel_Menus = new System.Windows.Forms.Panel();
            this.mnuUsuario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.mnuUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(93, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.HotPink;
            this.panelCabecalho.Controls.Add(this.pictureBox2);
            this.panelCabecalho.Controls.Add(this.lblLicenca);
            this.panelCabecalho.Controls.Add(this.lblDescricao_Licenca);
            this.panelCabecalho.Controls.Add(this.lblTitulo);
            this.panelCabecalho.Controls.Add(this.btnRestaurar);
            this.panelCabecalho.Controls.Add(this.btnMaximizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(152, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(764, 30);
            this.panelCabecalho.TabIndex = 6;
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mover_Tela_MouseMove);
            // 
            // lblLicenca
            // 
            this.lblLicenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLicenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenca.ForeColor = System.Drawing.Color.White;
            this.lblLicenca.Location = new System.Drawing.Point(524, 7);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(99, 19);
            this.lblLicenca.TabIndex = 2;
            this.lblLicenca.Text = "Visitante";
            this.lblLicenca.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mover_Tela_MouseMove);
            // 
            // lblDescricao_Licenca
            // 
            this.lblDescricao_Licenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescricao_Licenca.AutoSize = true;
            this.lblDescricao_Licenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao_Licenca.ForeColor = System.Drawing.Color.White;
            this.lblDescricao_Licenca.Location = new System.Drawing.Point(386, 6);
            this.lblDescricao_Licenca.Name = "lblDescricao_Licenca";
            this.lblDescricao_Licenca.Size = new System.Drawing.Size(142, 17);
            this.lblDescricao_Licenca.TabIndex = 3;
            this.lblDescricao_Licenca.Text = "Autenticado como:";
            this.lblDescricao_Licenca.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mover_Tela_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Purple;
            this.lblTitulo.Location = new System.Drawing.Point(6, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(59, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "MENU";
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mover_Tela_MouseMove);
            // 
            // lbllblDescricao_Autenticacao
            // 
            this.lbllblDescricao_Autenticacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllblDescricao_Autenticacao.AutoSize = true;
            this.lbllblDescricao_Autenticacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblDescricao_Autenticacao.ForeColor = System.Drawing.Color.White;
            this.lbllblDescricao_Autenticacao.Location = new System.Drawing.Point(31, 429);
            this.lbllblDescricao_Autenticacao.Name = "lbllblDescricao_Autenticacao";
            this.lbllblDescricao_Autenticacao.Size = new System.Drawing.Size(96, 17);
            this.lbllblDescricao_Autenticacao.TabIndex = 1;
            this.lbllblDescricao_Autenticacao.Text = "Bem vindo(a):";
            // 
            // lblAutenticacao
            // 
            this.lblAutenticacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutenticacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAutenticacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutenticacao.ForeColor = System.Drawing.Color.White;
            this.lblAutenticacao.Location = new System.Drawing.Point(9, 446);
            this.lblAutenticacao.Name = "lblAutenticacao";
            this.lblAutenticacao.Size = new System.Drawing.Size(133, 34);
            this.lblAutenticacao.TabIndex = 0;
            this.lblAutenticacao.Text = "Visitante";
            this.lblAutenticacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.btnEntrar);
            this.panelMenu.Controls.Add(this.Panel_Menus);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.lbllblDescricao_Autenticacao);
            this.panelMenu.Controls.Add(this.lblAutenticacao);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(152, 533);
            this.panelMenu.TabIndex = 7;
            // 
            // Panel_Menus
            // 
            this.Panel_Menus.Location = new System.Drawing.Point(0, 72);
            this.Panel_Menus.Name = "Panel_Menus";
            this.Panel_Menus.Size = new System.Drawing.Size(152, 354);
            this.Panel_Menus.TabIndex = 2;
            // 
            // mnuUsuario
            // 
            this.mnuUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSair});
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.Size = new System.Drawing.Size(94, 26);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConteudo.BackColor = System.Drawing.Color.White;
            this.panelConteudo.Location = new System.Drawing.Point(152, 29);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(764, 505);
            this.panelConteudo.TabIndex = 8;
            this.panelConteudo.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelConteudo_ControlAdded);
            this.panelConteudo.ParentChanged += new System.EventHandler(this.panelConteudo_ParentChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::FFM.Properties.Resources.icons8_usuário_homem_com_círculo_24__1_;
            this.pictureBox2.Location = new System.Drawing.Point(355, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(666, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(30, 30);
            this.btnRestaurar.TabIndex = 0;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(700, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.TabIndex = 0;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(734, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::FFM.Properties.Resources.icons8_sair_26;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 487);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(152, 47);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "        Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Visible = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Image = global::FFM.Properties.Resources.icons8_entrar_26;
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.Location = new System.Drawing.Point(0, 483);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(152, 47);
            this.btnEntrar.TabIndex = 16;
            this.btnEntrar.Text = "        Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mover_Tela_MouseMove);
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 533);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MenuPrincipal";
            this.Load += new System.EventHandler(this.frm_MenuPrincipal_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.mnuUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLicenca;
        private System.Windows.Forms.Label lblDescricao_Licenca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbllblDescricao_Autenticacao;
        private System.Windows.Forms.Label lblAutenticacao;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ContextMenuStrip mnuUsuario;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Panel Panel_Menus;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
    }
}