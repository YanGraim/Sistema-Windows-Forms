namespace PrimeiroProjetoWF {
    partial class Extrato {
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            dtGridViewExtrato = new DataGridView();
            pictureBox1 = new PictureBox();
            btnSairExtrato = new Button();
            btnExtrato = new Button();
            panel1 = new Panel();
            dtDataInicio = new Calendario();
            dtDataFim = new Calendario();
            ((System.ComponentModel.ISupportInitialize)dtGridViewExtrato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtGridViewExtrato
            // 
            dtGridViewExtrato.AllowUserToAddRows = false;
            dtGridViewExtrato.AllowUserToDeleteRows = false;
            dtGridViewExtrato.AllowUserToResizeColumns = false;
            dtGridViewExtrato.AllowUserToResizeRows = false;
            dtGridViewExtrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGridViewExtrato.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtGridViewExtrato.BackgroundColor = Color.FromArgb(27, 25, 22);
            dtGridViewExtrato.BorderStyle = BorderStyle.None;
            dtGridViewExtrato.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(231, 119, 48);
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(27, 25, 22);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(231, 119, 48);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(27, 25, 22);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dtGridViewExtrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dtGridViewExtrato.ColumnHeadersHeight = 30;
            dtGridViewExtrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(27, 25, 22);
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Silver;
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(27, 25, 22);
            dataGridViewCellStyle11.SelectionForeColor = Color.Silver;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dtGridViewExtrato.DefaultCellStyle = dataGridViewCellStyle11;
            dtGridViewExtrato.EnableHeadersVisualStyles = false;
            dtGridViewExtrato.GridColor = Color.Silver;
            dtGridViewExtrato.ImeMode = ImeMode.Disable;
            dtGridViewExtrato.Location = new Point(49, 0);
            dtGridViewExtrato.Name = "dtGridViewExtrato";
            dtGridViewExtrato.ReadOnly = true;
            dtGridViewExtrato.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(27, 25, 22);
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Silver;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(27, 25, 22);
            dataGridViewCellStyle12.SelectionForeColor = Color.Silver;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dtGridViewExtrato.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dtGridViewExtrato.RowHeadersVisible = false;
            dtGridViewExtrato.RowTemplate.Height = 25;
            dtGridViewExtrato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridViewExtrato.Size = new Size(451, 150);
            dtGridViewExtrato.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_livro_de_caixa_50;
            pictureBox1.Location = new Point(189, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnSairExtrato
            // 
            btnSairExtrato.AutoSize = true;
            btnSairExtrato.BackColor = Color.FromArgb(27, 25, 22);
            btnSairExtrato.Cursor = Cursors.Hand;
            btnSairExtrato.FlatAppearance.BorderSize = 0;
            btnSairExtrato.FlatStyle = FlatStyle.Flat;
            btnSairExtrato.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSairExtrato.ForeColor = Color.FromArgb(231, 119, 48);
            btnSairExtrato.Location = new Point(460, 0);
            btnSairExtrato.Name = "btnSairExtrato";
            btnSairExtrato.Size = new Size(40, 40);
            btnSairExtrato.TabIndex = 20;
            btnSairExtrato.Text = "X";
            btnSairExtrato.UseVisualStyleBackColor = false;
            btnSairExtrato.Click += btnSairExtrato_Click;
            // 
            // btnExtrato
            // 
            btnExtrato.BackColor = Color.FromArgb(231, 119, 48);
            btnExtrato.FlatAppearance.BorderSize = 0;
            btnExtrato.FlatStyle = FlatStyle.Flat;
            btnExtrato.Location = new Point(113, 234);
            btnExtrato.Name = "btnExtrato";
            btnExtrato.Size = new Size(261, 29);
            btnExtrato.TabIndex = 21;
            btnExtrato.Text = "Extrato";
            btnExtrato.UseVisualStyleBackColor = false;
            btnExtrato.Click += btnExtrato_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtGridViewExtrato);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 150);
            panel1.TabIndex = 24;
            // 
            // dtDataInicio
            // 
            dtDataInicio.BorderColor = Color.FromArgb(231, 119, 48);
            dtDataInicio.BorderSize = 1;
            dtDataInicio.Cursor = Cursors.Hand;
            dtDataInicio.CustomFormat = "dd MMMM, yyy";
            dtDataInicio.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtDataInicio.Format = DateTimePickerFormat.Custom;
            dtDataInicio.Location = new Point(113, 178);
            dtDataInicio.MinimumSize = new Size(0, 35);
            dtDataInicio.Name = "dtDataInicio";
            dtDataInicio.Size = new Size(123, 35);
            dtDataInicio.SkinColor = Color.FromArgb(27, 25, 22);
            dtDataInicio.TabIndex = 25;
            dtDataInicio.TextColor = Color.Silver;
            // 
            // dtDataFim
            // 
            dtDataFim.BorderColor = Color.FromArgb(231, 119, 48);
            dtDataFim.BorderSize = 1;
            dtDataFim.Cursor = Cursors.Hand;
            dtDataFim.CustomFormat = "dd MMMM, yyy";
            dtDataFim.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtDataFim.Format = DateTimePickerFormat.Custom;
            dtDataFim.Location = new Point(249, 178);
            dtDataFim.MinimumSize = new Size(0, 35);
            dtDataFim.Name = "dtDataFim";
            dtDataFim.Size = new Size(125, 35);
            dtDataFim.SkinColor = Color.FromArgb(27, 25, 22);
            dtDataFim.TabIndex = 26;
            dtDataFim.TextColor = Color.Silver;
            // 
            // Extrato
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 22);
            Controls.Add(dtDataFim);
            Controls.Add(dtDataInicio);
            Controls.Add(panel1);
            Controls.Add(btnExtrato);
            Controls.Add(btnSairExtrato);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Extrato";
            Size = new Size(500, 430);
            ((System.ComponentModel.ISupportInitialize)dtGridViewExtrato).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtGridViewExtrato;
        private PictureBox pictureBox1;
        private Button btnSairExtrato;
        private Button btnExtrato;
        private Panel panel1;
        private Calendario dtDataInicio;
        private Calendario dtDataFim;
    }
}
