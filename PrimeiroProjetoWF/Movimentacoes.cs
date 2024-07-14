using System.Data;
using System.Data.SqlClient;

namespace PrimeiroProjetoWF {
    public class Movimentacoes {
        public int CodigoUsuario { get; set; }
        public string? TipoOperacao { get; set; }
        public double Valor { get; set; }
        public DateTime DataHora { get; set; }
        public double Saldo { get; set; }


        public string Movimentacao(Conexao db, Movimentacoes movimentacoes) {
            try {
                movimentacoes.Saldo = BuscarSaldo(db, movimentacoes.CodigoUsuario);
                if (movimentacoes.TipoOperacao == "Deposito") {
                    movimentacoes.Saldo += movimentacoes.Valor;
                }
                else if (movimentacoes.TipoOperacao == "Saque") {
                    movimentacoes.Saldo -= movimentacoes.Valor;
                }

                string sql = $"INSERT INTO Movimentacoes (tipoOperacao, Valor, dataHora, codigoUsuario, saldo) VALUES ('{movimentacoes.TipoOperacao}', '{movimentacoes.Valor}', '{movimentacoes.DataHora}', '{movimentacoes.CodigoUsuario}', '{movimentacoes.Saldo}')";
                SqlCommand comando = new SqlCommand(sql, db.conn);
                comando.ExecuteNonQuery();
                return ("Valor inserido com sucesso!");
            }
            catch (Exception e) {
                return e.Message;
            }
        }

        public double BuscarSaldo(Conexao db, int codigoUsuario) {
            double saldo = 0;
            string sql = $"SELECT ISNULL(SUM(CASE WHEN tipoOperacao = 'Deposito' THEN valor ELSE -valor END), 0) AS saldo " +
                         $"FROM Movimentacoes WHERE codigoUsuario = {codigoUsuario}";
            SqlCommand comando = new SqlCommand(sql, db.conn);
            var resultado = comando.ExecuteScalar();

            if (resultado != DBNull.Value) {
                saldo = Convert.ToDouble(resultado);
            }

            return saldo;
        }

        public double AtualizarSaldo(Conexao db, int codigoUsuario) {
            double saldoAtual = BuscarSaldo(db, codigoUsuario);
            return saldoAtual;
        }

        public void GerarExtrato(Conexao db, DateTime dataInicio, DateTime dataFim, int codigoUsuarioLogado, DataGridView dtGridViewExtrato) {
            string sql = $"SELECT tipoOperacao as [Operação], valor as Valor, saldo as Saldo, dataHora as [Data] FROM Movimentacoes WHERE dataHora >= '{dataInicio}' AND dataHora <= '{dataFim}' AND codigoUsuario = {codigoUsuarioLogado}";
            SqlCommand comando = new SqlCommand(sql, db.conn);
            using (SqlDataAdapter da = new SqlDataAdapter(sql, db.conn)) {
                using (DataTable dt = new DataTable()) {
                    da.Fill(dt);

                    dtGridViewExtrato.DataSource = dt;

                    dtGridViewExtrato.Columns["Valor"].DefaultCellStyle.Format = "N2";
                    dtGridViewExtrato.Columns["Saldo"].DefaultCellStyle.Format = "N2";
                }
            }
        }
    }
}
