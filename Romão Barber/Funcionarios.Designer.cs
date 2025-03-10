namespace Romão_Barber
{
    partial class Funcionarios
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
            dgv = new DataGridView();
            utilizadorBindingSource = new BindingSource(components);
            iDUtilizadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            palavraPasseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeUtilizadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailUtilizadorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)utilizadorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { iDUtilizadorDataGridViewTextBoxColumn, palavraPasseDataGridViewTextBoxColumn, nomeUtilizadorDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, emailUtilizadorDataGridViewTextBoxColumn });
            dgv.DataSource = utilizadorBindingSource;
            dgv.Location = new Point(78, 25);
            dgv.Name = "dgv";
            dgv.Size = new Size(605, 150);
            dgv.TabIndex = 0;
            // 
            // utilizadorBindingSource
            // 
            utilizadorBindingSource.DataSource = typeof(Utilizador);
            // 
            // iDUtilizadorDataGridViewTextBoxColumn
            // 
            iDUtilizadorDataGridViewTextBoxColumn.DataPropertyName = "ID_Utilizador";
            iDUtilizadorDataGridViewTextBoxColumn.HeaderText = "ID_Utilizador";
            iDUtilizadorDataGridViewTextBoxColumn.Name = "iDUtilizadorDataGridViewTextBoxColumn";
            // 
            // palavraPasseDataGridViewTextBoxColumn
            // 
            palavraPasseDataGridViewTextBoxColumn.DataPropertyName = "Palavra_Passe";
            palavraPasseDataGridViewTextBoxColumn.HeaderText = "Palavra_Passe";
            palavraPasseDataGridViewTextBoxColumn.Name = "palavraPasseDataGridViewTextBoxColumn";
            // 
            // nomeUtilizadorDataGridViewTextBoxColumn
            // 
            nomeUtilizadorDataGridViewTextBoxColumn.DataPropertyName = "Nome_Utilizador";
            nomeUtilizadorDataGridViewTextBoxColumn.HeaderText = "Nome_Utilizador";
            nomeUtilizadorDataGridViewTextBoxColumn.Name = "nomeUtilizadorDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // emailUtilizadorDataGridViewTextBoxColumn
            // 
            emailUtilizadorDataGridViewTextBoxColumn.DataPropertyName = "Email_Utilizador";
            emailUtilizadorDataGridViewTextBoxColumn.HeaderText = "Email_Utilizador";
            emailUtilizadorDataGridViewTextBoxColumn.Name = "emailUtilizadorDataGridViewTextBoxColumn";
            // 
            // Funcionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv);
            Name = "Funcionarios";
            Text = "Funcionario";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)utilizadorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn iDUtilizadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn palavraPasseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeUtilizadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailUtilizadorDataGridViewTextBoxColumn;
        private BindingSource utilizadorBindingSource;
    }
}