namespace PrimeiroProjetoWF {
    partial class Sacar {
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
            btnSacar = new Button();
            btnSairSacar = new Button();
            panel3 = new Panel();
            txtValorSaque = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblVisaoSaque = new Label();
            SaldoSaque = new Label();
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
            label1.Size = new Size(49, 17);
            label1.TabIndex = 0;
            label1.Text = "Sacar:";
            label1.Click += label1_Click;
            // 
            // btnSacar
            // 
            btnSacar.BackColor = Color.FromArgb(231, 119, 48);
            btnSacar.Cursor = Cursors.Hand;
            btnSacar.FlatAppearance.BorderSize = 0;
            btnSacar.FlatStyle = FlatStyle.Flat;
            btnSacar.Location = new Point(115, 269);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(261, 29);
            btnSacar.TabIndex = 2;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = false;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnSairSacar
            // 
            btnSairSacar.AutoSize = true;
            btnSairSacar.BackColor = Color.FromArgb(27, 25, 22);
            btnSairSacar.Cursor = Cursors.Hand;
            btnSairSacar.FlatAppearance.BorderSize = 0;
            btnSairSacar.FlatStyle = FlatStyle.Flat;
            btnSairSacar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSairSacar.ForeColor = Color.FromArgb(231, 119, 48);
            btnSairSacar.Location = new Point(460, 0);
            btnSairSacar.Name = "btnSairSacar";
            btnSairSacar.Size = new Size(40, 40);
            btnSairSacar.TabIndex = 19;
            btnSairSacar.Text = "X";
            btnSairSacar.UseVisualStyleBackColor = false;
            btnSairSacar.Click += btnSairSacar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(115, 228);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 1);
            panel3.TabIndex = 21;
            // 
            // txtValorSaque
            // 
            txtValorSaque.BackColor = Color.FromArgb(27, 25, 22);
            txtValorSaque.BorderStyle = BorderStyle.None;
            txtValorSaque.Cursor = Cursors.IBeam;
            txtValorSaque.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorSaque.ForeColor = Color.Silver;
            txtValorSaque.Location = new Point(115, 209);
            txtValorSaque.Multiline = true;
            txtValorSaque.Name = "txtValorSaque";
            txtValorSaque.PlaceholderText = "Informe o valor";
            txtValorSaque.Size = new Size(261, 17);
            txtValorSaque.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_restituição_50;
            pictureBox1.Location = new Point(189, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblVisaoSaque);
            panel1.Controls.Add(SaldoSaque);
            panel1.Location = new Point(20, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 83);
            panel1.TabIndex = 24;
            // 
            // lblVisaoSaque
            // 
            lblVisaoSaque.AutoSize = true;
            lblVisaoSaque.ForeColor = Color.FromArgb(231, 119, 48);
            lblVisaoSaque.Image = Properties.Resources.icons8_visível_20;
            lblVisaoSaque.Location = new Point(3, 32);
            lblVisaoSaque.Name = "lblVisaoSaque";
            lblVisaoSaque.Size = new Size(20, 17);
            lblVisaoSaque.TabIndex = 2;
            lblVisaoSaque.Tag = "lblVisaoSaque";
            lblVisaoSaque.Text = "   ";
            lblVisaoSaque.Click += lblVisaoSaque_Click;
            // 
            // SaldoSaque
            // 
            SaldoSaque.AutoSize = true;
            SaldoSaque.ForeColor = Color.FromArgb(231, 119, 48);
            SaldoSaque.Location = new Point(29, 32);
            SaldoSaque.Name = "SaldoSaque";
            SaldoSaque.Size = new Size(0, 17);
            SaldoSaque.TabIndex = 0;
            SaldoSaque.Click += SaldoSaque_Click;
            // 
            // Sacar
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 22);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(txtValorSaque);
            Controls.Add(panel3);
            Controls.Add(btnSairSacar);
            Controls.Add(btnSacar);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Sacar";
            Size = new Size(500, 430);
            Load += SacarUC_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSacar;
        private Button btnSairSacar;
        private Panel panel3;
        private TextBox txtValorSaque;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label SaldoSaque;
        private Label lblVisaoSaque;
    }
}
