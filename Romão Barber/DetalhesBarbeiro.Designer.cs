namespace Romão_Barber
{
    partial class DetalhesBarbeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesBarbeiro));
            btguardar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbnome = new TextBox();
            dtp = new DateTimePicker();
            tbnif = new TextBox();
            label7 = new Label();
            cb = new CheckBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            tbpass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btguardar
            // 
            btguardar.Location = new Point(298, 51);
            btguardar.Name = "btguardar";
            btguardar.Size = new Size(168, 61);
            btguardar.TabIndex = 17;
            btguardar.Text = "Guardar";
            btguardar.UseVisualStyleBackColor = true;
            btguardar.Click += btguardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 15;
            label3.Text = "Data de Nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 51);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 14;
            label2.Text = "NIF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 12);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 13;
            label1.Text = "Nome";
            // 
            // tbnome
            // 
            tbnome.Location = new Point(127, 9);
            tbnome.Name = "tbnome";
            tbnome.Size = new Size(339, 23);
            tbnome.TabIndex = 12;
            // 
            // dtp
            // 
            dtp.Location = new Point(132, 130);
            dtp.Name = "dtp";
            dtp.Size = new Size(200, 23);
            dtp.TabIndex = 11;
            // 
            // tbnif
            // 
            tbnif.Location = new Point(127, 48);
            tbnif.Name = "tbnif";
            tbnif.Size = new Size(153, 23);
            tbnif.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(380, 132);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 23;
            label7.Text = "Ativo";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // cb
            // 
            cb.AutoSize = true;
            cb.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb.Location = new Point(432, 137);
            cb.Name = "cb";
            cb.Size = new Size(15, 14);
            cb.TabIndex = 22;
            cb.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-25, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 92);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 26;
            label9.Text = "Palavra Passe";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // tbpass
            // 
            tbpass.Location = new Point(127, 89);
            tbpass.Name = "tbpass";
            tbpass.Size = new Size(153, 23);
            tbpass.TabIndex = 25;
            // 
            // DetalhesBarbeiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 160);
            ControlBox = false;
            Controls.Add(label9);
            Controls.Add(tbpass);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(cb);
            Controls.Add(btguardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbnome);
            Controls.Add(dtp);
            Controls.Add(tbnif);
            Name = "DetalhesBarbeiro";
            StartPosition = FormStartPosition.CenterScreen;
            Load += DetalhesBarbeiro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btguardar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbnome;
        private DateTimePicker dtp;
        private TextBox tbnif;
        private Label label7;
        private CheckBox cb;
        private PictureBox pictureBox1;
        private Label label9;
        private TextBox tbpass;
    }
}