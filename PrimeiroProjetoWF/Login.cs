using System.Runtime.InteropServices;

namespace PrimeiroProjetoWF {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            Conexao db = new Conexao();
            db.Conectar();

            Usuario usuario = new Usuario();
            usuario.Loggin = txtLogin.Text;
            usuario.Senha = txtSenha.Text;


            var retorno = usuario.BuscarUsuario(usuario.Loggin, usuario.Senha);

            if (!retorno) {
                MessageBox.Show("Login ou senha incorretos");
            }

            if (retorno) {
                UsuarioLogado.Codigo = usuario.ObterCodigoUsuario(usuario.Loggin);
                UsuarioLogado.Loggin = usuario.Loggin;
                var TelaInicio = new TelaInicio();
                TelaInicio.Show();
                this.Visible = false;
            }

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void linkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e) {

        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            var TelaCadastro = new Cadastro();
            TelaCadastro.Show();
            this.Visible = false;
        }
    }
}
