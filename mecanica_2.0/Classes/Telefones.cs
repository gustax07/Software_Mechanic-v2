using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace mecanica_2._0.Classes
{
    public class Telefones
    {
        public int Id { get; set; }
        public int Id_usuario_fk { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public DataTable ListarPorID()
        {
            string comando = "SELECT * FROM telefone WHERE id_usuario_fk = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id_usuario_fk);
            cmd.Prepare();
            DataTable tabela = new DataTable();

            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
    }

}
