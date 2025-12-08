using MySqlConnector;
using MySqlConnector.Authentication;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;


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
        public int id_contrato_usuario_fk { get; set; }


        public DataTable Listar()
        {
            string comando = "SELECT * FROM usuarios;";


            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public DataTable ListarUsuariosDGV()
        {
            string comando = "SELECT usuarios.id, (usuarios.nome)AS \"Nome\", (usuarios.email) AS \"E-mail\", (usuarios.cpf) AS \"CPF\", (usuarios.data_nascimento) AS \"Data de Nascimento\", (usuarios.observacoes) AS \"Observações\", (cargo.nome) AS \"Cargo\", (status_relacionamento.nome) AS \"Relacionamento\"\r\nfrom usuarios\r\n\r\nINNER JOIN cargo ON id_cargo_fk = (cargo.id) \r\nINNER JOIN status_relacionamento ON id_status_relacionamento_fk = status_relacionamento.id;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public DataTable ListarPorID()
        {
            string comando = "SELECT * FROM usuarios WHERE id = @id";
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
        public DataTable ListarPorIDContrato()
        {
            string comando = "SELECT * FROM usuarios WHERE id_contrato_usuario_fk = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", id_contrato_usuario_fk);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

    }
}
