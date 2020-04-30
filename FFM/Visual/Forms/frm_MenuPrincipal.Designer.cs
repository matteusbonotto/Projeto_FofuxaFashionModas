namespace FFM.Visual.Forms
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLicenca = new System.Windows.Forms.Label();
            this.lblDescricao_Licenca = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbllblDescricao_Autenticacao = new System.Windows.Forms.Label();
            this.lblAutenticacao = new System.Windows.Forms.Label();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.mnuUsuario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.mnuUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(93, 22);
            this.mnuSair.Text = "Sair";
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
            this.panelCabecalho.Size = new System.Drawing.Size(648, 40);
            this.panelCabecalho.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(241, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblLicenca
            // 
            this.lblLicenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLicenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenca.ForeColor = System.Drawing.Color.White;
            this.lblLicenca.Location = new System.Drawing.Point(407, 12);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(99, 19);
            this.lblLicenca.TabIndex = 2;
            this.lblLicenca.Text = "...";
            // 
            // lblDescricao_Licenca
            // 
            this.lblDescricao_Licenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescricao_Licenca.AutoSize = true;
            this.lblDescricao_Licenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao_Licenca.ForeColor = System.Drawing.Color.White;
            this.lblDescricao_Licenca.Location = new System.Drawing.Point(270, 12);
            this.lblDescricao_Licenca.Name = "lblDescricao_Licenca";
            this.lblDescricao_Licenca.Size = new System.Drawing.Size(142, 17);
            this.lblDescricao_Licenca.TabIndex = 3;
            this.lblDescricao_Licenca.Text = "Autenticado como:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Purple;
            this.lblTitulo.Location = new System.Drawing.Point(2, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(76, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "MENU";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(513, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 34);
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
            this.btnMaximizar.Location = new System.Drawing.Point(559, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 34);
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
            this.btnFechar.Location = new System.Drawing.Point(605, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 34);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "        Relatórios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbllblDescricao_Autenticacao
            // 
            this.lbllblDescricao_Autenticacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllblDescricao_Autenticacao.AutoSize = true;
            this.lbllblDescricao_Autenticacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblDescricao_Autenticacao.ForeColor = System.Drawing.Color.White;
            this.lbllblDescricao_Autenticacao.Location = new System.Drawing.Point(28, 395);
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
            this.lblAutenticacao.Location = new System.Drawing.Point(9, 412);
            this.lblAutenticacao.Name = "lblAutenticacao";
            this.lblAutenticacao.Size = new System.Drawing.Size(133, 34);
            this.lblAutenticacao.TabIndex = 0;
            this.lblAutenticacao.Text = "...";
            this.lblAutenticacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnProdutos
            // 
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(3, 129);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(146, 39);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "   Estoque";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(3, 174);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(146, 39);
            this.btnCompras.TabIndex = 0;
            this.btnCompras.Text = "    Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(3, 84);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(146, 39);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "    Produtos";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.lbllblDescricao_Autenticacao);
            this.panelMenu.Controls.Add(this.lblAutenticacao);
            this.panelMenu.Controls.Add(this.btnProdutos);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(152, 450);
            this.panelMenu.TabIndex = 7;
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
            this.panelConteudo.BackColor = System.Drawing.Color.White;
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(800, 450);
            this.panelConteudo.TabIndex = 8;
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MenuPrincipal";
            this.Text = "frm_MenuPrincipal";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.mnuUsuario.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbllblDescricao_Autenticacao;
        private System.Windows.Forms.Label lblAutenticacao;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ContextMenuStrip mnuUsuario;
        private System.Windows.Forms.Panel panelConteudo;
    }
}