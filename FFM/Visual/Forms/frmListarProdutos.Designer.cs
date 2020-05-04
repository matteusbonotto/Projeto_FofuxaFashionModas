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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pnl_ListarProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ListarProdutos
            // 
            this.pnl_ListarProdutos.BackColor = System.Drawing.Color.White;
            this.pnl_ListarProdutos.Controls.Add(this.vScrollBar1);
            this.pnl_ListarProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ListarProdutos.Location = new System.Drawing.Point(0, 0);
            this.pnl_ListarProdutos.Name = "pnl_ListarProdutos";
            this.pnl_ListarProdutos.Size = new System.Drawing.Size(600, 459);
            this.pnl_ListarProdutos.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(574, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 459);
            this.vScrollBar1.TabIndex = 0;
            // 
            // frmListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 459);
            this.Controls.Add(this.pnl_ListarProdutos);
            this.Name = "frmListarProdutos";
            this.Text = "frmListarProdutos";
            this.pnl_ListarProdutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ListarProdutos;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}