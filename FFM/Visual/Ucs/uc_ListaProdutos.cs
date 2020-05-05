using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM.Visual.Ucs
{
    public partial class uc_ListaProdutos : UserControl
    {
        public uc_ListaProdutos()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
        }

        private void uc_ListaProdutos_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
            txtDescricao.BackColor = Color.Pink;
        }

        private void uc_ListaProdutos_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            txtDescricao.BackColor = Color.White;
        }
    }
}
