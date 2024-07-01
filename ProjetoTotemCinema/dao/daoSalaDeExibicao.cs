using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTotemCinema.model;
using MySql;
using MySql.Data.MySqlClient;

namespace ProjetoTotemCinema.dao
{
    internal class daoSalaDeExibicao
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataReader cursor;
        private String comandoSql1 = "";
        private String comandoSql2 = "";
        private String strconexao;

        public daoSalaDeExibicao()
        {
            strconexao = "server=localhost;userid=root;password=#Mortadela789;database=bd_biblioteca";
            conexao = new(strconexao);
            conexao.Open();
        }
        public bool Salvar(SalaDeExibicao sala)
        {
            bool retorno = true;
            int qtdregistrosafetados = 0;

            
            comandoSql1 = "Insert into tbl_sala (nome) values (@nome)";
            comandoSql2 = "Insert into tbl_sala (assentos) values (@assentos)";
            comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = comandoSql1;
            comando.CommandText = comandoSql2;
            comando.Parameters.AddWithValue("@nome", sala.getNome());
            comando.Parameters.AddWithValue("@assentos", sala.getAssentos());
            comando.Prepare();
            qtdregistrosafetados = comando.ExecuteNonQuery();
            if (qtdregistrosafetados > 0)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }


            return retorno;

        }
        public bool ConsultaSalaDeExibicao(String nome)
        {
            bool retorno = true;

            comandoSql1 = "Select * from tbl_sala where nome = @nome";
            comando = new();
            comando.Connection = conexao;
            comando.CommandText= comandoSql1;
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Prepare();
            cursor = comando.ExecuteReader();
            if (cursor.HasRows)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
