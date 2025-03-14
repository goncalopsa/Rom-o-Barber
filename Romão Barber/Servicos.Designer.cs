namespace Romão_Barber
{
    partial class Servicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicos));
            utilizadorBindingSource = new BindingSource(components);
            tbpesquisar = new TextBox();
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
            tbpesquisar.Location = new Point(115, 202);
            tbpesquisar.Name = "tbpesquisar";
            tbpesquisar.Size = new Size(100, 23);
            tbpesquisar.TabIndex = 1;
            tbpesquisar.TextChanged += textBox1_TextChanged;
            // 
            // pbpa
            // 
            pbpa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbpa.Image = (Image)resources.GetObject("pbpa.Image");
            pbpa.Location = new Point(685, 364);
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
            pbpf.Location = new Point(645, 363);
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
            dgv.Location = new Point(115, 37);
            dgv.Name = "dgv";
            dgv.Size = new Size(529, 150);
            dgv.TabIndex = 13;
            // 
            // Servicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(dgv);
            Controls.Add(pbpa);
            Controls.Add(pbpf);
            Controls.Add(tbpesquisar);
            Name = "Servicos";
            WindowState = FormWindowState.Maximized;
            Load += Servicos_Load;
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
        private PictureBox pbpa;
        private PictureBox pbpf;
        private DataGridView dgv;
    }
}