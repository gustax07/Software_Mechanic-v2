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

        public async Task<DataTable> ListarPorID()
        {
            string comando = "SELECT * FROM telefone WHERE id_usuario_fk = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = await conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id_usuario_fk);
            cmd.Prepare();
            DataTable tabela = new DataTable();

            tabela.Load(await cmd.ExecuteReaderAsync());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public async Task<bool> Cadastrar()
        {
            string comando = "INSERT INTO telefone (numero, id_usuario_fk) " +
                 "VALUES (@numero, @id_usuario_fk)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = await conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@numero", Numero);
            cmd.Parameters.AddWithValue("@id_usuario_fk", Id_usuario_fk);

            cmd.Prepare();
            try
            {
                if (await cmd.ExecuteNonQueryAsync() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}


