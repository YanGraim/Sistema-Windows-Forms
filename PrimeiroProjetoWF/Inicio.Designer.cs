namespace PrimeiroProjetoWF {
    partial class TelaInicio {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            sideMenu = new Panel();
            btnSair = new Button();
            subMenu = new Panel();
            PnlNav = new Panel();
            btnExtrato = new Button();
            btnSacar = new Button();
            btnDepositar = new Button();
            btnMenu = new Button();
            logoMenu = new Panel();
            txtNomeUsuario = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            extrato1 = new Extrato();
            sacar1 = new Sacar();
            depositaruc1 = new DepositarUC();
            inicioMenu1 = new InicioMenu();
            sideMenu.SuspendLayout();
            subMenu.SuspendLayout();
            logoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sideMenu
            // 
            sideMenu.AutoScroll = true;
            sideMenu.BackColor = Color.FromArgb(231, 119, 48);
            sideMenu.Controls.Add(btnSair);
            sideMenu.Controls.Add(subMenu);
            sideMenu.Controls.Add(btnMenu);
            sideMenu.Controls.Add(logoMenu);
            sideMenu.Dock = DockStyle.Left;
            sideMenu.Location = new Point(0, 0);
            sideMenu.Name = "sideMenu";
            sideMenu.Size = new Size(250, 530);
            sideMenu.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Image = Properties.Resources.icons8_sair_20;
            btnSair.Location = new Point(12, 490);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(28, 28);
            btnSair.TabIndex = 0;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // subMenu
            // 
            subMenu.BackColor = Color.FromArgb(64, 64, 64);
            subMenu.Controls.Add(PnlNav);
            subMenu.Controls.Add(btnExtrato);
            subMenu.Controls.Add(btnSacar);
            subMenu.Controls.Add(btnDepositar);
            subMenu.Dock = DockStyle.Top;
            subMenu.Location = new Point(0, 142);
            subMenu.Name = "subMenu";
            subMenu.Size = new Size(250, 120);
            subMenu.TabIndex = 2;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.FromArgb(27, 25, 22);
            PnlNav.Location = new Point(0, 24);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(3, 100);
            PnlNav.TabIndex = 3;
            // 
            // btnExtrato
            // 
            btnExtrato.BackColor = Color.FromArgb(231, 119, 48);
            btnExtrato.Cursor = Cursors.Hand;
            btnExtrato.Dock = DockStyle.Top;
            btnExtrato.FlatAppearance.BorderSize = 0;
            btnExtrato.FlatStyle = FlatStyle.Flat;
            btnExtrato.ForeColor = Color.Black;
            btnExtrato.Image = Properties.Resources.icons8_tips_20;
            btnExtrato.ImageAlign = ContentAlignment.MiddleLeft;
            btnExtrato.Location = new Point(0, 80);
            btnExtrato.Name = "btnExtrato";
            btnExtrato.Padding = new Padding(35, 0, 0, 0);
            btnExtrato.Size = new Size(250, 41);
            btnExtrato.TabIndex = 3;
            btnExtrato.Text = "Extrato";
            btnExtrato.TextAlign = ContentAlignment.MiddleLeft;
            btnExtrato.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExtrato.UseVisualStyleBackColor = false;
            btnExtrato.Click += btnExtrato_Click;
            // 
            // btnSacar
            // 
            btnSacar.BackColor = Color.FromArgb(231, 119, 48);
            btnSacar.Cursor = Cursors.Hand;
            btnSacar.Dock = DockStyle.Top;
            btnSacar.FlatAppearance.BorderSize = 0;
            btnSacar.FlatStyle = FlatStyle.Flat;
            btnSacar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSacar.ForeColor = Color.Black;
            btnSacar.Image = Properties.Resources.icons8_sacar_dinheiro_20;
            btnSacar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSacar.Location = new Point(0, 40);
            btnSacar.Name = "btnSacar";
            btnSacar.Padding = new Padding(35, 0, 0, 0);
            btnSacar.Size = new Size(250, 40);
            btnSacar.TabIndex = 1;
            btnSacar.Text = "Sacar";
            btnSacar.TextAlign = ContentAlignment.MiddleLeft;
            btnSacar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSacar.UseVisualStyleBackColor = false;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.FromArgb(231, 119, 48);
            btnDepositar.Cursor = Cursors.Hand;
            btnDepositar.Dock = DockStyle.Top;
            btnDepositar.FlatAppearance.BorderSize = 0;
            btnDepositar.FlatStyle = FlatStyle.Flat;
            btnDepositar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepositar.ForeColor = Color.Black;
            btnDepositar.Image = Properties.Resources.icons8_solicitar_dinheiro_20;
            btnDepositar.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepositar.Location = new Point(0, 0);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Padding = new Padding(35, 0, 0, 0);
            btnDepositar.Size = new Size(250, 40);
            btnDepositar.TabIndex = 0;
            btnDepositar.Text = "Depositar";
            btnDepositar.TextAlign = ContentAlignment.MiddleLeft;
            btnDepositar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Image = Properties.Resources.icons8_cardápio_201;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 100);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(10, 0, 0, 0);
            btnMenu.RightToLeft = RightToLeft.No;
            btnMenu.Size = new Size(250, 42);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // logoMenu
            // 
            logoMenu.Controls.Add(txtNomeUsuario);
            logoMenu.Controls.Add(pictureBox1);
            logoMenu.Dock = DockStyle.Top;
            logoMenu.Location = new Point(0, 0);
            logoMenu.Name = "logoMenu";
            logoMenu.Size = new Size(250, 100);
            logoMenu.TabIndex = 0;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.AutoSize = true;
            txtNomeUsuario.Location = new Point(83, 65);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(77, 17);
            txtNomeUsuario.TabIndex = 1;
            txtNomeUsuario.Text = "Bem vindo!";
            txtNomeUsuario.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(231, 119, 48);
            pictureBox1.Image = Properties.Resources.icons8_usuário_50;
            pictureBox1.Location = new Point(95, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 25, 22);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(250, 430);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 100);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(27, 25, 22);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(231, 119, 48);
            button1.Location = new Point(460, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 10;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 25, 22);
            panel2.Controls.Add(extrato1);
            panel2.Controls.Add(sacar1);
            panel2.Controls.Add(depositaruc1);
            panel2.Controls.Add(inicioMenu1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 430);
            panel2.TabIndex = 11;
            // 
            // extrato1
            // 
            extrato1.BackColor = Color.FromArgb(27, 25, 22);
            extrato1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            extrato1.Location = new Point(0, 0);
            extrato1.Name = "extrato1";
            extrato1.Size = new Size(500, 430);
            extrato1.TabIndex = 14;
            // 
            // sacar1
            // 
            sacar1.BackColor = Color.FromArgb(27, 25, 22);
            sacar1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sacar1.Location = new Point(0, 0);
            sacar1.Name = "sacar1";
            sacar1.Size = new Size(500, 430);
            sacar1.TabIndex = 13;
            // 
            // depositaruc1
            // 
            depositaruc1.BackColor = Color.FromArgb(27, 25, 22);
            depositaruc1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            depositaruc1.Location = new Point(0, 0);
            depositaruc1.Name = "depositaruc1";
            depositaruc1.Size = new Size(500, 430);
            depositaruc1.TabIndex = 12;
            // 
            // inicioMenu1
            // 
            inicioMenu1.BackColor = Color.FromArgb(27, 25, 22);
            inicioMenu1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inicioMenu1.Location = new Point(0, 0);
            inicioMenu1.Name = "inicioMenu1";
            inicioMenu1.Size = new Size(500, 430);
            inicioMenu1.TabIndex = 11;
            // 
            // TelaInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(sideMenu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(750, 530);
            Name = "TelaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            sideMenu.ResumeLayout(false);
            subMenu.ResumeLayout(false);
            logoMenu.ResumeLayout(false);
            logoMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideMenu;
        private Panel logoMenu;
        private Button btnMenu;
        private Panel subMenu;
        private Button btnSacar;
        private Button btnDepositar;
        private Button btnExtrato;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label txtNomeUsuario;
        private Panel PnlNav;
        private Button button1;
        private Panel panel2;
        private InicioMenu inicioMenu1;
        private Button btnSair;
        private DepositarUC depositaruc1;
        private Sacar sacar1;
        private Extrato extrato1;
    }
}