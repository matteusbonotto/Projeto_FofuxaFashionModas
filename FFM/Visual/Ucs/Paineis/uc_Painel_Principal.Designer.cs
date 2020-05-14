namespace FFM.Visual.Ucs
{
    partial class uc_Painel_Principal
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCadastro_Usuario = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.lblTitulo);
            this.panelMenu.Controls.Add(this.btnCadastro_Usuario);
            this.panelMenu.Controls.Add(this.btnComprar);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(152, 321);
            this.panelMenu.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(60, 21);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "INÍCIO";
            // 
            // btnCadastro_Usuario
            // 
            this.btnCadastro_Usuario.FlatAppearance.BorderSize = 0;
            this.btnCadastro_Usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnCadastro_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro_Usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro_Usuario.ForeColor = System.Drawing.Color.White;
            this.btnCadastro_Usuario.Image = global::FFM.Properties.Resources.icons8_adicionar_grupo_de_usuários_mulher_homem_26;
            this.btnCadastro_Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro_Usuario.Location = new System.Drawing.Point(2, 74);
            this.btnCadastro_Usuario.Name = "btnCadastro_Usuario";
            this.btnCadastro_Usuario.Size = new System.Drawing.Size(146, 39);
            this.btnCadastro_Usuario.TabIndex = 4;
            this.btnCadastro_Usuario.Text = "        Cadastrar-se";
            this.btnCadastro_Usuario.UseVisualStyleBackColor = true;
            this.btnCadastro_Usuario.Click += new System.EventHandler(this.btnCadastro_Usuario_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Image = global::FFM.Properties.Resources.icons8_sacola_de_compras_26;
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.Location = new System.Drawing.Point(2, 29);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(146, 39);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // uc_Painel_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.Name = "uc_Painel_Principal";
            this.Size = new System.Drawing.Size(152, 321);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCadastro_Usuario;
        private System.Windows.Forms.Label lblTitulo;
    }
}
