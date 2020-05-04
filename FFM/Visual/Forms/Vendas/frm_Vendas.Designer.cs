namespace FFM.Visual.Forms.Vendas
{
    partial class frm_Vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxVenda = new System.Windows.Forms.GroupBox();
            this.btnServico = new System.Windows.Forms.RadioButton();
            this.btnProduto = new System.Windows.Forms.RadioButton();
            this.btnCarrinho = new System.Windows.Forms.PictureBox();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCarrinho = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxpagamento = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.lblopcPagamento = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cboTipoPagamento = new System.Windows.Forms.ComboBox();
            this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gbxVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarrinho)).BeginInit();
            this.gbxpagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxVenda
            // 
            this.gbxVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxVenda.Controls.Add(this.bunifuMaterialTextbox1);
            this.gbxVenda.Controls.Add(this.bunifuMaterialTextbox5);
            this.gbxVenda.Controls.Add(this.btnServico);
            this.gbxVenda.Controls.Add(this.btnProduto);
            this.gbxVenda.Controls.Add(this.btnCarrinho);
            this.gbxVenda.Controls.Add(this.nudQtd);
            this.gbxVenda.Controls.Add(this.btnProcurar);
            this.gbxVenda.Controls.Add(this.lblQtd);
            this.gbxVenda.Controls.Add(this.lblFiltro);
            this.gbxVenda.Controls.Add(this.label5);
            this.gbxVenda.Controls.Add(this.grdProdutos);
            this.gbxVenda.Controls.Add(this.grdCarrinho);
            this.gbxVenda.Controls.Add(this.gbxpagamento);
            this.gbxVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVenda.Location = new System.Drawing.Point(4, 3);
            this.gbxVenda.Name = "gbxVenda";
            this.gbxVenda.Size = new System.Drawing.Size(813, 467);
            this.gbxVenda.TabIndex = 2;
            this.gbxVenda.TabStop = false;
            this.gbxVenda.Text = "Vendas";
            // 
            // btnServico
            // 
            this.btnServico.AutoSize = true;
            this.btnServico.Location = new System.Drawing.Point(156, 23);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(76, 22);
            this.btnServico.TabIndex = 39;
            this.btnServico.Text = "Serviço";
            this.btnServico.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            this.btnProduto.AutoSize = true;
            this.btnProduto.Checked = true;
            this.btnProduto.Location = new System.Drawing.Point(71, 23);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(79, 22);
            this.btnProduto.TabIndex = 38;
            this.btnProduto.TabStop = true;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarrinho.Location = new System.Drawing.Point(736, 19);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(62, 55);
            this.btnCarrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCarrinho.TabIndex = 36;
            this.btnCarrinho.TabStop = false;
            // 
            // nudQtd
            // 
            this.nudQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtd.Location = new System.Drawing.Point(663, 25);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(55, 24);
            this.nudQtd.TabIndex = 35;
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Location = new System.Drawing.Point(7, 52);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(29, 26);
            this.btnProcurar.TabIndex = 34;
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // lblQtd
            // 
            this.lblQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(578, 27);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(36, 18);
            this.lblQtd.TabIndex = 32;
            this.lblQtd.Text = "Qtd.";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(6, 25);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(41, 18);
            this.lblFiltro.TabIndex = 31;
            this.lblFiltro.Text = "Filtro";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(578, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preço";
            // 
            // grdProdutos
            // 
            this.grdProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
            this.grdProdutos.Location = new System.Drawing.Point(9, 84);
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.Size = new System.Drawing.Size(793, 164);
            this.grdProdutos.TabIndex = 30;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "código";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Produto";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Preço";
            this.Column7.Name = "Column7";
            // 
            // grdCarrinho
            // 
            this.grdCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grdCarrinho.Location = new System.Drawing.Point(9, 276);
            this.grdCarrinho.Name = "grdCarrinho";
            this.grdCarrinho.Size = new System.Drawing.Size(606, 184);
            this.grdCarrinho.TabIndex = 21;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "DESCRIÇÃO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "QUANTIDADE";
            this.Column3.Name = "Column3";
            this.Column3.Width = 115;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PREÇO";
            this.Column4.Name = "Column4";
            // 
            // gbxpagamento
            // 
            this.gbxpagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxpagamento.Controls.Add(this.bunifuMaterialTextbox2);
            this.gbxpagamento.Controls.Add(this.txtTotal);
            this.gbxpagamento.Controls.Add(this.lblopcPagamento);
            this.gbxpagamento.Controls.Add(this.lblDesconto);
            this.gbxpagamento.Controls.Add(this.lblTotal);
            this.gbxpagamento.Controls.Add(this.cboTipoPagamento);
            this.gbxpagamento.Location = new System.Drawing.Point(621, 276);
            this.gbxpagamento.Name = "gbxpagamento";
            this.gbxpagamento.Size = new System.Drawing.Size(181, 184);
            this.gbxpagamento.TabIndex = 2;
            this.gbxpagamento.TabStop = false;
            this.gbxpagamento.Text = "Pagamento";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(24, 145);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 36);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "R$ 0,00";
            // 
            // lblopcPagamento
            // 
            this.lblopcPagamento.AutoSize = true;
            this.lblopcPagamento.Location = new System.Drawing.Point(24, 27);
            this.lblopcPagamento.Name = "lblopcPagamento";
            this.lblopcPagamento.Size = new System.Drawing.Size(153, 18);
            this.lblopcPagamento.TabIndex = 4;
            this.lblopcPagamento.Text = "Opção de Pagamento";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(24, 79);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(73, 18);
            this.lblDesconto.TabIndex = 3;
            this.lblDesconto.Text = "Desconto";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(24, 127);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 18);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "TOTAL";
            // 
            // cboTipoPagamento
            // 
            this.cboTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPagamento.FormattingEnabled = true;
            this.cboTipoPagamento.Items.AddRange(new object[] {
            " ",
            "Á Vista",
            "Parcelado"});
            this.cboTipoPagamento.Location = new System.Drawing.Point(27, 50);
            this.cboTipoPagamento.Name = "cboTipoPagamento";
            this.cboTipoPagamento.Size = new System.Drawing.Size(100, 26);
            this.cboTipoPagamento.TabIndex = 0;
            // 
            // bunifuMaterialTextbox5
            // 
            this.bunifuMaterialTextbox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextbox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox5.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox5.HintText = "";
            this.bunifuMaterialTextbox5.isPassword = false;
            this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Purple;
            this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.bunifuMaterialTextbox5.LineThickness = 2;
            this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(44, 49);
            this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox5.MaxLength = 32767;
            this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(526, 28);
            this.bunifuMaterialTextbox5.TabIndex = 57;
            this.bunifuMaterialTextbox5.Text = "USUÁRIO";
            this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Purple;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.bunifuMaterialTextbox1.LineThickness = 2;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(498, 50);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(220, 28);
            this.bunifuMaterialTextbox1.TabIndex = 58;
            this.bunifuMaterialTextbox1.Text = "USUÁRIO";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Purple;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Magenta;
            this.bunifuMaterialTextbox2.LineThickness = 2;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(27, 94);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox2.MaxLength = 32767;
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(100, 28);
            this.bunifuMaterialTextbox2.TabIndex = 59;
            this.bunifuMaterialTextbox2.Text = "USUÁRIO";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frm_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 468);
            this.Controls.Add(this.gbxVenda);
            this.Name = "frm_Vendas";
            this.Text = "frm_Vendas";
            this.gbxVenda.ResumeLayout(false);
            this.gbxVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCarrinho)).EndInit();
            this.gbxpagamento.ResumeLayout(false);
            this.gbxpagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxVenda;
        private System.Windows.Forms.RadioButton btnServico;
        private System.Windows.Forms.RadioButton btnProduto;
        private System.Windows.Forms.PictureBox btnCarrinho;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView grdCarrinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox gbxpagamento;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label lblopcPagamento;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cboTipoPagamento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
    }
}