namespace FFM.Visual.Forms.Principais
{
    partial class frm_Sobre
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-2, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(279, 216);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "https://www.fofuxafashion.com.br/\n11 2574-6334\nFofuxafashion@hotmail.com\nhttps://" +
    "www.facebook.com/fofuxafashion/about/?_rdc=1&_rdr\nhttps://www.instagram.com/fofu" +
    "xamodafashion/";
            // 
            // frm_Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 253);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frm_Sobre";
            this.Text = "frm_Sobre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}