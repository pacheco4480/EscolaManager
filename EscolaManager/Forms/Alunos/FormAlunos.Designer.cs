namespace EscolaManager.Forms
{
    partial class FormAlunos
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
            panel1 = new Panel();
            dataGridViewAlunos = new DataGridView();
            panel2 = new Panel();
            btnAdicionarAluno = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlunos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(dataGridViewAlunos);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnAdicionarAluno);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 612);
            panel1.TabIndex = 0;
            // 
            // dataGridViewAlunos
            // 
            dataGridViewAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlunos.Location = new Point(36, 145);
            dataGridViewAlunos.Name = "dataGridViewAlunos";
            dataGridViewAlunos.Size = new Size(907, 415);
            dataGridViewAlunos.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 26);
            panel2.Location = new Point(21, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 2);
            panel2.TabIndex = 1;
            // 
            // btnAdicionarAluno
            // 
            btnAdicionarAluno.Cursor = Cursors.Hand;
            btnAdicionarAluno.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarAluno.Location = new Point(842, 38);
            btnAdicionarAluno.Name = "btnAdicionarAluno";
            btnAdicionarAluno.Size = new Size(101, 38);
            btnAdicionarAluno.TabIndex = 0;
            btnAdicionarAluno.Text = "Adicionar";
            btnAdicionarAluno.UseVisualStyleBackColor = true;
            btnAdicionarAluno.Click += btnAdicionarAluno_Click;
            // 
            // FormAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 612);
            Controls.Add(panel1);
            Name = "FormAlunos";
            Text = "FormAlunos";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlunos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdicionarAluno;
        private DataGridView dataGridViewAlunos;
        private Panel panel2;
    }
}