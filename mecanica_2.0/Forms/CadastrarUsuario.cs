using Guna.UI2.WinForms;
using mecanica_2._0.includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mecanica_2._0.Forms
{
    public partial class CadastrarUsuario : Form
    {
        includes.MensagemBox mensagem = new includes.MensagemBox();
        Classes.CargaHoraria cargaHoraria = new Classes.CargaHoraria();
        Classes.TipoContrato tipoContrato = new Classes.TipoContrato();
        Classes.Setor setor = new Classes.Setor();
        Classes.Relacionamento relacionamento = new Classes.Relacionamento();
        Classes.Cargo cargo = new Classes.Cargo();
        CadastrarTelefone Telefone = new CadastrarTelefone();
        MenuPrincipal principal = new MenuPrincipal();

        public CadastrarUsuario()
        {
            InitializeComponent();
            PreencherComboBox();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = mensagem.Box("AVISO!", "Deseja Realmente cancelar o cadastro? \nTodos os dados não serão salvos!", includes.MensagemBox.Buttons.YesNo, includes.MensagemBox.Icons.Warning);
            if (r == DialogResult.Yes) { Close(); }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Telefone.ShowDialog();
        }
        private async void PreencherComboBox()
        {

            cmbCargaHoraria.DataSource = await cargaHoraria.Listar();
            cmbCargaHoraria.DisplayMember = "carga";
            cmbCargaHoraria.ValueMember = "id";

            cmbTipo.DataSource = await tipoContrato.Listar();
            cmbTipo.DisplayMember = "tipo";
            cmbTipo.ValueMember = "id";

            cmbSetor.DataSource = await setor.Listar();
            cmbSetor.DisplayMember = "nome";
            cmbSetor.ValueMember = "id";

            cmbRelacionamento.DataSource = await relacionamento.Listar();
            cmbRelacionamento.DisplayMember = "nome";
            cmbRelacionamento.ValueMember = "id";

            cmbCargos.DataSource = await cargo.Listar();
            cmbCargos.DisplayMember = "nome";
            cmbCargos.ValueMember = "id";

        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            foreach (Control control in panelShadow.Controls)
            {
                if (control is Guna2TextBox)
                {
                    ((Guna2TextBox)control).Clear();
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
