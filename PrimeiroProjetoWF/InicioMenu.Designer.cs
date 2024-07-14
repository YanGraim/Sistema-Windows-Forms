namespace PrimeiroProjetoWF {
    partial class InicioMenu {
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
            pictureBox1 = new PictureBox();
            btnSairInicioMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo_jovem_programador;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 430);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSairInicioMenu
            // 
            btnSairInicioMenu.Cursor = Cursors.Hand;
            btnSairInicioMenu.FlatAppearance.BorderSize = 0;
            btnSairInicioMenu.FlatStyle = FlatStyle.Flat;
            btnSairInicioMenu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSairInicioMenu.ForeColor = Color.FromArgb(231, 119, 48);
            btnSairInicioMenu.Location = new Point(460, 0);
            btnSairInicioMenu.Name = "btnSairInicioMenu";
            btnSairInicioMenu.Size = new Size(40, 40);
            btnSairInicioMenu.TabIndex = 1;
            btnSairInicioMenu.Text = "X";
            btnSairInicioMenu.UseVisualStyleBackColor = true;
            btnSairInicioMenu.Click += btnSairInicioMenu_Click;
            // 
            // InicioMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 22);
            Controls.Add(btnSairInicioMenu);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "InicioMenu";
            Size = new Size(500, 430);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnFechar;
        private PictureBox pictureBox1;
        private Button btnSairInicioMenu;
    }
}
