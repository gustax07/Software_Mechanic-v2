using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace mecanica_2._0.Classes
{
    public class Contrato
    {
        public int Id { get; set; }
        public DateTime Data_Contratado { get; set; }
        public DateTime Data_Expiracao { get; set; }
        public Double Salario { get; set; }
        public int id_carga_horaria_fk { get; set; }
        public int id_tipo_contrato_fk { get; set; }
        public int id_status_contrato_fk { get; set; }
        public int id_setor_fk { get; set; }

        public DataTable ListarPorID()
        {
            string comando = "SELECT * FROM contrato_usuarios WHERE id = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
      
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            DataTable tabela = new DataTable();

            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public DataTable ListarComInnerJoin()
        {
            string comando = "SELECT contrato_usuarios.id, contrato_usuarios.data_contratado, contrato_usuarios.data_expiracao, contrato_usuarios.salario, carga_horaria.carga, tipo_contrato.tipo, status_contrato.nome, setor.nome\r\nFROM contrato_usuarios\r\nINNER JOIN carga_horaria ON id_carga_horaria_fk = carga_horaria.id\r\nINNER JOIN tipo_contrato ON id_tipo_contrato_fk = tipo_contrato.id\r\nINNER JOIN status_contrato ON id_status_contrato_fk = status_contrato.id\r\nINNER JOIN setor ON id_setor_fk = setor.id\r\nWHERE contrato_usuarios.id = 1;";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            DataTable tabela = new DataTable();

            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
    }
}
