namespace FFM.Visual.Ucs.Cadastros
{
    partial class uc_ListarProdutos
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
            this.btnBloco = new System.Windows.Forms.PictureBox();
            this.btnLista = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnBloco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBloco
            // 
            this.btnBloco.Image = global::FFM.Properties.Resources.icons8_hashtag_grande_36;
            this.btnBloco.Location = new System.Drawing.Point(12, 42);
            this.btnBloco.Name = "btnBloco";
            this.btnBloco.Size = new System.Drawing.Size(28, 28);
            this.btnBloco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBloco.TabIndex = 39;
            this.btnBloco.TabStop = false;
            this.btnBloco.Click += new System.EventHandler(this.btnBloco_Click);
            // 
            // btnLista
            // 
            this.btnLista.Image = global::FFM.Properties.Resources.icons8_lista_2_36;
            this.btnLista.Location = new System.Drawing.Point(12, 42);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(28, 28);
            this.btnLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLista.TabIndex = 38;
            this.btnLista.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::FFM.Properties.Resources.icons8_à_esquerda_dentro_de_um_círculo_26;
            this.btnVoltar.Location = new System.Drawing.Point(12, 8);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(28, 28);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(63, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Filtros";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(382, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 23);
            this.textBox1.TabIndex = 36;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = global::FFM.Properties.Resources.icons8_pesquisa_google_na_web_28;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Location = new System.Drawing.Point(354, 39);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(29, 30);
            this.btnPesquisar.TabIndex = 35;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(286, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Produto:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 24);
            this.comboBox1.TabIndex = 32;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(623, 422);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Purple;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Purple;
            this.bunifuMaterialTextbox1.LineThickness = 2;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(5, 54);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(644, 24);
            this.bunifuMaterialTextbox1.TabIndex = 31;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnBloco);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnLista);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 519);
            this.panel1.TabIndex = 40;
            // 
            // uc_ListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "uc_ListarProdutos";
            this.Size = new System.Drawing.Size(660, 522);
            ((System.ComponentModel.ISupportInitialize)(this.btnBloco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBloco;
        private System.Windows.Forms.PictureBox btnLista;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Panel panel1;
    }
}
