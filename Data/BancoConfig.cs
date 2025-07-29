using System.Data.SQLite;
using System.IO;

namespace ProjetoBase.Data
{
    public static class BancoConfig
    {
        private static string _path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dado.db");
        private static string _connString = $"Data Source ={_path};Version=3";

        public static void VerificarOucriarBanco()
        {
            if (!File.Exists(_path))
            {
                SQLiteConnection.CreateFile(_path);
            }
            else
            {
                CriarTabelas();
                CriarUsuarioRoot();
            }
        }

        private static void CriarTabelas()
        {
            using (var conn = new SQLiteConnection(_connString))
            {
                conn.Open();

                string sql = @"
                            CREATE TABLE IF NOT EXISTS Usuarios(
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Nome TEXT NOT NULL,
                                Login TEXT NOT NULL,
                                Senha TEXT NOT NULL,
                                Adm INTEGER NOT NULL DEFAULT 0)
                            ";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void CriarUsuarioRoot()
        {
            using (var conn = new SQLiteConnection(_connString))
            {
                conn.Open();

                string query = @"
                               INSERT INTO Usuarios 
                                    (Nome, Login, Senha, Adm)
                                    VALUES
                                    (Root, ADM, ADM, 1 )
                                ";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static string GetConnectionString() => _connString;
    }
}
