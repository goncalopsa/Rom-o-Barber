namespace Romão_Barber
{
    partial class Registar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registar));
            btguardar = new Button();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            dtp = new DateTimePicker();
            tbpass = new TextBox();
            tbnif = new TextBox();
            tbnome = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btguardar
            // 
            btguardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btguardar.Location = new Point(297, 64);
            btguardar.Name = "btguardar";
            btguardar.Size = new Size(98, 44);
            btguardar.TabIndex = 24;
            btguardar.Text = "Guardar";
            btguardar.UseVisualStyleBackColor = true;
            btguardar.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 159);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 23;
            label5.Text = "Data de Nascimento";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 27);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 22;
            label6.Text = "Nome";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(91, 67);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 20;
            label8.Text = "NIF";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 112);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 19;
            label9.Text = "Palavra Passe";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // dtp
            // 
            dtp.Location = new Point(140, 153);
            dtp.Name = "dtp";
            dtp.Size = new Size(200, 23);
            dtp.TabIndex = 17;
            // 
            // tbpass
            // 
            tbpass.Location = new Point(140, 109);
            tbpass.Name = "tbpass";
            tbpass.Size = new Size(100, 23);
            tbpass.TabIndex = 16;
            // 
            // tbnif
            // 
            tbnif.Location = new Point(140, 64);
            tbnif.Name = "tbnif";
            tbnif.Size = new Size(100, 23);
            tbnif.TabIndex = 15;
            // 
            // tbnome
            // 
            tbnome.Location = new Point(140, 24);
            tbnome.Name = "tbnome";
            tbnome.Size = new Size(100, 23);
            tbnome.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-26, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Registar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 199);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(btguardar);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dtp);
            Controls.Add(tbpass);
            Controls.Add(tbnif);
            Controls.Add(tbnome);
            Name = "Registar";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btguardar;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private DateTimePicker dtp;
        private TextBox tbpass;
        private TextBox tbnif;
        private TextBox tbnome;
        private PictureBox pictureBox1;
    }
}