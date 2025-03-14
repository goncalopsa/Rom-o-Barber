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
            utilizadorBindingSource = new BindingSource(components);
            tbpesquisar = new TextBox();
            btcriar = new Button();
            pbpa = new PictureBox();
            pbpf = new PictureBox();
            dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)utilizadorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // tbpesquisar
            // 
            tbpesquisar.Anchor = AnchorStyles.None;
            tbpesquisar.Location = new Point(78, 181);
            tbpesquisar.Name = "tbpesquisar";
            tbpesquisar.Size = new Size(100, 23);
            tbpesquisar.TabIndex = 1;
            tbpesquisar.TextChanged += textBox1_TextChanged;
            // 
            // btcriar
            // 
            btcriar.Anchor = AnchorStyles.None;
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
            // dgv
            // 
            dgv.Anchor = AnchorStyles.None;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(78, 12);
            dgv.Name = "dgv";
            dgv.Size = new Size(605, 150);
            dgv.TabIndex = 13;
            // 
            // Barbeiros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dgv);
            Controls.Add(pbpa);
            Controls.Add(pbpf);
            Controls.Add(btcriar);
            Controls.Add(tbpesquisar);
            Name = "Barbeiros";
            WindowState = FormWindowState.Maximized;
            Load += Barbeiros_Load;
            ((System.ComponentModel.ISupportInitialize)utilizadorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpf).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private DataGridView dgv;
    }
}