namespace FFM.Visual.Ucs.Cadastros
{
    partial class uc_Cadastro_Produtos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo_Listagem = new System.Windows.Forms.Label();
            this.txtDescricao_Produto = new System.Windows.Forms.RichTextBox();
            this.lblDescricao_Produto = new System.Windows.Forms.Label();
            this.btnListar_Produtos = new System.Windows.Forms.Button();
            this.pnl_Listar_Produtos = new System.Windows.Forms.Panel();
            this.cboTamanho = new System.Windows.Forms.ComboBox();
            this.txtCompra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCodigo_Barras = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblCodigo_Barras = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.txtVenda = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPesquisarImagem = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtNomeArquivo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblNome_Arquivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.txtQuantidade = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNomeProduto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblPreco_Produto = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblQtdProduto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo_Listagem
            // 
            this.lblTitulo_Listagem.AutoSize = true;
            this.lblTitulo_Listagem.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo_Listagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo_Listagem.Location = new System.Drawing.Point(13, 306);
            this.lblTitulo_Listagem.Name = "lblTitulo_Listagem";
            this.lblTitulo_Listagem.Size = new System.Drawing.Size(207, 23);
            this.lblTitulo_Listagem.TabIndex = 115;
            this.lblTitulo_Listagem.Text = "Listagem de Produtos";
            // 
            // txtDescricao_Produto
            // 
            this.txtDescricao_Produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao_Produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao_Produto.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDescricao_Produto.Location = new System.Drawing.Point(255, 250);
            this.txtDescricao_Produto.Name = "txtDescricao_Produto";
            this.txtDescricao_Produto.Size = new System.Drawing.Size(444, 77);
            this.txtDescricao_Produto.TabIndex = 114;
            this.txtDescricao_Produto.Text = "";
            // 
            // lblDescricao_Produto
            // 
            this.lblDescricao_Produto.AutoSize = true;
            this.lblDescricao_Produto.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDescricao_Produto.Location = new System.Drawing.Point(166, 250);
            this.lblDescricao_Produto.Name = "lblDescricao_Produto";
            this.lblDescricao_Produto.Size = new System.Drawing.Size(77, 19);
            this.lblDescricao_Produto.TabIndex = 113;
            this.lblDescricao_Produto.Text = "Descrição";
            // 
            // btnListar_Produtos
            // 
            this.btnListar_Produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnListar_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar_Produtos.ForeColor = System.Drawing.Color.Purple;
            this.btnListar_Produtos.Location = new System.Drawing.Point(13, 274);
            this.btnListar_Produtos.Name = "btnListar_Produtos";
            this.btnListar_Produtos.Size = new System.Drawing.Size(138, 26);
            this.btnListar_Produtos.TabIndex = 110;
            this.btnListar_Produtos.Text = "Listar Produtos";
            this.btnListar_Produtos.UseVisualStyleBackColor = false;
            this.btnListar_Produtos.Click += new System.EventHandler(this.btnListar_Produtos_Click);
            // 
            // pnl_Listar_Produtos
            // 
            this.pnl_Listar_Produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Listar_Produtos.AutoScroll = true;
            this.pnl_Listar_Produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Listar_Produtos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Listar_Produtos.ForeColor = System.Drawing.Color.Black;
            this.pnl_Listar_Produtos.Location = new System.Drawing.Point(13, 333);
            this.pnl_Listar_Produtos.Name = "pnl_Listar_Produtos";
            this.pnl_Listar_Produtos.Size = new System.Drawing.Size(685, 102);
            this.pnl_Listar_Produtos.TabIndex = 109;
            // 
            // cboTamanho
            // 
            this.cboTamanho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTamanho.FormattingEnabled = true;
            this.cboTamanho.Items.AddRange(new object[] {
            "Alimentos",
            "Serviços"});
            this.cboTamanho.Location = new System.Drawing.Point(600, 131);
            this.cboTamanho.Name = "cboTamanho";
            this.cboTamanho.Size = new System.Drawing.Size(99, 24);
            this.cboTamanho.TabIndex = 108;
            // 
            // txtCompra
            // 
            this.txtCompra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCompra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCompra.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompra.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompra.ForeColor = System.Drawing.Color.Black;
            this.txtCompra.HintForeColor = System.Drawing.Color.Empty;
            this.txtCompra.HintText = "";
            this.txtCompra.isPassword = false;
            this.txtCompra.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtCompra.LineIdleColor = System.Drawing.Color.Purple;
            this.txtCompra.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtCompra.LineThickness = 1;
            this.txtCompra.Location = new System.Drawing.Point(300, 166);
            this.txtCompra.Margin = new System.Windows.Forms.Padding(5);
            this.txtCompra.MaxLength = 32767;
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(150, 33);
            this.txtCompra.TabIndex = 107;
            this.txtCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCodigo_Barras
            // 
            this.txtCodigo_Barras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo_Barras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCodigo_Barras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCodigo_Barras.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigo_Barras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo_Barras.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo_Barras.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo_Barras.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigo_Barras.HintText = "";
            this.txtCodigo_Barras.isPassword = false;
            this.txtCodigo_Barras.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtCodigo_Barras.LineIdleColor = System.Drawing.Color.Purple;
            this.txtCodigo_Barras.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtCodigo_Barras.LineThickness = 1;
            this.txtCodigo_Barras.Location = new System.Drawing.Point(517, 200);
            this.txtCodigo_Barras.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo_Barras.MaxLength = 32767;
            this.txtCodigo_Barras.Name = "txtCodigo_Barras";
            this.txtCodigo_Barras.Size = new System.Drawing.Size(181, 33);
            this.txtCodigo_Barras.TabIndex = 106;
            this.txtCodigo_Barras.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblCodigo_Barras
            // 
            this.lblCodigo_Barras.AutoSize = true;
            this.lblCodigo_Barras.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCodigo_Barras.Location = new System.Drawing.Point(458, 215);
            this.lblCodigo_Barras.Name = "lblCodigo_Barras";
            this.lblCodigo_Barras.Size = new System.Drawing.Size(60, 19);
            this.lblCodigo_Barras.TabIndex = 105;
            this.lblCodigo_Barras.Text = "Código";
            // 
            // lblTamanho
            // 
            this.lblTamanho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTamanho.Location = new System.Drawing.Point(514, 137);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(74, 19);
            this.lblTamanho.TabIndex = 104;
            this.lblTamanho.Text = "Tamanho";
            // 
            // txtVenda
            // 
            this.txtVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVenda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtVenda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtVenda.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtVenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVenda.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenda.ForeColor = System.Drawing.Color.Black;
            this.txtVenda.HintForeColor = System.Drawing.Color.Empty;
            this.txtVenda.HintText = "";
            this.txtVenda.isPassword = false;
            this.txtVenda.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtVenda.LineIdleColor = System.Drawing.Color.Purple;
            this.txtVenda.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtVenda.LineThickness = 1;
            this.txtVenda.Location = new System.Drawing.Point(572, 166);
            this.txtVenda.Margin = new System.Windows.Forms.Padding(5);
            this.txtVenda.MaxLength = 32767;
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(127, 33);
            this.txtVenda.TabIndex = 100;
            this.txtVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPesquisarImagem
            // 
            this.btnPesquisarImagem.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarImagem.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesquisarImagem.Image = global::FFM.Properties.Resources.icons8_pesquisa_google_na_web_28;
            this.btnPesquisarImagem.Location = new System.Drawing.Point(297, 56);
            this.btnPesquisarImagem.Name = "btnPesquisarImagem";
            this.btnPesquisarImagem.Size = new System.Drawing.Size(31, 27);
            this.btnPesquisarImagem.TabIndex = 99;
            this.btnPesquisarImagem.Text = "...";
            this.btnPesquisarImagem.UseVisualStyleBackColor = false;
            this.btnPesquisarImagem.Click += new System.EventHandler(this.btnPesquisarImagem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(13, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 23);
            this.lblTitulo.TabIndex = 98;
            this.lblTitulo.Text = "Cadastro de Produtos";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeArquivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeArquivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeArquivo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomeArquivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeArquivo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeArquivo.ForeColor = System.Drawing.Color.Black;
            this.txtNomeArquivo.HintForeColor = System.Drawing.Color.Empty;
            this.txtNomeArquivo.HintText = "";
            this.txtNomeArquivo.isPassword = false;
            this.txtNomeArquivo.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtNomeArquivo.LineIdleColor = System.Drawing.Color.Purple;
            this.txtNomeArquivo.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtNomeArquivo.LineThickness = 1;
            this.txtNomeArquivo.Location = new System.Drawing.Point(331, 53);
            this.txtNomeArquivo.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomeArquivo.MaxLength = 32767;
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(367, 33);
            this.txtNomeArquivo.TabIndex = 102;
            this.txtNomeArquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblNome_Arquivo
            // 
            this.lblNome_Arquivo.AutoSize = true;
            this.lblNome_Arquivo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNome_Arquivo.Location = new System.Drawing.Point(160, 63);
            this.lblNome_Arquivo.Name = "lblNome_Arquivo";
            this.lblNome_Arquivo.Size = new System.Drawing.Size(134, 19);
            this.lblNome_Arquivo.TabIndex = 101;
            this.lblNome_Arquivo.Text = "Nome do arquivo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // txtCor
            // 
            this.txtCor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCor.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.ForeColor = System.Drawing.Color.Black;
            this.txtCor.HintForeColor = System.Drawing.Color.Empty;
            this.txtCor.HintText = "";
            this.txtCor.isPassword = false;
            this.txtCor.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtCor.LineIdleColor = System.Drawing.Color.Purple;
            this.txtCor.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtCor.LineThickness = 1;
            this.txtCor.Location = new System.Drawing.Point(207, 200);
            this.txtCor.Margin = new System.Windows.Forms.Padding(5);
            this.txtCor.MaxLength = 32767;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(243, 33);
            this.txtCor.TabIndex = 96;
            this.txtCor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.ForeColor = System.Drawing.Color.Purple;
            this.btnExcluirProduto.Location = new System.Drawing.Point(13, 244);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(138, 26);
            this.btnExcluirProduto.TabIndex = 93;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.ForeColor = System.Drawing.Color.Purple;
            this.btnEditarProduto.Location = new System.Drawing.Point(13, 215);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(138, 26);
            this.btnEditarProduto.TabIndex = 92;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.Purple;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(13, 186);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(138, 26);
            this.btnCadastrarProduto.TabIndex = 91;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuantidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuantidade.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuantidade.HintText = "";
            this.txtQuantidade.isPassword = false;
            this.txtQuantidade.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtQuantidade.LineIdleColor = System.Drawing.Color.Purple;
            this.txtQuantidade.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtQuantidade.LineThickness = 1;
            this.txtQuantidade.Location = new System.Drawing.Point(222, 122);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantidade.MaxLength = 32767;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(48, 33);
            this.txtQuantidade.TabIndex = 95;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeProduto.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomeProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeProduto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.ForeColor = System.Drawing.Color.Black;
            this.txtNomeProduto.HintForeColor = System.Drawing.Color.Empty;
            this.txtNomeProduto.HintText = "";
            this.txtNomeProduto.isPassword = false;
            this.txtNomeProduto.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtNomeProduto.LineIdleColor = System.Drawing.Color.Purple;
            this.txtNomeProduto.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtNomeProduto.LineThickness = 1;
            this.txtNomeProduto.Location = new System.Drawing.Point(222, 88);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomeProduto.MaxLength = 32767;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(477, 33);
            this.txtNomeProduto.TabIndex = 94;
            this.txtNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPreco_Produto
            // 
            this.lblPreco_Produto.AutoSize = true;
            this.lblPreco_Produto.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPreco_Produto.Location = new System.Drawing.Point(166, 181);
            this.lblPreco_Produto.Name = "lblPreco_Produto";
            this.lblPreco_Produto.Size = new System.Drawing.Size(132, 19);
            this.lblPreco_Produto.TabIndex = 86;
            this.lblPreco_Produto.Text = "Preço de Compra";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCor.Location = new System.Drawing.Point(166, 215);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(33, 19);
            this.lblCor.TabIndex = 90;
            this.lblCor.Text = "Cor";
            // 
            // lblQtdProduto
            // 
            this.lblQtdProduto.AutoSize = true;
            this.lblQtdProduto.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblQtdProduto.Location = new System.Drawing.Point(160, 137);
            this.lblQtdProduto.Name = "lblQtdProduto";
            this.lblQtdProduto.Size = new System.Drawing.Size(49, 19);
            this.lblQtdProduto.TabIndex = 89;
            this.lblQtdProduto.Text = "Qtde.";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCategoria.Location = new System.Drawing.Point(282, 137);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(79, 19);
            this.lblCategoria.TabIndex = 85;
            this.lblCategoria.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(452, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 88;
            this.label2.Text = "Preço de Venda";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNomeProduto.Location = new System.Drawing.Point(160, 98);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(50, 19);
            this.lblNomeProduto.TabIndex = 84;
            this.lblNomeProduto.Text = "Nome";
            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Alimentos",
            "Serviços"});
            this.cboCategoria.Location = new System.Drawing.Point(367, 132);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(132, 24);
            this.cboCategoria.TabIndex = 87;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.HintForeColor = System.Drawing.Color.Empty;
            this.txtId.HintText = "";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtId.LineIdleColor = System.Drawing.Color.Purple;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtId.LineThickness = 1;
            this.txtId.Location = new System.Drawing.Point(544, 15);
            this.txtId.Margin = new System.Windows.Forms.Padding(5);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(154, 33);
            this.txtId.TabIndex = 117;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::FFM.Properties.Resources.icons8_à_esquerda_dentro_de_um_círculo_26;
            this.btnVoltar.Location = new System.Drawing.Point(17, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(32, 33);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnVoltar.TabIndex = 118;
            this.btnVoltar.TabStop = false;
            // 
            // uc_Cadastro_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTitulo_Listagem);
            this.Controls.Add(this.txtDescricao_Produto);
            this.Controls.Add(this.lblDescricao_Produto);
            this.Controls.Add(this.btnListar_Produtos);
            this.Controls.Add(this.pnl_Listar_Produtos);
            this.Controls.Add(this.cboTamanho);
            this.Controls.Add(this.txtCodigo_Barras);
            this.Controls.Add(this.lblCodigo_Barras);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.btnPesquisarImagem);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.lblNome_Arquivo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblPreco_Produto);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblQtdProduto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtCompra);
            this.Name = "uc_Cadastro_Produtos";
            this.Size = new System.Drawing.Size(712, 446);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo_Listagem;
        private System.Windows.Forms.RichTextBox txtDescricao_Produto;
        private System.Windows.Forms.Label lblDescricao_Produto;
        private System.Windows.Forms.Button btnListar_Produtos;
        private System.Windows.Forms.Panel pnl_Listar_Produtos;
        private System.Windows.Forms.ComboBox cboTamanho;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCompra;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigo_Barras;
        private System.Windows.Forms.Label lblCodigo_Barras;
        private System.Windows.Forms.Label lblTamanho;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtVenda;
        private System.Windows.Forms.Button btnPesquisarImagem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomeArquivo;
        private System.Windows.Forms.Label lblNome_Arquivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCor;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantidade;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomeProduto;
        private System.Windows.Forms.Label lblPreco_Produto;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblQtdProduto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.ComboBox cboCategoria;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
        private System.Windows.Forms.PictureBox btnVoltar;
    }
}
