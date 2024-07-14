namespace PrimeiroProjetoWF {
    public partial class Sacar : UserControl {
        public Sacar() {
            InitializeComponent();
        }

        private void SacarUC_Load(object sender, EventArgs e) {
            AtualizarSaldoLabel();
        }

        private void btnSairSacar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnSacar_Click(object sender, EventArgs e) {
            Conexao db = new Conexao();
            db.Conectar();

            Movimentacoes movimentacoes = new Movimentacoes();
            movimentacoes.TipoOperacao = "Saque";
            if (string.IsNullOrWhiteSpace(txtValorSaque.Text) || !double.TryParse(txtValorSaque.Text, out double valorDeposito)) {
                MessageBox.Show("Valor de depósito inválido. Por favor, insira um valor numérico.");
                txtValorSaque.Clear();
                return;
            }
            movimentacoes.Valor = double.Parse(txtValorSaque.Text);
            movimentacoes.CodigoUsuario = UsuarioLogado.Codigo;
            movimentacoes.DataHora = DateTime.Now;

            double saldoAtual = movimentacoes.BuscarSaldo(db, movimentacoes.CodigoUsuario);

            if (movimentacoes.Valor <= 0) {
                MessageBox.Show("Não é permitido sacar valores negativos ou iguais a 0.");
                txtValorSaque.Clear();
            }
            else if (saldoAtual >= movimentacoes.Valor) {
                saldoAtual -= movimentacoes.Valor;
                MessageBox.Show("Saque realizado com sucesso!");
                movimentacoes.Saldo = saldoAtual;
                movimentacoes.Movimentacao(db, movimentacoes);
                txtValorSaque.Clear();
                AtualizarSaldoLabel();

                DepositarUC depositarUC = FindForm().Controls.Find("depositaruc1", true).FirstOrDefault() as DepositarUC;
                if (depositarUC != null) {
                    depositarUC.AtualizarSaldoLabel();
                }
            }
            else {
                MessageBox.Show("Seu saldo é insuficiente para saque!");
                txtValorSaque.Clear();
            }
        }


        private void label1_Click(object sender, EventArgs e) {

        }

        private void SaldoSaque_Click(object sender, EventArgs e) {

        }

        public void AtualizarSaldoLabel() {
            Conexao db = new Conexao();
            db.Conectar();

            Movimentacoes movimentacoes = new Movimentacoes();
            int codigoUsuario = UsuarioLogado.Codigo;
            double saldoAtual = movimentacoes.BuscarSaldo(db, codigoUsuario);

            SaldoSaque.Text = $"Saldo Atual: R$ {saldoAtual:N2}";

            db.Desconectar();
        }

        private void txtValorSaque_TextChanged(object sender, EventArgs e) {
            AtualizarSaldoLabel();
        }

        private void lblVisaoSaque_Click(object sender, EventArgs e) {
            if (lblVisaoSaque.Tag.ToString() == "oculto") {
                lblVisaoSaque.Image = Properties.Resources.icons8_visível_20;
                lblVisaoSaque.Tag = "visivel";
                SaldoSaque.Visible = true;
            }
            else {
                lblVisaoSaque.Image = Properties.Resources.icons8_ocultar_20;
                lblVisaoSaque.Tag = "oculto";
                SaldoSaque.Visible = false;
            }
        }
    }
}

