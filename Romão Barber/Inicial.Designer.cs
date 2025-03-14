namespace Romão_Barber
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lbtipo = new Label();
            lbnome = new Label();
            lbc = new Label();
            pbc = new PictureBox();
            pbpa = new PictureBox();
            pbpf = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpf).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(568, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(131, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(54, 230);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Profissionais";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(609, 230);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Serviços";
            // 
            // lbtipo
            // 
            lbtipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbtipo.AutoSize = true;
            lbtipo.Location = new Point(751, 5);
            lbtipo.Name = "lbtipo";
            lbtipo.Size = new Size(38, 15);
            lbtipo.TabIndex = 4;
            lbtipo.Text = "label3";
            lbtipo.TextAlign = ContentAlignment.TopRight;
            // 
            // lbnome
            // 
            lbnome.AutoSize = true;
            lbnome.Location = new Point(0, -1);
            lbnome.Name = "lbnome";
            lbnome.Size = new Size(38, 15);
            lbnome.TabIndex = 5;
            lbnome.Text = "label4";
            lbnome.Click += label4_Click;
            // 
            // lbc
            // 
            lbc.Anchor = AnchorStyles.None;
            lbc.AutoSize = true;
            lbc.Location = new Point(356, 230);
            lbc.Name = "lbc";
            lbc.Size = new Size(49, 15);
            lbc.TabIndex = 7;
            lbc.Text = "Clientes";
            // 
            // pbc
            // 
            pbc.Anchor = AnchorStyles.None;
            pbc.Image = (Image)resources.GetObject("pbc.Image");
            pbc.Location = new Point(291, 59);
            pbc.Name = "pbc";
            pbc.Size = new Size(178, 186);
            pbc.SizeMode = PictureBoxSizeMode.Zoom;
            pbc.TabIndex = 6;
            pbc.TabStop = false;
            pbc.Click += pbc_Click;
            // 
            // pbpa
            // 
            pbpa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbpa.Image = (Image)resources.GetObject("pbpa.Image");
            pbpa.Location = new Point(682, 366);
            pbpa.Name = "pbpa";
            pbpa.Size = new Size(171, 100);
            pbpa.SizeMode = PictureBoxSizeMode.Zoom;
            pbpa.TabIndex = 10;
            pbpa.TabStop = false;
            pbpa.Visible = false;
            pbpa.Click += pbpa_Click;
            pbpa.MouseLeave += pbpa_MouseLeave;
            // 
            // pbpf
            // 
            pbpf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbpf.Image = (Image)resources.GetObject("pbpf.Image");
            pbpf.Location = new Point(642, 365);
            pbpf.Name = "pbpf";
            pbpf.Size = new Size(211, 98);
            pbpf.SizeMode = PictureBoxSizeMode.Zoom;
            pbpf.TabIndex = 9;
            pbpf.TabStop = false;
            pbpf.Click += pbpf_Click;
            pbpf.MouseHover += pbpf_MouseHover;
            // 
            // Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pbpa);
            Controls.Add(pbpf);
            Controls.Add(lbc);
            Controls.Add(pbc);
            Controls.Add(lbnome);
            Controls.Add(lbtipo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Inicial";
            WindowState = FormWindowState.Maximized;
            Load += Inicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label lbtipo;
        private Label lbnome;
        private Label lbc;
        private PictureBox pbc;
        private PictureBox pbpa;
        private PictureBox pbpf;
    }
}