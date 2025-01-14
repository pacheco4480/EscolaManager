namespace EscolaManager.Forms
{
    partial class FormTarifasMensais
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
            dataGridViewTarifas = new DataGridView();
            panel2 = new Panel();
            btnAdicionarTarifas = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(dataGridViewTarifas);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnAdicionarTarifas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 612);
            panel1.TabIndex = 0;
            // 
            // dataGridViewTarifas
            // 
            dataGridViewTarifas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarifas.Location = new Point(36, 145);
            dataGridViewTarifas.Name = "dataGridViewTarifas";
            dataGridViewTarifas.Size = new Size(907, 415);
            dataGridViewTarifas.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 26);
            panel2.Location = new Point(21, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 2);
            panel2.TabIndex = 4;
            // 
            // btnAdicionarTarifas
            // 
            btnAdicionarTarifas.Cursor = Cursors.Hand;
            btnAdicionarTarifas.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarTarifas.Location = new Point(842, 38);
            btnAdicionarTarifas.Name = "btnAdicionarTarifas";
            btnAdicionarTarifas.Size = new Size(101, 38);
            btnAdicionarTarifas.TabIndex = 3;
            btnAdicionarTarifas.Text = "Adicionar";
            btnAdicionarTarifas.UseVisualStyleBackColor = true;
            btnAdicionarTarifas.Click += btnAdicionarTarifas_Click;
            // 
            // FormTarifasMensais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 612);
            Controls.Add(panel1);
            Name = "FormTarifasMensais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTarifasMensais";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewTarifas;
        private Panel panel2;
        private Button btnAdicionarTarifas;
    }
}