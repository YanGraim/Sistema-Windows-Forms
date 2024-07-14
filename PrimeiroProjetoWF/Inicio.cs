using System.Runtime.InteropServices;

namespace PrimeiroProjetoWF {
    public partial class TelaInicio : Form {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public TelaInicio() {
            InitializeComponent();
            Design();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            inicioMenu1.BringToFront();

        }
        private void Design() {
            subMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false) {

                subMenu.Visible = true;
            }
            else {
                subMenu.Visible = false;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e) {
            showSubMenu(subMenu);
            depositaruc1.Hide();
            inicioMenu1.Show();
            inicioMenu1.BringToFront();
        }

        private void btnDepositar_Click(object sender, EventArgs e) {
            PnlNav.Height = btnDepositar.Height;
            PnlNav.Top = btnDepositar.Top;
            PnlNav.Left = btnDepositar.Left;

            inicioMenu1.Hide();
            depositaruc1.Show();
            depositaruc1.BringToFront();

        }

        private void btnSacar_Click(object sender, EventArgs e) {
            PnlNav.Height = btnSacar.Height;
            PnlNav.Top = btnSacar.Top;
            PnlNav.Left = btnSacar.Left;

            inicioMenu1.Hide();
            sacar1.Show();
            sacar1.BringToFront();

        }



        private void btnExtrato_Click(object sender, EventArgs e) {
            PnlNav.Height = btnExtrato.Height;
            PnlNav.Top = btnExtrato.Top;
            PnlNav.Left = btnExtrato.Left;
            inicioMenu1.Hide();
            extrato1.Show();
            extrato1.BringToFront();
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        //public void AtualizarNome() {
        //    Conexao db = new Conexao();
        //    db.Conectar();

        //    Usuario usuario = new Usuario();
        //    string name = usuario.Nome;
        //    string saldoAtual = movimentacoes.BuscarSaldo(db, codigoUsuario);

        //    SaldoDeposito.Text = $"Saldo Atual: R$ {saldoAtual:N2}";

        //    db.Desconectar();
        //}

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e) {
            Conexao db = new Conexao();
            db.Conectar();

            Usuario usuario = new Usuario();
            string name = usuario.Nome;

            txtNomeUsuario.Text = $"Bem vindo, {name}";
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e) {
            MessageBox.Show("Deseja sair?", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            var TelaLogin = new Login();
            TelaLogin.Show();
            this.Visible = false;
        }
    }
}

