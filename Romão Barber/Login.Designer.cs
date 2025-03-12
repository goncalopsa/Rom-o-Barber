namespace Romão_Barber
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tbemail = new TextBox();
            tbpass = new TextBox();
            pblogin = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pbpf = new PictureBox();
            pbpa = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pblogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpa).BeginInit();
            SuspendLayout();
            // 
            // tbemail
            // 
            tbemail.Anchor = AnchorStyles.None;
            tbemail.Location = new Point(296, 178);
            tbemail.Name = "tbemail";
            tbemail.PlaceholderText = "email";
            tbemail.Size = new Size(208, 23);
            tbemail.TabIndex = 2;
            tbemail.Text = "123456789";
            // 
            // tbpass
            // 
            tbpass.Anchor = AnchorStyles.None;
            tbpass.Location = new Point(296, 207);
            tbpass.Name = "tbpass";
            tbpass.PlaceholderText = "palavra-passe";
            tbpass.Size = new Size(208, 23);
            tbpass.TabIndex = 3;
            tbpass.Text = "admin";
            // 
            // pblogin
            // 
            pblogin.Anchor = AnchorStyles.None;
            pblogin.Image = (Image)resources.GetObject("pblogin.Image");
            pblogin.Location = new Point(329, 234);
            pblogin.Name = "pblogin";
            pblogin.Size = new Size(142, 121);
            pblogin.SizeMode = PictureBoxSizeMode.Zoom;
            pblogin.TabIndex = 4;
            pblogin.TabStop = false;
            pblogin.Click += pictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(710, 396);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(714, 437);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 6;
            label1.Text = "Novo Utilizador";
            // 
            // pbpf
            // 
            pbpf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbpf.Image = (Image)resources.GetObject("pbpf.Image");
            pbpf.Location = new Point(639, -8);
            pbpf.Name = "pbpf";
            pbpf.Size = new Size(211, 98);
            pbpf.SizeMode = PictureBoxSizeMode.Zoom;
            pbpf.TabIndex = 7;
            pbpf.TabStop = false;
            pbpf.Click += pbpf_Click;
            pbpf.MouseHover += pbpf_MouseHover;
            // 
            // pbpa
            // 
            pbpa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbpa.Image = (Image)resources.GetObject("pbpa.Image");
            pbpa.Location = new Point(679, -7);
            pbpa.Name = "pbpa";
            pbpa.Size = new Size(171, 100);
            pbpa.SizeMode = PictureBoxSizeMode.Zoom;
            pbpa.TabIndex = 8;
            pbpa.TabStop = false;
            pbpa.Visible = false;
            pbpa.Click += pbpa_Click;
            pbpa.MouseClick += pictureBox3_MouseClick;
            pbpa.MouseLeave += pbpa_MouseLeave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pbpa);
            Controls.Add(pbpf);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pblogin);
            Controls.Add(tbpass);
            Controls.Add(tbemail);
            Name = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pblogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbemail;
        private TextBox tbpass;
        private PictureBox pblogin;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pbpf;
        private PictureBox pbpa;
    }
}
