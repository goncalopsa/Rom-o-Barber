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
            pblogin = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbpassword = new TextBox();
            pbolhofechado = new PictureBox();
            pbolhoaberto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pblogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbolhofechado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbolhoaberto).BeginInit();
            SuspendLayout();
            // 
            // tbemail
            // 
            tbemail.Anchor = AnchorStyles.None;
            tbemail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemail.Location = new Point(262, 124);
            tbemail.Name = "tbemail";
            tbemail.PlaceholderText = "email";
            tbemail.Size = new Size(238, 39);
            tbemail.TabIndex = 2;
            tbemail.Text = "123456789";
            // 
            // pblogin
            // 
            pblogin.Anchor = AnchorStyles.None;
            pblogin.Image = (Image)resources.GetObject("pblogin.Image");
            pblogin.Location = new Point(262, 169);
            pblogin.Name = "pblogin";
            pblogin.Size = new Size(238, 193);
            pblogin.SizeMode = PictureBoxSizeMode.Zoom;
            pblogin.TabIndex = 4;
            pblogin.TabStop = false;
            pblogin.Click += pictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(679, 365);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 81);
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(683, 431);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 6;
            label1.Text = "Novo Utilizador";
            // 
            // tbpassword
            // 
            tbpassword.Anchor = AnchorStyles.None;
            tbpassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpassword.Location = new Point(262, 179);
            tbpassword.Name = "tbpassword";
            tbpassword.PasswordChar = '*';
            tbpassword.PlaceholderText = "palavra-passe";
            tbpassword.Size = new Size(238, 39);
            tbpassword.TabIndex = 9;
            tbpassword.Text = "admin";
            // 
            // pbolhofechado
            // 
            pbolhofechado.Anchor = AnchorStyles.None;
            pbolhofechado.Image = (Image)resources.GetObject("pbolhofechado.Image");
            pbolhofechado.Location = new Point(528, 154);
            pbolhofechado.Name = "pbolhofechado";
            pbolhofechado.Size = new Size(53, 100);
            pbolhofechado.SizeMode = PictureBoxSizeMode.Zoom;
            pbolhofechado.TabIndex = 12;
            pbolhofechado.TabStop = false;
            pbolhofechado.Visible = false;
            // 
            // pbolhoaberto
            // 
            pbolhoaberto.Anchor = AnchorStyles.None;
            pbolhoaberto.Image = (Image)resources.GetObject("pbolhoaberto.Image");
            pbolhoaberto.Location = new Point(506, 189);
            pbolhoaberto.Name = "pbolhoaberto";
            pbolhoaberto.Size = new Size(98, 29);
            pbolhoaberto.SizeMode = PictureBoxSizeMode.Zoom;
            pbolhoaberto.TabIndex = 11;
            pbolhoaberto.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(pbolhofechado);
            Controls.Add(pbolhoaberto);
            Controls.Add(tbpassword);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pblogin);
            Controls.Add(tbemail);
            Name = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pblogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbolhofechado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbolhoaberto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbemail;
        private PictureBox pblogin;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tbpassword;
        private PictureBox pbolhofechado;
        private PictureBox pbolhoaberto;
    }
}
