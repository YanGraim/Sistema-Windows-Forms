namespace PrimeiroProjetoWF {
    partial class DepositarUC {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            txtValorDeposito = new TextBox();
            pictureBox1 = new PictureBox();
            btnSairDepositar = new Button();
            btnDepositar = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            lblVisao = new Label();
            SaldoDeposito = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(115, 189);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 0;
            label1.Text = "Depositar:";
            label1.Click += label1_Click;
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.BackColor = Color.FromArgb(27, 25, 22);
            txtValorDeposito.BorderStyle = BorderStyle.None;
            txtValorDeposito.Cursor = Cursors.IBeam;
            txtValorDeposito.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorDeposito.ForeColor = Color.Silver;
            txtValorDeposito.Location = new Point(115, 209);
            txtValorDeposito.Multiline = true;
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.PlaceholderText = "Informe o valor";
            txtValorDeposito.Size = new Size(261, 20);
            txtValorDeposito.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_money_box_50;
            pictureBox1.Location = new Point(189, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnSairDepositar
            // 
            btnSairDepositar.AutoSize = true;
            btnSairDepositar.BackColor = Color.FromArgb(27, 25, 22);
            btnSairDepositar.Cursor = Cursors.Hand;
            btnSairDepositar.FlatAppearance.BorderSize = 0;
            btnSairDepositar.FlatStyle = FlatStyle.Flat;
            btnSairDepositar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSairDepositar.ForeColor = Color.FromArgb(231, 119, 48);
            btnSairDepositar.Location = new Point(460, 0);
            btnSairDepositar.Name = "btnSairDepositar";
            btnSairDepositar.Size = new Size(40, 40);
            btnSairDepositar.TabIndex = 18;
            btnSairDepositar.Text = "X";
            btnSairDepositar.UseVisualStyleBackColor = false;
            btnSairDepositar.Click += btnSairDepositar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.FromArgb(231, 119, 48);
            btnDepositar.Cursor = Cursors.Hand;
            btnDepositar.FlatAppearance.BorderSize = 0;
            btnDepositar.FlatStyle = FlatStyle.Flat;
            btnDepositar.Location = new Point(115, 269);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(261, 29);
            btnDepositar.TabIndex = 19;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(115, 228);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 1);
            panel3.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblVisao);
            panel1.Controls.Add(SaldoDeposito);
            panel1.Location = new Point(20, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 83);
            panel1.TabIndex = 25;
            // 
            // lblVisao
            // 
            lblVisao.AutoSize = true;
            lblVisao.ForeColor = Color.FromArgb(231, 119, 48);
            lblVisao.Image = Properties.Resources.icons8_ocultar_201;
            lblVisao.Location = new Point(3, 32);
            lblVisao.Name = "lblVisao";
            lblVisao.Size = new Size(20, 17);
            lblVisao.TabIndex = 1;
            lblVisao.Tag = "lblVisao";
            lblVisao.Text = "   ";
            lblVisao.Click += lblVisao_Click;
            // 
            // SaldoDeposito
            // 
            SaldoDeposito.AutoSize = true;
            SaldoDeposito.ForeColor = Color.FromArgb(231, 119, 48);
            SaldoDeposito.Location = new Point(29, 32);
            SaldoDeposito.Name = "SaldoDeposito";
            SaldoDeposito.Size = new Size(0, 17);
            SaldoDeposito.TabIndex = 0;
            SaldoDeposito.Click += SaldoDeposito_Click;
            // 
            // DepositarUC
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 22);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(btnDepositar);
            Controls.Add(btnSairDepositar);
            Controls.Add(pictureBox1);
            Controls.Add(txtValorDeposito);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "DepositarUC";
            Size = new Size(500, 430);
            Load += DepositarUC_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValorDeposito;
        private PictureBox pictureBox1;
        private Button btnSairDepositar;
        private Button btnDepositar;
        private Panel panel3;
        private Panel panel1;
        private Label SaldoDeposito;
        private Label lblVisao;
    }
}
