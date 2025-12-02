using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace mecanica_2._0.Classes
{
    public class Banco
    {
        public MySqlConnection Conexao()
        {
            string servidor = "localhost";
            string banco = "newmecanica";
            string usuario = "root";
            string senha = "";
            string stringDeConexao = $"Server={servidor};Database={banco};User ID={usuario};Password={senha};";

            MySqlConnection con = new MySqlConnection(stringDeConexao);
            return con;
        }
    }
}
