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
            saidapequena = new PictureBox();
            saidagrande = new PictureBox();
            tbemail = new TextBox();
            tbpass = new TextBox();
            pblogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)saidapequena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saidagrande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pblogin).BeginInit();
            SuspendLayout();
            // 
            // saidapequena
            // 
            saidapequena.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saidapequena.Image = (Image)resources.GetObject("saidapequena.Image");
            saidapequena.Location = new Point(703, 11);
            saidapequena.Name = "saidapequena";
            saidapequena.Size = new Size(100, 50);
            saidapequena.SizeMode = PictureBoxSizeMode.Zoom;
            saidapequena.TabIndex = 0;
            saidapequena.TabStop = false;
            saidapequena.MouseHover += pictureBox1_MouseHover;
            // 
            // saidagrande
            // 
            saidagrande.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saidagrande.Image = (Image)resources.GetObject("saidagrande.Image");
            saidagrande.Location = new Point(723, 1);
            saidagrande.Name = "saidagrande";
            saidagrande.Size = new Size(80, 69);
            saidagrande.SizeMode = PictureBoxSizeMode.Zoom;
            saidagrande.TabIndex = 1;
            saidagrande.TabStop = false;
            saidagrande.Click += pictureBox2_Click;
            saidagrande.MouseLeave += saidagrande_MouseLeave;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(303, 178);
            tbemail.Name = "tbemail";
            tbemail.PlaceholderText = "email";
            tbemail.Size = new Size(208, 23);
            tbemail.TabIndex = 2;
            // 
            // tbpass
            // 
            tbpass.Location = new Point(303, 207);
            tbpass.Name = "tbpass";
            tbpass.PlaceholderText = "palavra-passe";
            tbpass.Size = new Size(208, 23);
            tbpass.TabIndex = 3;
            // 
            // pblogin
            // 
            pblogin.Image = (Image)resources.GetObject("pblogin.Image");
            pblogin.Location = new Point(336, 234);
            pblogin.Name = "pblogin";
            pblogin.Size = new Size(142, 121);
            pblogin.SizeMode = PictureBoxSizeMode.Zoom;
            pblogin.TabIndex = 4;
            pblogin.TabStop = false;
            pblogin.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pblogin);
            Controls.Add(tbpass);
            Controls.Add(tbemail);
            Controls.Add(saidagrande);
            Controls.Add(saidapequena);
            Name = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)saidapequena).EndInit();
            ((System.ComponentModel.ISupportInitialize)saidagrande).EndInit();
            ((System.ComponentModel.ISupportInitialize)pblogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox saidapequena;
        private PictureBox saidagrande;
        private TextBox tbemail;
        private TextBox tbpass;
        private PictureBox pblogin;
    }
}
