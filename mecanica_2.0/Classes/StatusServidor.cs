using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace mecanica_2._0.Classes
{
    public class StatusServidor
    {
        public static bool VerificarConexao()
        {
            try
            {
                Banco conexaoBD = new Banco();
                MySqlConnection con = conexaoBD.ObterConexao();
                MySqlConnection conexao = new MySqlConnection(con.ConnectionString);
                {
                    conexao.Open();
                    return true;
                }
            }
            catch (MySqlException)
            {
                return false;
            }
        }
    }
}
