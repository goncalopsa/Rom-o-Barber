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
            btguardar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label7 = new Label();
            cb = new CheckBox();
            SuspendLayout();
            // 
            // btguardar
            // 
            btguardar.Location = new Point(252, 180);
            btguardar.Name = "btguardar";
            btguardar.Size = new Size(75, 23);
            btguardar.TabIndex = 17;
            btguardar.Text = "Guardar";
            btguardar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 15;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 14;
            label2.Text = "NIF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 13;
            label1.Text = "Nome";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(79, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 180);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 23;
            label7.Text = "Ativo";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // cb
            // 
            cb.AutoSize = true;
            cb.Location = new Point(75, 176);
            cb.Name = "cb";
            cb.Size = new Size(82, 19);
            cb.TabIndex = 22;
            cb.Text = "checkBox1";
            cb.UseVisualStyleBackColor = true;
            // 
            // DetalhesBarbeiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 223);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(cb);
            Controls.Add(btguardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Name = "DetalhesBarbeiro";
            WindowState = FormWindowState.Maximized;
            Load += DetalhesBarbeiro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btguardar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label7;
        private CheckBox cb;
    }
}