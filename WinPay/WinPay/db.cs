using Npgsql;
using System;

namespace WinPay
{
    public static class Db
    {
        public static NpgsqlConnection Conexao { get; private set; }

        /// <summary> Monta a connection string a partir das variáveis de ambiente. </summary>
        private static string BuildConnStr()
        {
            // Se a variável não existir, usa valor padrão (null‑coalescing)
            string host = Environment.GetEnvironmentVariable("DB_HOST");
            string port = Environment.GetEnvironmentVariable("DB_PORT");
            string db = Environment.GetEnvironmentVariable("DB_NAME");
            string user = Environment.GetEnvironmentVariable("DB_USER");
            string password = Environment.GetEnvironmentVariable("DB_PASS");

            return
                $"Host={host};" +
                $"Port={port};" +
                $"Database={db};" +
                $"Username={user};" +
                $"Password={password};" +
                "Ssl Mode=Require;Trust Server Certificate=true;" +
                "Pooling=true;Keepalive=30;" +
                "Timeout=15;CommandTimeout=60;";
        }

        public static void Abrir()
        {
            if (Conexao == null || Conexao.State != System.Data.ConnectionState.Open)
            {
                Conexao = new NpgsqlConnection(BuildConnStr());
                Conexao.Open();
            }
        }

        public static void Fechar()
        {
            if (Conexao != null && Conexao.State != System.Data.ConnectionState.Closed)
            {
                Conexao.Close();
                Conexao.Dispose();
            }
        }
    }
}
