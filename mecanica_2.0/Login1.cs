using mecanica_2._0.includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static mecanica_2._0.includes.MensagemBox;

namespace mecanica_2._0
{
    public partial class Login1 : Form
    {

        public Login1()
        {
            InitializeComponent();
            VerificarStatusServidor();
  
            txtSenha.UseSystemPasswordChar = true;
            MensagemBox Mensagem = new MensagemBox();
            DialogResult r = Mensagem.Box("Excluir registro","Tem certeza que deseja excluir?",Buttons.YesNo,Icons.Info);
        }


        int count = 0;

        private void Timer(object sender, EventArgs e)
        {


            count++;
            lblStatusServidor.Width = 250;
            lblStatusServidor.Height = 50;
            lblStatusServidor.AutoEllipsis = true;
            lblStatusServidor.Left = (panelLogin.Width - lblStatusServidor.Width) / 2;
            lblStatusServidor.Top = (panelLogin.Height - lblStatusServidor.Height) / 2;
            lblStatusServidor.TextAlign = ContentAlignment.MiddleCenter;
            lblStatusServidor.Text = "Conectando com Servidor (5/" + count + ")";

            Timer t = (Timer)sender;

            if (Classes.StatusServidor.VerificarConexao())
            {

                lblEmail.Visible = true;
                lblSenha.Visible = true;
                txtEmail.Visible = true;
                txtSenha.Visible = true;
                btnEntrar.Visible = true;
                lblStatusServidor.Visible = false;
                lblAvisoPonto.Visible = true;
                btnBaterPonto.Visible = true;
                btnEntrar.Text = "Entrar";
                t.Stop();
                return;
            }
            else
            {
                if (count == 2)
                {
                    lblStatusServidor.Text = "Banco de Dados Offline";
                    btnEntrar.Visible = true;
                    btnEntrar.Text = "Reconectar";
                    t.Stop();
                }
            }
        }

        private void Login1_Shown(object sender, EventArgs e)
        {

            Timer timer = new Timer();
            timer.Interval = 1000; // 5 segundos
            timer.Tick += Timer;
            timer.Start();

        }
        private void VerificarStatusServidor()
        {
            lblEmail.Visible = false;
            lblSenha.Visible = false;
            txtEmail.Visible = false;
            txtSenha.Visible = false;
            btnEntrar.Visible = false;
            btnBaterPonto.Visible = false;
            lblAvisoPonto.Visible = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (btnEntrar.Text == "Reconectar")
            {
                VerificarStatusServidor();
                count = 0;
                lblStatusServidor.Text = "Conectando com Servidor (5/" + count + ")";
                Login1_Shown(sender, e);
            }
            else
            {
                Classes.Usuarios usuario = new Classes.Usuarios();
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                DataTable dt = usuario.Listar();
                foreach (DataRow row in dt.Rows)
                {
                    var email = row["email"].ToString();
                    var senha = row["senha"].ToString();
                    if (email == usuario.Email && senha == usuario.Senha)
                    {
                        this.Hide();
                        MenuPrincipal telaPrincipal = new MenuPrincipal();
                        telaPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha incorretos!", "Erro ao efetuar login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void txtSenha_IconRightClick(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
            if (!txtSenha.UseSystemPasswordChar)
            {
                txtSenha.IconRight = Properties.Resources.fechar_o_olho;
            }
            else
            {
                txtSenha.IconRight = Properties.Resources.vendo;
            }
        }
    }
}
