using Guna.UI2.WinForms;
using mecanica_2._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace mecanica_2._0.Forms
{
    public partial class MaisInfo : Form
    {
        Usuarios usuario = new Usuarios();
        Contrato contrato = new Contrato();
        Telefones Telefones = new Telefones();
        public MaisInfo(int id_usuario)
        {
            InitializeComponent();
            UsuarioCampos(id_usuario);
            lblTelefonesTxt.Visible = false;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuarioCampos(int id)
        {
            usuario.Id = id;

            DataTable resultado = usuario.ListarPorID();
            if (resultado.Rows.Count > 0)
            {
                lblInformacoesDetalhadas.Text = "Informações de " + resultado.Rows[0][1].ToString();

                contrato.Id = (int)resultado.Rows[0][7];
                DataTable resultadoContrato = contrato.ListarComInnerJoin();
                if (resultadoContrato.Rows.Count > 0)
                {
                    txtDataContratado.Text = Convert.ToDateTime(resultadoContrato.Rows[0][1]).ToString("dd/MM/yyyy HH:mm");
                    txtContratoExpiracao.Text = Convert.ToDateTime(resultadoContrato.Rows[0][2]).ToString("dd/MM/yyyy HH:mm");
                    txtSalario.Text = Convert.ToDecimal(resultadoContrato.Rows[0][3]).ToString("C2");
                    txtCargaHoraria.Text = resultadoContrato.Rows[0][4].ToString();
                    txtTipo.Text = resultadoContrato.Rows[0][5].ToString();
                    txtStatus.Text = resultadoContrato.Rows[0][6].ToString();
                    txtSetor.Text = resultadoContrato.Rows[0][7].ToString();
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
            Telefones.Id_usuario_fk = id;
            DataTable resultadoTelefone = Telefones.ListarPorID();
            if (resultadoTelefone.Rows.Count > 0)
            {
                for (int i = 0; i < resultadoTelefone.Rows.Count; i++)
                {
                    CriarTelefoneTextBox(resultadoTelefone.Rows[i][1].ToString(), i + 1);
                }
            }
            else
            {
                lblTelefonesTxt.Visible = true;
                
            }
        }
        private void CriarTelefoneTextBox(string numero, int id)
        {
            int colunas = 0;
            int posY = 10;
            int posX = 10;

            for (int i = 0; i < id; i++)
            {
                colunas++;
                Guna2TextBox txtTelefone = new Guna2TextBox();

                txtTelefone.Text = numero.ToString();
                txtTelefone.Name = "txtTelefone" + id;
                txtTelefone.Location = new Point(posX, posY);
                posX += txtTelefone.Width + 10;

                paneltxtTelefones.Controls.Add(txtTelefone);
                if (colunas == 3)
                {
                    colunas = 0;
                    posX = 10;
                    posY += txtTelefone.Height + 5;
                }
                DesignerTextBox(txtTelefone);
            }

        }
        private void DesignerTextBox(Guna2TextBox textBox)
        {
            textBox.BackColor = Color.Transparent;
            textBox.BorderRadius = 10;
            textBox.BorderThickness = 0;
            textBox.Cursor = Cursors.IBeam;
            textBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBox.DisabledState.FillColor = Color.FromArgb(35, 65, 96);
            textBox.DisabledState.ForeColor = Color.White;
            textBox.Enabled = false;
            textBox.Font = new Font("Segoe UI", 9F);
            textBox.Size = new Size(200, 26);
            textBox.IconLeft = Properties.Resources.telefone;
        }
    }
}
