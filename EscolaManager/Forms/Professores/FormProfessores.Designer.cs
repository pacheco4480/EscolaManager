namespace EscolaManager.Forms
{
    partial class FormProfessores
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
            dataGridViewProfessores = new DataGridView();
            btnAdicionarProfessores = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfessores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(dataGridViewProfessores);
            panel1.Controls.Add(btnAdicionarProfessores);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 612);
            panel1.TabIndex = 0;
            // 
            // dataGridViewProfessores
            // 
            dataGridViewProfessores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProfessores.Location = new Point(36, 145);
            dataGridViewProfessores.Name = "dataGridViewProfessores";
            dataGridViewProfessores.Size = new Size(907, 415);
            dataGridViewProfessores.TabIndex = 5;
            // 
            // btnAdicionarProfessores
            // 
            btnAdicionarProfessores.Cursor = Cursors.Hand;
            btnAdicionarProfessores.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarProfessores.Location = new Point(842, 38);
            btnAdicionarProfessores.Name = "btnAdicionarProfessores";
            btnAdicionarProfessores.Size = new Size(101, 38);
            btnAdicionarProfessores.TabIndex = 3;
            btnAdicionarProfessores.Text = "Adicionar";
            btnAdicionarProfessores.UseVisualStyleBackColor = true;
            btnAdicionarProfessores.Click += btnAdicionarProfessores_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 26);
            panel2.Location = new Point(21, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 2);
            panel2.TabIndex = 4;
            // 
            // FormProfessores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 612);
            Controls.Add(panel1);
            Name = "FormProfessores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProfessores";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfessores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewProfessores;
        private Button btnAdicionarProfessores;
        private Panel panel2;
    }
}