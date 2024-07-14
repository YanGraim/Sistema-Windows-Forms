using System.Runtime.InteropServices;


namespace PrimeiroProjetoWF {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void btnCadastrese_Click(object sender, EventArgs e) {
            Conexao db = new Conexao();
            db.Conectar();

            Usuario usuario = new Usuario();
            usuario.Nome = txtNomeCadastro.Text;
            usuario.Loggin = txtEmailCadastro.Text;
            usuario.Senha = txtSenhaCadastro.Text;
            usuario.ConfirmaSenha = txtConfirmaSenhaCadastro.Text;

            if (string.IsNullOrEmpty(usuario.Nome) || string.IsNullOrEmpty(usuario.Loggin) || string.IsNullOrEmpty(usuario.Senha) || string.IsNullOrEmpty(usuario.ConfirmaSenha)) {
                MessageBox.Show("Por favor, preencha todos os campos");
            }
            if (usuario.Senha != usuario.ConfirmaSenha) {
                MessageBox.Show("Senhas não correspondem!");
            }
            else {
                if (usuario.LoginExiste(db, usuario.Loggin)) {
                    MessageBox.Show("Login já está em uso. Por favor, escolha um login diferente.");
                }
                else {
                    string resultado = usuario.InserirUsuario(db, usuario);
                    MessageBox.Show(resultado);

                    if (resultado == "Usuário cadastrado com sucesso!") {
                        var TelaLogin = new Login();
                        TelaLogin.Show();
                        this.Visible = false;
                    }
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e) {
            MessageBox.Show("Deseja voltar?", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            var TelaLogin = new Login();
            TelaLogin.Show();
            this.Visible = false;
        }
    }
}
