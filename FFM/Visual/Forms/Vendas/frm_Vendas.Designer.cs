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
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnCarrinho = new System.Windows.Forms.PictureBox();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
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
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.cboTipoPagamento = new System.Windows.Forms.ComboBox();
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
            this.gbxVenda.Controls.Add(this.btnServico);
            this.gbxVenda.Controls.Add(this.btnProduto);
            this.gbxVenda.Controls.Add(this.txtPreco);
            this.gbxVenda.Controls.Add(this.btnCarrinho);
            this.gbxVenda.Controls.Add(this.nudQtd);
            this.gbxVenda.Controls.Add(this.btnProcurar);
            this.gbxVenda.Controls.Add(this.txtFiltro);
            this.gbxVenda.Controls.Add(this.lblQtd);
            this.gbxVenda.Controls.Add(this.lblFiltro);
            this.gbxVenda.Controls.Add(this.label5);
            this.gbxVenda.Controls.Add(this.grdProdutos);
            this.gbxVenda.Controls.Add(this.grdCarrinho);
            this.gbxVenda.Controls.Add(this.gbxpagamento);
            this.gbxVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVenda.Location = new System.Drawing.Point(12, 3);
            this.gbxVenda.Name = "gbxVenda";
            this.gbxVenda.Size = new System.Drawing.Size(677, 467);
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
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(494, 53);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(88, 24);
            this.txtPreco.TabIndex = 37;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarrinho.Location = new System.Drawing.Point(600, 19);
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
            this.nudQtd.Location = new System.Drawing.Point(527, 25);
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
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(42, 53);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(354, 24);
            this.txtFiltro.TabIndex = 33;
            // 
            // lblQtd
            // 
            this.lblQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(442, 27);
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
            this.label5.Location = new System.Drawing.Point(442, 56);
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
            this.grdProdutos.Size = new System.Drawing.Size(657, 164);
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
            this.grdCarrinho.Size = new System.Drawing.Size(470, 184);
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
            this.gbxpagamento.Controls.Add(this.txtTotal);
            this.gbxpagamento.Controls.Add(this.lblopcPagamento);
            this.gbxpagamento.Controls.Add(this.lblDesconto);
            this.gbxpagamento.Controls.Add(this.lblTotal);
            this.gbxpagamento.Controls.Add(this.txtDesconto);
            this.gbxpagamento.Controls.Add(this.cboTipoPagamento);
            this.gbxpagamento.Location = new System.Drawing.Point(485, 276);
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
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(27, 100);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 24);
            this.txtDesconto.TabIndex = 1;
            this.txtDesconto.Text = "R$ 0,00";
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
            // frm_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.PictureBox btnCarrinho;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtFiltro;
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
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.ComboBox cboTipoPagamento;
    }
}