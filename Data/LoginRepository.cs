
using System.Data.SQLite;
using System.DirectoryServices;

namespace ProjetoBase.Data
{
    public static class LoginRepository
    {

        public static void VerificaLogin(string username, string senha)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(senha))
            {
                using (var conn = new SQLiteConnection(BancoConfig.GetConnectionString()))
                {
                    conn.Open();

                    string sql = "SELECT COUNT(*) FROM Usuarios WHERE Login = @login AND Senha = @senha";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", username);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Login ou senha inválidos!");
                        }
                    }
                }
            }
        }
    }
}
