using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM.Visual.Forms.Cadastros
{
    public partial class frm_Cadastrar_Usuario : Form
    {
        public frm_Cadastrar_Usuario()
        {
            InitializeComponent();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void opcCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (opcCNPJ.Checked)
            {
                txtDocumento.Clear();
                txtDocumento.Mask = "00.000.000/0000-00";
                txtDocumento.Focus();
            }
            else
            {
                txtDocumento.TextAlign = HorizontalAlignment.Center;
                txtDocumento.Clear();
                txtDocumento.Mask = "000.000.000-00";
                txtDocumento.Focus();
            }
        }

        private void txtTelefone_Validating(object sender, CancelEventArgs e)
        {
            string str = txtTelefone.Text;
            int Tamanho = str.Length;
            if (Tamanho <= 16)
            {
                txtTelefone.TextAlign = HorizontalAlignment.Center;
                txtTelefone.Mask = "(00) 0000 - 0000";
            }
            else if (Tamanho > 16 && Tamanho < 18)
            {
                txtTelefone.TextAlign = HorizontalAlignment.Center;
                txtTelefone.Mask = "(00) 0 0000 - 0000";
            }
            else
            {
                Utilitario.util_Msgbox.Aviso("Digite um numero Valido!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
