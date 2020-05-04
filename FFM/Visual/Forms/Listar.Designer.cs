namespace FFM.Visual.Forms
{
    partial class Listar
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
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.cboFiltrarCliente = new System.Windows.Forms.ComboBox();
            this.lblfiltroClientes = new System.Windows.Forms.Label();
            this.txtfiltroClientes = new System.Windows.Forms.TextBox();
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.Contato,
            this.Cpf,
            this.Email,
            this.DataNasc});
            this.grdClientes.Location = new System.Drawing.Point(17, 72);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.Size = new System.Drawing.Size(649, 324);
            this.grdClientes.TabIndex = 31;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Contato
            // 
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // DataNasc
            // 
            this.DataNasc.HeaderText = "Data de Nacimento";
            this.DataNasc.Name = "DataNasc";
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Location = new System.Drawing.Point(759, 42);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(29, 26);
            this.btnProcurar.TabIndex = 38;
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // cboFiltrarCliente
            // 
            this.cboFiltrarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltrarCliente.FormattingEnabled = true;
            this.cboFiltrarCliente.Items.AddRange(new object[] {
            "id",
            "nome",
            "cpf",
            "email"});
            this.cboFiltrarCliente.Location = new System.Drawing.Point(103, 42);
            this.cboFiltrarCliente.Name = "cboFiltrarCliente";
            this.cboFiltrarCliente.Size = new System.Drawing.Size(121, 24);
            this.cboFiltrarCliente.TabIndex = 37;
            // 
            // lblfiltroClientes
            // 
            this.lblfiltroClientes.AutoSize = true;
            this.lblfiltroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltroClientes.ForeColor = System.Drawing.Color.Gray;
            this.lblfiltroClientes.Location = new System.Drawing.Point(26, 45);
            this.lblfiltroClientes.Name = "lblfiltroClientes";
            this.lblfiltroClientes.Size = new System.Drawing.Size(71, 18);
            this.lblfiltroClientes.TabIndex = 36;
            this.lblfiltroClientes.Text = "Filtrar por";
            // 
            // txtfiltroClientes
            // 
            this.txtfiltroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltroClientes.Location = new System.Drawing.Point(230, 42);
            this.txtfiltroClientes.Name = "txtfiltroClientes";
            this.txtfiltroClientes.Size = new System.Drawing.Size(436, 24);
            this.txtfiltroClientes.TabIndex = 35;
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtualizarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAtualizarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarLista.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarLista.Location = new System.Drawing.Point(17, 403);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(124, 38);
            this.btnAtualizarLista.TabIndex = 34;
            this.btnAtualizarLista.Text = "Atualizar Lista";
            this.btnAtualizarLista.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 25);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "Listagem de";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(571, 403);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 38);
            this.btnVoltar.TabIndex = 32;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.grdClientes);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.cboFiltrarCliente);
            this.Controls.Add(this.lblfiltroClientes);
            this.Controls.Add(this.txtfiltroClientes);
            this.Controls.Add(this.btnAtualizarLista);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVoltar);
            this.Name = "Listar";
            this.Text = "Listar";
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNasc;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.ComboBox cboFiltrarCliente;
        private System.Windows.Forms.Label lblfiltroClientes;
        private System.Windows.Forms.TextBox txtfiltroClientes;
        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVoltar;
    }
}