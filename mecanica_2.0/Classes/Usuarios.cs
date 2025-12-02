using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector.Authentication;
using System.Data.SqlClient;

namespace mecanica_2._0.Classes
{
    public class Usuarios
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CPF   { get; set; }
        public DateTime Data_Nascimento { get; set; }


        public DataTable Listar()
        {
            string sql = "SELECT * FROM usuarios";

            Banco banco = new Banco();
            using (MySqlConnection con = banco.Conexao())
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable tabela = new DataTable();
                    tabela.Load(reader);
                    return tabela;
                }
            }
        }
    }
}
