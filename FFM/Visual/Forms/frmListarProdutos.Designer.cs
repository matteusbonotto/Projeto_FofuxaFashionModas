namespace FFM.Visual.Forms
{
    partial class frmListarProdutos
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
            this.pnl_ListarProdutos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_ListarProdutos
            // 
            this.pnl_ListarProdutos.BackColor = System.Drawing.Color.White;
            this.pnl_ListarProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ListarProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnl_ListarProdutos.Name = "pnl_ListarProdutos";
            this.pnl_ListarProdutos.Size = new System.Drawing.Size(766, 450);
            this.pnl_ListarProdutos.TabIndex = 0;
            // 
            // frmListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.pnl_ListarProdutos);
            this.Name = "frmListarProdutos";
            this.Text = "frmListarProdutos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ListarProdutos;
    }
}