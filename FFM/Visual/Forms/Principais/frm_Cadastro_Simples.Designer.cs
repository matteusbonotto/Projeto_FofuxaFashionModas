namespace FFM.Visual.Forms.Principais
{
    partial class frm_Cadastro_Simples
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
            this.grdListar_Cadastro_Simples = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnListar_Produtos = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.grdListar_Cadastro_Simples)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListar_Cadastro_Simples
            // 
            this.grdListar_Cadastro_Simples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdListar_Cadastro_Simples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListar_Cadastro_Simples.Location = new System.Drawing.Point(175, 117);
            this.grdListar_Cadastro_Simples.Name = "grdListar_Cadastro_Simples";
            this.grdListar_Cadastro_Simples.Size = new System.Drawing.Size(260, 158);
            this.grdListar_Cadastro_Simples.TabIndex = 134;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(172, 24);
            this.lblTitulo.TabIndex = 133;
            this.lblTitulo.Text = "Cadastro Simples";
            // 
            // btnListar_Produtos
            // 
            this.btnListar_Produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnListar_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar_Produtos.ForeColor = System.Drawing.Color.Purple;
            this.btnListar_Produtos.Location = new System.Drawing.Point(14, 171);
            this.btnListar_Produtos.Name = "btnListar_Produtos";
            this.btnListar_Produtos.Size = new System.Drawing.Size(138, 38);
            this.btnListar_Produtos.TabIndex = 132;
            this.btnListar_Produtos.Text = "Listar ";
            this.btnListar_Produtos.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Purple;
            this.btnVoltar.Location = new System.Drawing.Point(16, 237);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(138, 38);
            this.btnVoltar.TabIndex = 131;
            this.btnVoltar.Text = "Fechar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.ForeColor = System.Drawing.Color.Purple;
            this.btnExcluirProduto.Location = new System.Drawing.Point(14, 127);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(138, 38);
            this.btnExcluirProduto.TabIndex = 130;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.ForeColor = System.Drawing.Color.Purple;
            this.btnEditarProduto.Location = new System.Drawing.Point(14, 83);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(138, 38);
            this.btnEditarProduto.TabIndex = 129;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.Purple;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(14, 39);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(138, 38);
            this.btnCadastrarProduto.TabIndex = 128;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Departamento",
            "Licença",
            "Categoria"});
            this.comboBox1.Location = new System.Drawing.Point(251, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 127;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 126;
            this.label3.Text = "Cadastrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 125;
            this.label2.Text = "Descrição";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsuario.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtUsuario.LineIdleColor = System.Drawing.Color.Purple;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtUsuario.LineThickness = 2;
            this.txtUsuario.Location = new System.Drawing.Point(251, 82);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(184, 27);
            this.txtUsuario.TabIndex = 124;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frm_Cadastro_Simples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 287);
            this.Controls.Add(this.grdListar_Cadastro_Simples);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnListar_Produtos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Name = "frm_Cadastro_Simples";
            this.Text = "frm_Cadastro_Simples";
            ((System.ComponentModel.ISupportInitialize)(this.grdListar_Cadastro_Simples)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdListar_Cadastro_Simples;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnListar_Produtos;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
    }
}