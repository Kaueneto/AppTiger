namespace AppTiger
{
    internal class NpgsqlConnection
    {
        private string connStr;

        public NpgsqlConnection(string connStr)
        {
            this.connStr = connStr;
        }
    }
}