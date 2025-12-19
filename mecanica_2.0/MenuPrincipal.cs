using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mecanica_2._0
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void LoadForm(object Form)
        {
            Form f = Form as Form;
            f.TopLevel = false;
            f.TopMost = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            panelMain.Controls.Add(f);
            f.Show();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadUser_Click(object sender, EventArgs e)
        {
            LoadForm(new Forms.GerenciarUsuarios());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

/** codigos de cores
 * 
 * azul: 
 * #293644
 * #435568
 * #1A2A3B
 * #0E1D2C
 * #04101B
 * 
 * Verde: 
 * #021C14
 * #0C2D22
 * #28453C
 * #416A5D
 * #183C30
 */
