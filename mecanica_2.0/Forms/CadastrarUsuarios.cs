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
    
    public partial class CadastrarUsuarios : Form
    {
        public CadastrarUsuarios()
        {

            InitializeComponent();
            Classes.Usuarios usuario = new Classes.Usuarios();
            dtgUsuarios.DataSource = usuario.ListarUsuariosDGV();

            dtgUsuarios.CellMouseEnter += dtgUsuarios_MouseHover;
          
            Acoes("Apagar", Properties.Resources.trash);
            Acoes("Editar", Properties.Resources.lapis);
            Acoes("Mais", Properties.Resources.mais);

        }
        private void Acoes(string header, Image icon)
        {
            DataGridViewImageColumn col = new DataGridViewImageColumn();
            col.HeaderText = header;
            col.Image = icon;
            col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            col.Width = 10;
            col.FillWeight = 16;
            dtgUsuarios.Columns.Add(col);
        }

        private void dtgUsuarios_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Impede erro ao passar no header
           
        }

        private void dtgUsuarios_MouseHover(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex < 0) return;

            // Colunas dos ícones (ex: 0,1,2)
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                dtgUsuarios.Cursor = Cursors.Hand;
            }
            else
            {
                dtgUsuarios.Cursor = Cursors.Default;
            }
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dtgUsuarios.Rows[e.RowIndex].Cells["id"].Value);

            if (e.ColumnIndex == 0)
            {
                // Ação de excluir
                MessageBox.Show("Excluir usuário na linha " + id);
            }
            else if (e.ColumnIndex == 1)
            {
                // Ação de editar
                MessageBox.Show("Editar usuário na linha " + id);
            }
            else if (e.ColumnIndex == 2)
            {
                MaisInfo maisInfo = new MaisInfo(id);
                maisInfo.ShowDialog();

            }
        }
    }
}
