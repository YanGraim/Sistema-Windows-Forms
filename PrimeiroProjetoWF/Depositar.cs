namespace PrimeiroProjetoWF {
    public partial class DepositarUC : UserControl {
        public DepositarUC() {
            InitializeComponent();
        }

        private void DepositarUC_Load(object sender, EventArgs e) {
            AtualizarSaldoLabel();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnSairDepositar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnDepositar_Click(object sender, EventArgs e) {
            Conexao db = new Conexao();
            db.Conectar();

            Movimentacoes movimentacoes = new Movimentacoes();
            movimentacoes.TipoOperacao = "Deposito";
            if (string.IsNullOrWhiteSpace(txtValorDeposito.Text) || !double.TryParse(txtValorDeposito.Text, out double valorDeposito)) {
                MessageBox.Show("Valor de depósito inválido. Por favor, insira um valor numérico.");
                txtValorDeposito.Clear();
                return;
            }
            movimentacoes.Valor = double.Parse(txtValorDeposito.Text);
            movimentacoes.CodigoUsuario = UsuarioLogado.Codigo;
            movimentacoes.DataHora = DateTime.Now;

            double saldoAtual = movimentacoes.BuscarSaldo(db, movimentacoes.CodigoUsuario);
            if (movimentacoes.Valor <= 0) {
                MessageBox.Show("Não é permitido depositar valores negativos ou iguais a 0.");
                txtValorDeposito.Clear();
            }
            else {
                saldoAtual += movimentacoes.Valor;
                MessageBox.Show("Deposito realizado com sucesso!");
                movimentacoes.Saldo = saldoAtual;
                movimentacoes.Movimentacao(db, movimentacoes);
                txtValorDeposito.Clear();
                AtualizarSaldoLabel();


                Sacar sacarUC = FindForm().Controls.Find("sacar1", true).FirstOrDefault() as Sacar;
                if (sacarUC != null) {
                    sacarUC.AtualizarSaldoLabel();
                }
            }
        }

        public void AtualizarSaldoLabel() {
            Conexao db = new Conexao();
            db.Conectar();

            Movimentacoes movimentacoes = new Movimentacoes();
            int codigoUsuario = UsuarioLogado.Codigo;
            double saldoAtual = movimentacoes.BuscarSaldo(db, codigoUsuario);

            SaldoDeposito.Text = $"Saldo Atual: R$ {saldoAtual:N2}";

            db.Desconectar();
        }

        private void txtValorDeposito_TextChanged(object sender, EventArgs e) {
            AtualizarSaldoLabel();
        }

        private void SaldoDeposito_Click(object sender, EventArgs e) {

        }

        private void lblVisao_Click(object sender, EventArgs e) {
            if (lblVisao.Tag.ToString() == "oculto") {
                lblVisao.Image = Properties.Resources.icons8_visível_20;
                lblVisao.Tag = "visivel";
                SaldoDeposito.Visible = true;
            }
            else {
                lblVisao.Image = Properties.Resources.icons8_ocultar_20;
                lblVisao.Tag = "oculto";
                SaldoDeposito.Visible = false;
            }
        }
    }
}
