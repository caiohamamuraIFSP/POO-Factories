using System;

namespace _01ProgramandoParaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexao = new MeuSqlServer();
            conexao.Query("");
            conexao.Query("");
            conexao.Query("");
            conexao.Query("");
            conexao.Query("");
            conexao.Query("");
            conexao.Query("");
            conexao.Query("");
            conexao.Query("");
            conexao.Query("");
        }
    }

    abstract class SqlConnection
    {
        public abstract void Query(string query);
    }

    class SqlServerConnection 
    {
        override public void Query(string query) {

        }
    }

    class MeuMySql : SqlConnection
    {
        MySqlConnection conexao;

        public override void Query(string query)
        {
            conexao.MySqlQuery(query);
        }
    }

    class MySqlConnection 
    {
        public void MySqlQuery(string query) {}
    }

    class MeuSqlServer : SqlConnection
    {
        SqlServerConnection conexao;
        public override void Query(string query)
        {
            conexao.Query(query);
        }
    }
}

