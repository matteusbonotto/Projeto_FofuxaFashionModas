using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace FFM.Visual.Forms.Principais
{
    public partial class frm_MenuPrincipal : Form
    {
        Controle.Pessoa.Usuario.ctrl_Login Login = new Controle.Pessoa.Usuario.ctrl_Login();
        private int PosicaoIMGLoginX;
        private int PosicaoIMGLoginY;
        private bool Saiu = false;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public String sLicenca;

        private void ImgLoginRedondo()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(pictureBox2.DisplayRectangle);
            pictureBox2.Region = new Region(gp);
        }

        public frm_MenuPrincipal(string _sLicenca)
        {
            InitializeComponent();
            ImgLoginRedondo();
            PosicaoIMGLoginX = pictureBox2.Location.X - 340;
            PosicaoIMGLoginY = pictureBox2.Location.Y + 25;
            sLicenca = _sLicenca;
        }

        public void Autenticado(String _sNome, String _sLicenca)
        {
            if(_sLicenca == "Administrador")
            {
                lblLicenca.ForeColor = System.Drawing.Color.Red;
                lblLicenca.Text = _sLicenca;
                lblAutenticacao.Text = _sNome;
                sLicenca = _sLicenca;

                Panel_Menus.Controls.Clear();
                Ucs.uc_Painel_Administrador ucAdmin = new Ucs.uc_Painel_Administrador(this);
                Panel_Menus.Controls.Add(ucAdmin);

                panelConteudo.Controls.Clear();
                Ucs.Principais.uc_Bem_Vindo ucBoasVindas = new Ucs.Principais.uc_Bem_Vindo(this);
                panelConteudo.Controls.Add(ucBoasVindas);

                pictureBox2.Load("C:/Users/Matteus Bonotto/Desktop/Aulas/5ºSemestre/Liguagem de Programação/FofuxaFashionModas/Sistema/FFM/FFM/Repositorio/img_pessoas/adm.jpg");

                btnSair.Visible = true;
            }
            else
            {
                MessageBox.Show("Não deu certo o usuario é: "+ _sNome + "e a licenca é " + _sLicenca);
            }

        }

        public void AdicionarPanelConteudo(object obj)
        {
            panelConteudo.Controls.Add((Control)obj);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
           frm_Cadastro_Simples frmSimples = new frm_Cadastro_Simples();
            frmSimples.ShowDialog();
        }
        public void AbrirTela(String _sBotao)
        {
            panelConteudo.Controls.Clear();
            if (_sBotao == "blusas")
            {
                Ucs.Cadastros.uc_ListarProdutos ucProdutos = new Ucs.Cadastros.uc_ListarProdutos(this);
                ucProdutos.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(ucProdutos);
            }
            else if (_sBotao == "calcas")
            {
                Ucs.Cadastros.uc_ListarProdutos ucProdutos = new Ucs.Cadastros.uc_ListarProdutos(this);
                ucProdutos.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(ucProdutos);
            }
            else if (_sBotao == "sapatos")
            {
                Ucs.Cadastros.uc_ListarProdutos ucProdutos = new Ucs.Cadastros.uc_ListarProdutos(this);
                ucProdutos.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(ucProdutos);
            }
            else if (_sBotao == "intimas")
            {
                Ucs.Cadastros.uc_ListarProdutos ucProdutos = new Ucs.Cadastros.uc_ListarProdutos(this);
                ucProdutos.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(ucProdutos);
            }
            else if (_sBotao == "estoque")
            {
                Ucs.Cadastros.uc_ListarProdutos ucProdutos = new Ucs.Cadastros.uc_ListarProdutos(this);
                ucProdutos.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(ucProdutos);
            }
            else if (_sBotao == "cadastrarProdutos")
            {
                Ucs.Cadastros.uc_Cadastro_Produtos ucProdutos = new Ucs.Cadastros.uc_Cadastro_Produtos();
                ucProdutos.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(ucProdutos);
            }
            else if (_sBotao == "relatorioProdutos")
            {
                Ucs.Cadastros.uc_ListarProdutos ucProdutos = new Ucs.Cadastros.uc_ListarProdutos(this);
                ucProdutos.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(ucProdutos);
            }
            else if (_sBotao == "")
            {
                Ucs.Cadastros.uc_ListarProdutos ucProdutos = new Ucs.Cadastros.uc_ListarProdutos(this);
                ucProdutos.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(ucProdutos);
            }
            else if (_sBotao == "")
            {
                Ucs.Cadastros.uc_ListarProdutos ucProdutos = new Ucs.Cadastros.uc_ListarProdutos(this);
                ucProdutos.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(ucProdutos);
            }
            else if (_sBotao == "")
            {
                Ucs.Cadastros.uc_ListarProdutos ucProdutos = new Ucs.Cadastros.uc_ListarProdutos(this);
                ucProdutos.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(ucProdutos);
            }

        }

        public void btnEntrar_Click(object sender, EventArgs e)
        {
            panelConteudo.Controls.Clear();
            Ucs.Principais.uc_Login ucLogin = new Ucs.Principais.uc_Login(this);
            ucLogin.Dock = DockStyle.Fill;
            panelConteudo.Controls.Add(ucLogin);
        }




        public void CarregaDados()
        {
            //lblAutenticacao.Text = _sNome;
            lblLicenca.Text = sLicenca;
        }

        public void frm_MenuPrincipal_Load(object sender, EventArgs e)
        {

            if (sLicenca == "Administrador")
            {
                //Estancio o user control "Menu_Produtos" ee passo minha tela principal
                //como parametro para o metodo que esta lá
                panelMenu.Controls.Clear();
                Ucs.uc_Painel_Produtos ucPrincipal = new Ucs.uc_Painel_Produtos(this);
                Panel_Menus.Controls.Add(ucPrincipal);
            }
            else if (sLicenca == "Visitante")
            {
                if(Saiu)
                {
                    Ucs.Principais.uc_Bem_Vindo ucBoasVindas = new Ucs.Principais.uc_Bem_Vindo(this);
                    panelConteudo.Controls.Add(ucBoasVindas);
                    Ucs.uc_Painel_Produtos ucPrincipal = new Ucs.uc_Painel_Produtos(this);
                    Panel_Menus.Controls.Add(ucPrincipal);
                    
                }
                else
                {
                    Ucs.uc_Painel_Produtos ucPrincipal = new Ucs.uc_Painel_Produtos(this);
                    Panel_Menus.Controls.Add(ucPrincipal);
                    Ucs.Principais.uc_Bem_Vindo ucBoasVindas = new Ucs.Principais.uc_Bem_Vindo(this);
                    panelConteudo.Controls.Add(ucBoasVindas);
                }
            }
            else
            {
                Utilitario.util_Msgbox.Aviso("Deu Erro Olha de novo ai!!");
            }

        }

        public void LimparPainel()
        {
            panelConteudo.Controls.Clear();
            Ucs.Principais.uc_Bem_Vindo ucBoasVindas = new Ucs.Principais.uc_Bem_Vindo(this);
            panelConteudo.Controls.Add(ucBoasVindas);
        }

        private void panelConteudo_ParentChanged(object sender, EventArgs e)
        {

        }

        private void panelConteudo_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mnuUsuario.Show(pictureBox2, new Point(PosicaoIMGLoginX, PosicaoIMGLoginY));
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Saiu = true;
            panelConteudo.Controls.Clear();
            panelMenu.Controls.Clear();
            lblLicenca.ForeColor = System.Drawing.Color.White;
            lblAutenticacao.Text = "Visitante";
            lblLicenca.Text = "Visitante";
            frm_MenuPrincipal_Load(sender, e);
        }

        private void Mover_Tela_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
