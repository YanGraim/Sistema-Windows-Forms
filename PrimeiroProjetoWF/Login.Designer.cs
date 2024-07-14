namespace PrimeiroProjetoWF {
    partial class Login {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public virtual System.Drawing.Size MaximumSize { get; set; }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pictureBox1 = new PictureBox();
            txtLogin = new TextBox();
            btnEntrar = new Button();
            panel2 = new Panel();
            label5 = new Label();
            Develop = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            txtSenha = new TextBox();
            panel3 = new Panel();
            btnCadastrar = new Button();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            linkEsqueceuSenha = new LinkLabel();
            btnFechar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo_jovem_programador;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 530);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(27, 25, 22);
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Cursor = Cursors.IBeam;
            txtLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.ForeColor = Color.Silver;
            txtLogin.Location = new Point(91, 188);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Digite  seu login";
            txtLogin.Size = new Size(329, 30);
            txtLogin.TabIndex = 1;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(231, 119, 48);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.FromArgb(27, 25, 22);
            btnEntrar.Location = new Point(72, 345);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(166, 38);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(231, 119, 48);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Develop);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 530);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(27, 25, 22);
            label5.Location = new Point(126, 476);
            label5.Name = "label5";
            label5.Size = new Size(123, 17);
            label5.TabIndex = 4;
            label5.Text = "Lucas, Paulo, Yan";
            label5.Click += label5_Click;
            // 
            // Develop
            // 
            Develop.AutoSize = true;
            Develop.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Develop.ForeColor = Color.FromArgb(27, 25, 22);
            Develop.Location = new Point(119, 458);
            Develop.Name = "Develop";
            Develop.Size = new Size(80, 17);
            Develop.TabIndex = 1;
            Develop.Text = "Develop By";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkEsqueceuSenha);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(btnEntrar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 530);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_edifício_do_banco_50;
            pictureBox2.Location = new Point(205, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(71, 263);
            panel4.Name = "panel4";
            panel4.Size = new Size(349, 1);
            panel4.TabIndex = 16;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(27, 25, 22);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.Silver;
            txtSenha.Location = new Point(91, 245);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(329, 16);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(71, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 1);
            panel3.TabIndex = 14;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(231, 119, 48);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.FromArgb(27, 25, 22);
            btnCadastrar.Location = new Point(254, 345);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(166, 38);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(79, 130, 148);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(79, 130, 148);
            linkLabel1.Location = new Point(178, 476);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 17);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "alunos@gmail.com";
            linkLabel1.VisitedLinkColor = Color.Blue;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(72, 476);
            label6.Name = "label6";
            label6.Size = new Size(110, 17);
            label6.TabIndex = 11;
            label6.Text = "o nosso suporte";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(71, 458);
            label4.Name = "label4";
            label4.Size = new Size(366, 17);
            label4.TabIndex = 10;
            label4.Text = "Caso encontre algum problema com o sistema contactar ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(72, 440);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 9;
            label3.Text = "Suporte";
            label3.Click += label3_Click;
            // 
            // linkEsqueceuSenha
            // 
            linkEsqueceuSenha.ActiveLinkColor = Color.FromArgb(79, 130, 148);
            linkEsqueceuSenha.AutoSize = true;
            linkEsqueceuSenha.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkEsqueceuSenha.LinkColor = Color.FromArgb(79, 130, 148);
            linkEsqueceuSenha.Location = new Point(290, 284);
            linkEsqueceuSenha.Name = "linkEsqueceuSenha";
            linkEsqueceuSenha.Size = new Size(134, 17);
            linkEsqueceuSenha.TabIndex = 3;
            linkEsqueceuSenha.TabStop = true;
            linkEsqueceuSenha.Text = "Esqueceu a senha?";
            linkEsqueceuSenha.VisitedLinkColor = Color.Blue;
            linkEsqueceuSenha.LinkClicked += linkEsqueceuSenha_LinkClicked;
            // 
            // btnFechar
            // 
            btnFechar.AutoSize = true;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.FromArgb(231, 119, 48);
            btnFechar.Location = new Point(460, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(40, 40);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(27, 25, 22);
            label1.ForeColor = Color.Black;
            label1.Image = Properties.Resources.icons8_usuário_201;
            label1.Location = new Point(71, 187);
            label1.Name = "label1";
            label1.Size = new Size(20, 17);
            label1.TabIndex = 18;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(27, 25, 22);
            label2.ForeColor = Color.Black;
            label2.Image = Properties.Resources.icons8_senha_20;
            label2.Location = new Point(71, 243);
            label2.Name = "label2";
            label2.Size = new Size(20, 17);
            label2.TabIndex = 19;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(27, 25, 22);
            ClientSize = new Size(750, 530);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtLogin;
        private Button btnEntrar;
        private Panel panel2;
        private Label label5;
        private Label Develop;
        private Panel panel1;
        private Button btnFechar;
        private LinkLabel linkEsqueceuSenha;
        private Label label3;
        private Label label4;
        private Label label6;
        private LinkLabel linkLabel1;
        private Button btnCadastrar;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtSenha;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}
