namespace FFM.Visual
{
    partial class sc
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.painelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgLoop = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.timerLoop = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.painelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.painelBarraTitulo);
            this.panel1.Controls.Add(this.imgLoop);
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 260);
            this.panel1.TabIndex = 1;
            // 
            // painelBarraTitulo
            // 
            this.painelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.painelBarraTitulo.Controls.Add(this.lblTitulo);
            this.painelBarraTitulo.Controls.Add(this.label2);
            this.painelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.painelBarraTitulo.Name = "painelBarraTitulo";
            this.painelBarraTitulo.Size = new System.Drawing.Size(427, 49);
            this.painelBarraTitulo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(106, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 41);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Aguarde";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 117);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carregando componentes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgLoop
            // 
            this.imgLoop.Location = new System.Drawing.Point(31, 90);
            this.imgLoop.Name = "imgLoop";
            this.imgLoop.Size = new System.Drawing.Size(120, 107);
            this.imgLoop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLoop.TabIndex = 8;
            this.imgLoop.TabStop = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(157, 90);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(218, 117);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "Carregando componentes";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 260);
            this.Controls.Add(this.panel1);
            this.Name = "sc";
            this.Text = "sc";
            this.panel1.ResumeLayout(false);
            this.painelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel painelBarraTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgLoop;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Timer timerLoop;
    }
}