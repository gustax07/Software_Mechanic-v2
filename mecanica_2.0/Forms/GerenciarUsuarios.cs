using Guna.UI2.WinForms;
using mecanica_2._0.Classes;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mecanica_2._0.Forms
{

    public partial class GerenciarUsuarios : Form
    {
        Usuarios usuario = new Usuarios();
        CadastrarUsuario cadastrar = new CadastrarUsuario();
        public GerenciarUsuarios()
        {

            InitializeComponent();
            alturaOriginal = dtgUsuarios.Size.Height;
            ListarDGV();

        }

        private async void ListarDGV()
        {
             dtgUsuarios.DataSource = await usuario.ListarUsuariosDGV();
        }

        private void GerenciarUsuarios_Load(object sender, EventArgs e)
        {
            btnFechar.Visible = false;
        }
        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario.Id = (int)dtgUsuarios.CurrentRow.Cells[0].Value;
        }

        public static int parentX, parentY;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {  
            this.Dispose();
            cadastrar.ShowDialog();
        }


        private void btnMais_Click(object sender, EventArgs e)
        {
            MaisInfo mais = new MaisInfo(usuario.Id);
            mais.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
           
        }

        private float scale = 1.0f;
        private int alturaOriginal = 0;

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            int width = this.Size.Width;
            int height = dtgUsuarios.Size.Height;

            if (height > 0)
            {
                scale += 0.005f;
                height = alturaOriginal;
                if (scale >= 1.0f)
                {
                    timer1.Stop();
                }
            }
            panelExibir.Size = new Size(width, (int)(height * scale));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListarDGV();
            timer1.Start();
            panelExibir.Size = new Size(0,0);
        }
    }
}
