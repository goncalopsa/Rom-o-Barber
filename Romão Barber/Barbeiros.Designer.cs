namespace Romão_Barber
{
    partial class Barbeiros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barbeiros));
            dgv = new DataGridView();
            utilizadorBindingSource = new BindingSource(components);
            tbpesquisar = new TextBox();
            btcriar = new Button();
            pbpa = new PictureBox();
            pbpf = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)utilizadorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpf).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.DataSource = utilizadorBindingSource;
            dgv.Location = new Point(78, 25);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.Size = new Size(605, 150);
            dgv.TabIndex = 0;
            // 
            // tbpesquisar
            // 
            tbpesquisar.Location = new Point(78, 181);
            tbpesquisar.Name = "tbpesquisar";
            tbpesquisar.Size = new Size(100, 23);
            tbpesquisar.TabIndex = 1;
            tbpesquisar.TextChanged += textBox1_TextChanged;
            // 
            // btcriar
            // 
            btcriar.Location = new Point(542, 181);
            btcriar.Name = "btcriar";
            btcriar.Size = new Size(141, 31);
            btcriar.TabIndex = 2;
            btcriar.Text = "Inserir Barbeiro";
            btcriar.UseVisualStyleBackColor = true;
            // 
            // pbpa
            // 
            pbpa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbpa.Image = (Image)resources.GetObject("pbpa.Image");
            pbpa.Location = new Point(679, 365);
            pbpa.Name = "pbpa";
            pbpa.Size = new Size(171, 100);
            pbpa.SizeMode = PictureBoxSizeMode.Zoom;
            pbpa.TabIndex = 12;
            pbpa.TabStop = false;
            pbpa.Visible = false;
            pbpa.Click += pbpa_Click;
            pbpa.MouseLeave += pbpa_MouseLeave;
            // 
            // pbpf
            // 
            pbpf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbpf.Image = (Image)resources.GetObject("pbpf.Image");
            pbpf.Location = new Point(639, 364);
            pbpf.Name = "pbpf";
            pbpf.Size = new Size(211, 98);
            pbpf.SizeMode = PictureBoxSizeMode.Zoom;
            pbpf.TabIndex = 11;
            pbpf.TabStop = false;
            pbpf.MouseHover += pbpf_MouseHover;
            // 
            // Barbeiros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pbpa);
            Controls.Add(pbpf);
            Controls.Add(btcriar);
            Controls.Add(tbpesquisar);
            Controls.Add(dgv);
            Name = "Barbeiros";
            WindowState = FormWindowState.Maximized;
            Load += Funcionarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)utilizadorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn iDUtilizadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn palavraPasseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeUtilizadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailUtilizadorDataGridViewTextBoxColumn;
        private BindingSource utilizadorBindingSource;
        private TextBox tbpesquisar;
        private Button btcriar;
        private PictureBox pbpa;
        private PictureBox pbpf;
    }
}