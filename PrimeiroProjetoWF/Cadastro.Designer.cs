namespace PrimeiroProjetoWF {
    partial class Cadastro {
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnFechar = new Button();
            btnCadastrese = new Button();
            panel6 = new Panel();
            txtConfirmaSenhaCadastro = new TextBox();
            panel5 = new Panel();
            txtSenhaCadastro = new TextBox();
            panel4 = new Panel();
            txtEmailCadastro = new TextBox();
            panel3 = new Panel();
            txtNomeCadastro = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(231, 119, 48);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 530);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Image = Properties.Resources.icons8_esquerda_20;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 31);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 266);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 1;
            label1.Text = "Cadastro";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_cadastro_50;
            pictureBox1.Location = new Point(66, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 25, 22);
            panel2.Controls.Add(btnFechar);
            panel2.Controls.Add(btnCadastrese);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(txtConfirmaSenhaCadastro);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(txtSenhaCadastro);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(txtEmailCadastro);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txtNomeCadastro);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 530);
            panel2.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.AutoSize = true;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.FromArgb(231, 119, 48);
            btnFechar.Location = new Point(460, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(40, 40);
            btnFechar.TabIndex = 24;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnCadastrese
            // 
            btnCadastrese.BackColor = Color.FromArgb(231, 119, 48);
            btnCadastrese.Cursor = Cursors.Hand;
            btnCadastrese.FlatStyle = FlatStyle.Popup;
            btnCadastrese.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrese.ForeColor = Color.FromArgb(27, 25, 22);
            btnCadastrese.Location = new Point(165, 428);
            btnCadastrese.Name = "btnCadastrese";
            btnCadastrese.Size = new Size(166, 38);
            btnCadastrese.TabIndex = 23;
            btnCadastrese.Text = "Cadastre-se";
            btnCadastrese.UseVisualStyleBackColor = false;
            btnCadastrese.Click += btnCadastrese_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(77, 372);
            panel6.Name = "panel6";
            panel6.Size = new Size(349, 1);
            panel6.TabIndex = 22;
            // 
            // txtConfirmaSenhaCadastro
            // 
            txtConfirmaSenhaCadastro.BackColor = Color.FromArgb(27, 25, 22);
            txtConfirmaSenhaCadastro.BorderStyle = BorderStyle.None;
            txtConfirmaSenhaCadastro.Cursor = Cursors.IBeam;
            txtConfirmaSenhaCadastro.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmaSenhaCadastro.ForeColor = Color.Silver;
            txtConfirmaSenhaCadastro.Location = new Point(77, 354);
            txtConfirmaSenhaCadastro.Multiline = true;
            txtConfirmaSenhaCadastro.Name = "txtConfirmaSenhaCadastro";
            txtConfirmaSenhaCadastro.PlaceholderText = "Confirme sua senha";
            txtConfirmaSenhaCadastro.Size = new Size(349, 31);
            txtConfirmaSenhaCadastro.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(79, 315);
            panel5.Name = "panel5";
            panel5.Size = new Size(349, 1);
            panel5.TabIndex = 20;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.BackColor = Color.FromArgb(27, 25, 22);
            txtSenhaCadastro.BorderStyle = BorderStyle.None;
            txtSenhaCadastro.Cursor = Cursors.IBeam;
            txtSenhaCadastro.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaCadastro.ForeColor = Color.Silver;
            txtSenhaCadastro.Location = new Point(78, 297);
            txtSenhaCadastro.Multiline = true;
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PlaceholderText = "Digite  sua senha";
            txtSenhaCadastro.Size = new Size(349, 31);
            txtSenhaCadastro.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(79, 250);
            panel4.Name = "panel4";
            panel4.Size = new Size(349, 1);
            panel4.TabIndex = 18;
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.BackColor = Color.FromArgb(27, 25, 22);
            txtEmailCadastro.BorderStyle = BorderStyle.None;
            txtEmailCadastro.Cursor = Cursors.IBeam;
            txtEmailCadastro.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailCadastro.ForeColor = Color.Silver;
            txtEmailCadastro.Location = new Point(79, 232);
            txtEmailCadastro.Multiline = true;
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.PlaceholderText = "Digite seu login";
            txtEmailCadastro.Size = new Size(349, 31);
            txtEmailCadastro.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(81, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 1);
            panel3.TabIndex = 16;
            // 
            // txtNomeCadastro
            // 
            txtNomeCadastro.BackColor = Color.FromArgb(27, 25, 22);
            txtNomeCadastro.BorderStyle = BorderStyle.None;
            txtNomeCadastro.Cursor = Cursors.IBeam;
            txtNomeCadastro.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCadastro.ForeColor = Color.Silver;
            txtNomeCadastro.Location = new Point(81, 166);
            txtNomeCadastro.Multiline = true;
            txtNomeCadastro.Name = "txtNomeCadastro";
            txtNomeCadastro.PlaceholderText = "Digite seu nome";
            txtNomeCadastro.Size = new Size(349, 31);
            txtNomeCadastro.TabIndex = 15;
            // 
            // Cadastro
            // 
            AcceptButton = btnCadastrese;
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(750, 530);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private TextBox txtNomeCadastro;
        private Panel panel6;
        private TextBox txtConfirmaSenhaCadastro;
        private Panel panel5;
        private TextBox txtSenhaCadastro;
        private Panel panel4;
        private TextBox txtEmailCadastro;
        private Button btnCadastrese;
        private Button btnFechar;
        private Label label2;
    }
}