using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace mecanica_2._0.Classes
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logadoura { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string complemento { get; set; }
        public int Id_usuario_fk { get; set; }

        public DataTable ListarPorID()
        {
            string comando = "SELECT * FROM endereco WHERE id_usuario_fk = @id";
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
