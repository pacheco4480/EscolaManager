namespace EscolaManager.Forms
{
    partial class FormTurmas
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
            dataGridViewTurmas = new DataGridView();
            panel2 = new Panel();
            btnAdicionarTurma = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurmas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(dataGridViewTurmas);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnAdicionarTurma);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 612);
            panel1.TabIndex = 0;
            // 
            // dataGridViewTurmas
            // 
            dataGridViewTurmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTurmas.Location = new Point(36, 145);
            dataGridViewTurmas.Name = "dataGridViewTurmas";
            dataGridViewTurmas.Size = new Size(907, 415);
            dataGridViewTurmas.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 26);
            panel2.Location = new Point(21, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 2);
            panel2.TabIndex = 4;
            // 
            // btnAdicionarTurma
            // 
            btnAdicionarTurma.Cursor = Cursors.Hand;
            btnAdicionarTurma.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarTurma.Location = new Point(842, 38);
            btnAdicionarTurma.Name = "btnAdicionarTurma";
            btnAdicionarTurma.Size = new Size(101, 38);
            btnAdicionarTurma.TabIndex = 3;
            btnAdicionarTurma.Text = "Adicionar";
            btnAdicionarTurma.UseVisualStyleBackColor = true;
            btnAdicionarTurma.Click += btnAdicionarTurma_Click_1;
            // 
            // FormTurmas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 612);
            Controls.Add(panel1);
            Name = "FormTurmas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTurmas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurmas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewTurmas;
        private Panel panel2;
        private Button btnAdicionarTurma;
    }
}