using System.Data.SqlClient;

namespace PrimeiroProjetoWF {
    public class Conexao {
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BR73Q67;Initial Catalog=Jovem_Programador;Integrated Security=True;Encrypt=False");

        public void Conectar() {
            conn.Open();
        }

        public void Desconectar() {
            conn.Close();
        }
    }
}
