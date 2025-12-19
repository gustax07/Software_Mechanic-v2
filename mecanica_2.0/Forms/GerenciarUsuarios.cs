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
        public GerenciarUsuarios()
        {

            InitializeComponent();
            var col = new DataGridViewCheckBoxColumn();
            col.Name = "Coluna";
            col.HeaderText = "#";
            col.FalseValue = "0";
            col.TrueValue = "1";

            //Make the default checked
            col.CellTemplate.Value = false;
            //col.CellTemplate.Style.NullValue = true;

            dtgUsuarios.Columns.Insert(0, col);


            dtgUsuarios.DataSource = usuario.ListarUsuariosDGV();

         
            toggleDGV.Checked = true;

        }

        private void LoadForm(object Form)
        {
            Form f = Form as Form;
            f.TopLevel = false;
            f.TopMost = false;
            f.Dock = DockStyle.Fill;
            this.panelExibir.Controls.Add(f);
            this.panelExibir.Tag = f;
            panelExibir.Controls.Add(f);
            f.Show();
        }
        private void GerenciarUsuarios_Load(object sender, EventArgs e)
        {
            btnFechar.Visible = false;
        }
        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnMais.Enabled = true;


            usuario.Id = (int)dtgUsuarios.CurrentRow.Cells[1].Value;
        }

        private void txtPessoais_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTelefones_Click(object sender, EventArgs e)
        {
           
        }

        private void toggleDGV_CheckedChanged(object sender, EventArgs e)
        {
            if (!toggleDGV.Checked)
            {
                dtgUsuarios.Visible = false;
            }
            else
            {
                dtgUsuarios.Visible = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            toggleDGV.Checked = false;
            lblUsuariosCadastrados.Text = "Cadastrar Usuário";
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnPessoais.Checked = true;
            btnMais.Visible = false;
            guna2VSeparator1.Visible = false;
            btnCadastrar.Visible = false;
            btnFechar.Visible = true;
            CadastrarUsuario cadastrar = new CadastrarUsuario();
            LoadForm(new CadastrarUsuario());
        }

        private void btnEnderecos_Click(object sender, EventArgs e)
        {

        }

        private void btnContrato_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblUsuariosCadastrados.Text = "Modo Edição";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            MaisInfo mais = new MaisInfo(usuario.Id);
            mais.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            btnFechar.Visible = false;
            panelExibir.Visible = false;
            btnCadastrar.Enabled = true;
            btnCadastrar.Visible = true;
            btnEditar.Visible = true;
            btnExcluir.Visible = true;
            toggleDGV.Checked = true;
        }
    }
}
