using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace mecanica_2._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
                txtEmail.Text = Properties.Settings.Default.Email;
                txtSenha.Text = Properties.Settings.Default.Senha;
                ckBoxLembrar.Checked = Properties.Settings.Default.Lembrar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Usuarios user = new Classes.Usuarios();
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (email == "" || senha == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            else
            {
                DataTable dt = user.Listar();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Email"].ToString() == email && row["Senha"].ToString() == senha)
                    {
                        MessageBox.Show("Login bem-sucedido!");
                        this.Hide();
                        this.Show();
                        MenuPrincipal menu = new MenuPrincipal();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha incorretos.");
                    }
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckBoxLembrar_CheckedChanged(object sender, EventArgs e)
        {

            if (ckBoxLembrar.Checked)
            {
                Properties.Settings.Default["Email"] = txtEmail.Text;
                Properties.Settings.Default["Senha"] = txtSenha.Text;
                Properties.Settings.Default["Lembrar"] = true;
            }
            else
            {
                Properties.Settings.Default["Email"] = txtEmail.Text;
                Properties.Settings.Default["Senha"] = txtSenha.Text;
                Properties.Settings.Default["Lembrar"] = false;
            }

            Properties.Settings.Default.Save();
        }
    
    

    }
}
