namespace Romão_Barber
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            dgv = new DataGridView();
            tbpesquisar = new TextBox();
            button1 = new Button();
            pbpa = new PictureBox();
            pbpf = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpf).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(53, 24);
            dgv.Name = "dgv";
            dgv.Size = new Size(540, 150);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tbpesquisar
            // 
            tbpesquisar.Location = new Point(53, 190);
            tbpesquisar.Name = "tbpesquisar";
            tbpesquisar.Size = new Size(100, 23);
            tbpesquisar.TabIndex = 1;
            tbpesquisar.TextChanged += tbpesquisar_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(518, 189);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pbpa
            // 
            pbpa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbpa.Image = (Image)resources.GetObject("pbpa.Image");
            pbpa.Location = new Point(678, 361);
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
            pbpf.Location = new Point(638, 360);
            pbpf.Name = "pbpf";
            pbpf.Size = new Size(211, 98);
            pbpf.SizeMode = PictureBoxSizeMode.Zoom;
            pbpf.TabIndex = 11;
            pbpf.TabStop = false;
            pbpf.MouseHover += pbpf_MouseHover;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pbpa);
            Controls.Add(pbpf);
            Controls.Add(button1);
            Controls.Add(tbpesquisar);
            Controls.Add(dgv);
            Name = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private TextBox tbpesquisar;
        private Button button1;
        private PictureBox pbpa;
        private PictureBox pbpf;
    }
}