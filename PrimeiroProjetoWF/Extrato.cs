namespace PrimeiroProjetoWF {
    public partial class Extrato : UserControl {
        public Extrato() {
            InitializeComponent();
        }


        private void btnSairExtrato_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void dataInicio_ValueChanged(object sender, EventArgs e) {

        }

        private void btnExtrato_Click(object sender, EventArgs e) {
            Conexao db = new Conexao();
            db.Conectar();

            Extrato extrato = this;

            Usuario usuario = new Usuario();
            Movimentacoes movimentacoes = new Movimentacoes();

            int codigoUsuarioLogado = UsuarioLogado.Codigo;
            DateTime dataInicio = dtDataInicio.Value;
            DateTime dataFim = dtDataFim.Value;

            movimentacoes.GerarExtrato(db, dataInicio, dataFim, codigoUsuarioLogado, extrato.dtGridViewExtrato);

        }
    }
}
