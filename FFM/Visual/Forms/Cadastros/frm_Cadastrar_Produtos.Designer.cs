namespace FFM.Visual.Forms.Cadastros
{
    partial class frm_Cadastrar_Produtos
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
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.lblPreco_Produto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtdProduto = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtNomeProduto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnPesquisarImagem = new System.Windows.Forms.Button();
            this.Linha_Venda = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblNome_Arquivo = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.txtCodigo_Barras = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblCodigo_Barras = new System.Windows.Forms.Label();
            this.Linha_Compra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cboTamanho = new System.Windows.Forms.ComboBox();
            this.pnl_Listar_Produtos = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnListar_Produtos = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblDescricao_Produto = new System.Windows.Forms.Label();
            this.txtDescricao_Produto = new System.Windows.Forms.RichTextBox();
            this.lblTitulo_Listagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.ForeColor = System.Drawing.Color.Purple;
            this.btnExcluirProduto.Location = new System.Drawing.Point(12, 306);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(138, 38);
            this.btnExcluirProduto.TabIndex = 37;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.ForeColor = System.Drawing.Color.Purple;
            this.btnEditarProduto.Location = new System.Drawing.Point(12, 262);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(138, 38);
            this.btnEditarProduto.TabIndex = 36;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.Purple;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(12, 218);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(138, 38);
            this.btnCadastrarProduto.TabIndex = 35;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // lblPreco_Produto
            // 
            this.lblPreco_Produto.AutoSize = true;
            this.lblPreco_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco_Produto.Location = new System.Drawing.Point(165, 178);
            this.lblPreco_Produto.Name = "lblPreco_Produto";
            this.lblPreco_Produto.Size = new System.Drawing.Size(126, 18);
            this.lblPreco_Produto.TabIndex = 10;
            this.lblPreco_Produto.Text = "Preço de Compra";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(288, 134);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 18);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(159, 95);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(49, 18);
            this.lblNomeProduto.TabIndex = 6;
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
            this.cboCategoria.Location = new System.Drawing.Point(366, 129);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(132, 24);
            this.cboCategoria.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Preço de Venda";
            // 
            // lblQtdProduto
            // 
            this.lblQtdProduto.AutoSize = true;
            this.lblQtdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdProduto.Location = new System.Drawing.Point(159, 134);
            this.lblQtdProduto.Name = "lblQtdProduto";
            this.lblQtdProduto.Size = new System.Drawing.Size(44, 18);
            this.lblQtdProduto.TabIndex = 18;
            this.lblQtdProduto.Text = "Qtde.";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(165, 212);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(33, 18);
            this.lblCor.TabIndex = 22;
            this.lblCor.Text = "Cor";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomeProduto.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeProduto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.ForeColor = System.Drawing.Color.Black;
            this.txtNomeProduto.HintForeColor = System.Drawing.Color.Empty;
            this.txtNomeProduto.HintText = "";
            this.txtNomeProduto.isPassword = false;
            this.txtNomeProduto.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtNomeProduto.LineIdleColor = System.Drawing.Color.Purple;
            this.txtNomeProduto.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtNomeProduto.LineThickness = 2;
            this.txtNomeProduto.Location = new System.Drawing.Point(221, 85);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomeProduto.MaxLength = 32767;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(477, 33);
            this.txtNomeProduto.TabIndex = 52;
            this.txtNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Purple;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.bunifuMaterialTextbox2.LineThickness = 2;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(221, 119);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuMaterialTextbox2.MaxLength = 32767;
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(48, 33);
            this.bunifuMaterialTextbox2.TabIndex = 53;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCor
            // 
            this.txtCor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCor.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCor.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.ForeColor = System.Drawing.Color.Black;
            this.txtCor.HintForeColor = System.Drawing.Color.Empty;
            this.txtCor.HintText = "";
            this.txtCor.isPassword = false;
            this.txtCor.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtCor.LineIdleColor = System.Drawing.Color.Purple;
            this.txtCor.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtCor.LineThickness = 2;
            this.txtCor.Location = new System.Drawing.Point(206, 197);
            this.txtCor.Margin = new System.Windows.Forms.Padding(5);
            this.txtCor.MaxLength = 32767;
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(243, 33);
            this.txtCor.TabIndex = 57;
            this.txtCor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(11, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(211, 24);
            this.lblTitulo.TabIndex = 59;
            this.lblTitulo.Text = "Cadastro de Produtos";
            // 
            // btnPesquisarImagem
            // 
            this.btnPesquisarImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPesquisarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarImagem.ForeColor = System.Drawing.Color.Purple;
            this.btnPesquisarImagem.Location = new System.Drawing.Point(291, 56);
            this.btnPesquisarImagem.Name = "btnPesquisarImagem";
            this.btnPesquisarImagem.Size = new System.Drawing.Size(31, 27);
            this.btnPesquisarImagem.TabIndex = 63;
            this.btnPesquisarImagem.Text = "...";
            this.btnPesquisarImagem.UseVisualStyleBackColor = false;
            this.btnPesquisarImagem.Click += new System.EventHandler(this.button2_Click);
            // 
            // Linha_Venda
            // 
            this.Linha_Venda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Linha_Venda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Linha_Venda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Linha_Venda.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Linha_Venda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Linha_Venda.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Linha_Venda.ForeColor = System.Drawing.Color.Black;
            this.Linha_Venda.HintForeColor = System.Drawing.Color.Empty;
            this.Linha_Venda.HintText = "";
            this.Linha_Venda.isPassword = false;
            this.Linha_Venda.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.Linha_Venda.LineIdleColor = System.Drawing.Color.Purple;
            this.Linha_Venda.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.Linha_Venda.LineThickness = 2;
            this.Linha_Venda.Location = new System.Drawing.Point(571, 163);
            this.Linha_Venda.Margin = new System.Windows.Forms.Padding(5);
            this.Linha_Venda.MaxLength = 32767;
            this.Linha_Venda.Name = "Linha_Venda";
            this.Linha_Venda.Size = new System.Drawing.Size(127, 33);
            this.Linha_Venda.TabIndex = 64;
            this.Linha_Venda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblNome_Arquivo
            // 
            this.lblNome_Arquivo.AutoSize = true;
            this.lblNome_Arquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_Arquivo.Location = new System.Drawing.Point(159, 60);
            this.lblNome_Arquivo.Name = "lblNome_Arquivo";
            this.lblNome_Arquivo.Size = new System.Drawing.Size(126, 18);
            this.lblNome_Arquivo.TabIndex = 65;
            this.lblNome_Arquivo.Text = "Nome do arquivo:";
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
            this.txtNomeArquivo.LineThickness = 2;
            this.txtNomeArquivo.Location = new System.Drawing.Point(330, 50);
            this.txtNomeArquivo.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomeArquivo.MaxLength = 32767;
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(367, 33);
            this.txtNomeArquivo.TabIndex = 67;
            this.txtNomeArquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Purple;
            this.btnVoltar.Location = new System.Drawing.Point(12, 394);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(138, 38);
            this.btnVoltar.TabIndex = 68;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // lblTamanho
            // 
            this.lblTamanho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.Location = new System.Drawing.Point(513, 134);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(71, 18);
            this.lblTamanho.TabIndex = 69;
            this.lblTamanho.Text = "Tamanho";
            // 
            // txtCodigo_Barras
            // 
            this.txtCodigo_Barras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo_Barras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCodigo_Barras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCodigo_Barras.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo_Barras.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo_Barras.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo_Barras.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo_Barras.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigo_Barras.HintText = "";
            this.txtCodigo_Barras.isPassword = false;
            this.txtCodigo_Barras.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.txtCodigo_Barras.LineIdleColor = System.Drawing.Color.Purple;
            this.txtCodigo_Barras.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.txtCodigo_Barras.LineThickness = 2;
            this.txtCodigo_Barras.Location = new System.Drawing.Point(571, 197);
            this.txtCodigo_Barras.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodigo_Barras.MaxLength = 32767;
            this.txtCodigo_Barras.Name = "txtCodigo_Barras";
            this.txtCodigo_Barras.Size = new System.Drawing.Size(126, 33);
            this.txtCodigo_Barras.TabIndex = 72;
            this.txtCodigo_Barras.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblCodigo_Barras
            // 
            this.lblCodigo_Barras.AutoSize = true;
            this.lblCodigo_Barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo_Barras.Location = new System.Drawing.Point(457, 212);
            this.lblCodigo_Barras.Name = "lblCodigo_Barras";
            this.lblCodigo_Barras.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo_Barras.TabIndex = 71;
            this.lblCodigo_Barras.Text = "Código";
            // 
            // Linha_Compra
            // 
            this.Linha_Compra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Linha_Compra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Linha_Compra.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Linha_Compra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Linha_Compra.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Linha_Compra.ForeColor = System.Drawing.Color.Black;
            this.Linha_Compra.HintForeColor = System.Drawing.Color.Empty;
            this.Linha_Compra.HintText = "";
            this.Linha_Compra.isPassword = false;
            this.Linha_Compra.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.Linha_Compra.LineIdleColor = System.Drawing.Color.Purple;
            this.Linha_Compra.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.Linha_Compra.LineThickness = 2;
            this.Linha_Compra.Location = new System.Drawing.Point(299, 163);
            this.Linha_Compra.Margin = new System.Windows.Forms.Padding(5);
            this.Linha_Compra.MaxLength = 32767;
            this.Linha_Compra.Name = "Linha_Compra";
            this.Linha_Compra.Size = new System.Drawing.Size(150, 33);
            this.Linha_Compra.TabIndex = 74;
            this.Linha_Compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.cboTamanho.Location = new System.Drawing.Point(599, 128);
            this.cboTamanho.Name = "cboTamanho";
            this.cboTamanho.Size = new System.Drawing.Size(99, 24);
            this.cboTamanho.TabIndex = 75;
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
            this.pnl_Listar_Produtos.Location = new System.Drawing.Point(161, 318);
            this.pnl_Listar_Produtos.Name = "pnl_Listar_Produtos";
            this.pnl_Listar_Produtos.Size = new System.Drawing.Size(536, 114);
            this.pnl_Listar_Produtos.TabIndex = 76;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // btnListar_Produtos
            // 
            this.btnListar_Produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnListar_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar_Produtos.ForeColor = System.Drawing.Color.Purple;
            this.btnListar_Produtos.Location = new System.Drawing.Point(12, 350);
            this.btnListar_Produtos.Name = "btnListar_Produtos";
            this.btnListar_Produtos.Size = new System.Drawing.Size(138, 38);
            this.btnListar_Produtos.TabIndex = 77;
            this.btnListar_Produtos.Text = "Listar Produtos";
            this.btnListar_Produtos.UseVisualStyleBackColor = false;
            this.btnListar_Produtos.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtId
            // 
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
            this.txtId.LineThickness = 2;
            this.txtId.Location = new System.Drawing.Point(46, 50);
            this.txtId.Margin = new System.Windows.Forms.Padding(5);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(104, 33);
            this.txtId.TabIndex = 78;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(12, 56);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 18);
            this.lblid.TabIndex = 79;
            this.lblid.Text = "ID:";
            // 
            // lblDescricao_Produto
            // 
            this.lblDescricao_Produto.AutoSize = true;
            this.lblDescricao_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao_Produto.Location = new System.Drawing.Point(165, 247);
            this.lblDescricao_Produto.Name = "lblDescricao_Produto";
            this.lblDescricao_Produto.Size = new System.Drawing.Size(76, 18);
            this.lblDescricao_Produto.TabIndex = 80;
            this.lblDescricao_Produto.Text = "Descrição";
            // 
            // txtDescricao_Produto
            // 
            this.txtDescricao_Produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao_Produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao_Produto.Location = new System.Drawing.Point(254, 247);
            this.txtDescricao_Produto.Name = "txtDescricao_Produto";
            this.txtDescricao_Produto.Size = new System.Drawing.Size(444, 41);
            this.txtDescricao_Produto.TabIndex = 81;
            this.txtDescricao_Produto.Text = "";
            // 
            // lblTitulo_Listagem
            // 
            this.lblTitulo_Listagem.AutoSize = true;
            this.lblTitulo_Listagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo_Listagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo_Listagem.Location = new System.Drawing.Point(164, 291);
            this.lblTitulo_Listagem.Name = "lblTitulo_Listagem";
            this.lblTitulo_Listagem.Size = new System.Drawing.Size(212, 24);
            this.lblTitulo_Listagem.TabIndex = 82;
            this.lblTitulo_Listagem.Text = "Listagem de Produtos";
            // 
            // frm_Cadastrar_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 440);
            this.Controls.Add(this.lblTitulo_Listagem);
            this.Controls.Add(this.txtDescricao_Produto);
            this.Controls.Add(this.lblDescricao_Produto);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnListar_Produtos);
            this.Controls.Add(this.pnl_Listar_Produtos);
            this.Controls.Add(this.cboTamanho);
            this.Controls.Add(this.Linha_Compra);
            this.Controls.Add(this.txtCodigo_Barras);
            this.Controls.Add(this.lblCodigo_Barras);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.lblNome_Arquivo);
            this.Controls.Add(this.Linha_Venda);
            this.Controls.Add(this.btnPesquisarImagem);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblPreco_Produto);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblQtdProduto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.cboCategoria);
            this.Name = "frm_Cadastrar_Produtos";
            this.Text = "frm_Cadastrar_Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Label lblPreco_Produto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtdProduto;
        private System.Windows.Forms.Label lblCor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomeProduto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPesquisarImagem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Linha_Venda;
        private System.Windows.Forms.Label lblNome_Arquivo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNomeArquivo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTamanho;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigo_Barras;
        private System.Windows.Forms.Label lblCodigo_Barras;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Linha_Compra;
        private System.Windows.Forms.ComboBox cboTamanho;
        private System.Windows.Forms.Panel pnl_Listar_Produtos;
        private System.Windows.Forms.Button btnListar_Produtos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblDescricao_Produto;
        private System.Windows.Forms.RichTextBox txtDescricao_Produto;
        private System.Windows.Forms.Label lblTitulo_Listagem;
    }
}