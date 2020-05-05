using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM.Utilitario
{
    class util_Msgbox
    {
        public static void Aviso(String _sMensagem)
        {
            MessageBox.Show(_sMensagem, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void Erro(String _sLocalErro)
        {
            MessageBox.Show("Erro em [" + _sLocalErro + "]", "ERRO x_x", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Sucesso(String _sMensagem)
        {
            MessageBox.Show(_sMensagem, "SUCESSO :D", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Pergunta(String _sMensagem)
        {
            MessageBox.Show(_sMensagem, "PERGUNTA?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}
