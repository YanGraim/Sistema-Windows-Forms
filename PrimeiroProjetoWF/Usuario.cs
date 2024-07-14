using System.Data.SqlClient;


namespace PrimeiroProjetoWF {
    public class Usuario {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Loggin { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }

        public string InserirUsuario(Conexao db, Usuario usuario) {
            try {
                string sql = $"INSERT INTO USUARIO (nome, loggin, senha, confirmaSenha) VALUES ('{usuario.Nome}', '{usuario.Loggin}', '{usuario.Senha}', '{usuario.ConfirmaSenha}')";
                SqlCommand comando = new SqlCommand(sql, db.conn);
                comando.ExecuteNonQuery();
                return ("Usuario cadastrado com sucesso!");
            }
            catch (Exception e) {
                return e.Message;
            }
        }

        public bool LoginExiste(Conexao db, string loggin) {
            string sql = $"SELECT COUNT(*) FROM Usuario WHERE loggin = '{loggin}'";
            SqlCommand comando = new SqlCommand(sql, db.conn);
            int count = (int)comando.ExecuteScalar();
            return count > 0;
        }

        public bool BuscarUsuario(string loggin, string senha) {
            string sql = $"SELECT * FROM Usuario WHERE loggin = '{loggin}' AND senha ='{senha}'";
            Conexao db = new Conexao();
            db.Conectar();
            SqlCommand comando = new SqlCommand(sql, db.conn);
            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;
            return false;

        }

        public int ObterCodigoUsuario(string loggin) {
            Conexao db = new Conexao();
            db.Conectar();

            try {
                string sql = $"SELECT codigo FROM Usuario WHERE loggin = '{loggin}'";
                SqlCommand comando = new SqlCommand(sql, db.conn);
                int codigo = (int)comando.ExecuteScalar();
                return codigo;
            }
            finally {
                db.Desconectar();
            }
        }
    }
}
