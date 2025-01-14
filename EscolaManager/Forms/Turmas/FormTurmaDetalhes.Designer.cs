namespace EscolaManager.Forms
{
    partial class FormTurmaDetalhes
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
            comboBoxStatusTurma = new ComboBox();
            comboBoxPeriodoTurma = new ComboBox();
            textTurmaAno = new TextBox();
            textNomeTurma = new TextBox();
            textIDTurma = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnCancelarTurma = new Button();
            btnGuardarTurma = new Button();
            panel2 = new Panel();
            button1 = new Button();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(comboBoxStatusTurma);
            panel1.Controls.Add(comboBoxPeriodoTurma);
            panel1.Controls.Add(textTurmaAno);
            panel1.Controls.Add(textNomeTurma);
            panel1.Controls.Add(textIDTurma);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 295);
            panel1.TabIndex = 0;
            // 
            // comboBoxStatusTurma
            // 
            comboBoxStatusTurma.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxStatusTurma.Font = new Font("Lato", 9F);
            comboBoxStatusTurma.ForeColor = Color.White;
            comboBoxStatusTurma.FormattingEnabled = true;
            comboBoxStatusTurma.Location = new Point(202, 194);
            comboBoxStatusTurma.Name = "comboBoxStatusTurma";
            comboBoxStatusTurma.Size = new Size(128, 23);
            comboBoxStatusTurma.TabIndex = 83;
            // 
            // comboBoxPeriodoTurma
            // 
            comboBoxPeriodoTurma.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxPeriodoTurma.Font = new Font("Lato", 9F);
            comboBoxPeriodoTurma.ForeColor = Color.White;
            comboBoxPeriodoTurma.FormattingEnabled = true;
            comboBoxPeriodoTurma.Location = new Point(35, 194);
            comboBoxPeriodoTurma.Name = "comboBoxPeriodoTurma";
            comboBoxPeriodoTurma.Size = new Size(128, 23);
            comboBoxPeriodoTurma.TabIndex = 83;
            // 
            // textTurmaAno
            // 
            textTurmaAno.BackColor = Color.FromArgb(26, 26, 26);
            textTurmaAno.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTurmaAno.ForeColor = Color.White;
            textTurmaAno.Location = new Point(315, 99);
            textTurmaAno.Name = "textTurmaAno";
            textTurmaAno.Size = new Size(128, 22);
            textTurmaAno.TabIndex = 82;
            // 
            // textNomeTurma
            // 
            textNomeTurma.BackColor = Color.FromArgb(26, 26, 26);
            textNomeTurma.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNomeTurma.ForeColor = Color.White;
            textNomeTurma.Location = new Point(148, 99);
            textNomeTurma.Name = "textNomeTurma";
            textNomeTurma.Size = new Size(128, 22);
            textNomeTurma.TabIndex = 82;
            // 
            // textIDTurma
            // 
            textIDTurma.BackColor = Color.White;
            textIDTurma.Enabled = false;
            textIDTurma.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textIDTurma.ForeColor = Color.White;
            textIDTurma.Location = new Point(41, 98);
            textIDTurma.Name = "textIDTurma";
            textIDTurma.Size = new Size(67, 22);
            textIDTurma.TabIndex = 80;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(315, 77);
            label3.Name = "label3";
            label3.Size = new Size(34, 18);
            label3.TabIndex = 73;
            label3.Text = "Ano";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(148, 77);
            label2.Name = "label2";
            label2.Size = new Size(95, 18);
            label2.TabIndex = 79;
            label2.Text = "Turma Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(203, 173);
            label5.Name = "label5";
            label5.Size = new Size(51, 18);
            label5.TabIndex = 72;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(36, 173);
            label4.Name = "label4";
            label4.Size = new Size(59, 18);
            label4.TabIndex = 72;
            label4.Text = "Periodo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 77);
            label1.Name = "label1";
            label1.Size = new Size(22, 18);
            label1.TabIndex = 72;
            label1.Text = "ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 26, 26);
            panel3.Controls.Add(btnCancelarTurma);
            panel3.Controls.Add(btnGuardarTurma);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 240);
            panel3.Name = "panel3";
            panel3.Size = new Size(484, 55);
            panel3.TabIndex = 9;
            // 
            // btnCancelarTurma
            // 
            btnCancelarTurma.BackColor = Color.FromArgb(255, 128, 0);
            btnCancelarTurma.Cursor = Cursors.Hand;
            btnCancelarTurma.FlatStyle = FlatStyle.Flat;
            btnCancelarTurma.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarTurma.Location = new Point(342, 14);
            btnCancelarTurma.Name = "btnCancelarTurma";
            btnCancelarTurma.Size = new Size(101, 29);
            btnCancelarTurma.TabIndex = 0;
            btnCancelarTurma.Text = "Cancelar";
            btnCancelarTurma.UseVisualStyleBackColor = false;
            btnCancelarTurma.Click += btnCancelarTurma_Click;
            // 
            // btnGuardarTurma
            // 
            btnGuardarTurma.BackColor = Color.FromArgb(118, 201, 79);
            btnGuardarTurma.Cursor = Cursors.Hand;
            btnGuardarTurma.FlatStyle = FlatStyle.Flat;
            btnGuardarTurma.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarTurma.Location = new Point(203, 14);
            btnGuardarTurma.Name = "btnGuardarTurma";
            btnGuardarTurma.Size = new Size(101, 29);
            btnGuardarTurma.TabIndex = 0;
            btnGuardarTurma.Text = "Guardar";
            btnGuardarTurma.UseVisualStyleBackColor = false;
            btnGuardarTurma.Click += btnGuardarTurma_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 26);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 55);
            panel2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.close;
            button1.Location = new Point(436, 15);
            button1.Name = "button1";
            button1.Size = new Size(23, 28);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Roboto", 15.75F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(35, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(70, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "label1";
            // 
            // FormTurmaDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 295);
            Controls.Add(panel1);
            Name = "FormTurmaDetalhes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTurmaDetalhes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btnCancelarTurma;
        private Button btnGuardarTurma;
        private Panel panel2;
        private Button button1;
        private Label lblTitulo;
        private ComboBox comboBoxPeriodoTurma;
        private TextBox textIDTurma;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textNomeTurma;
        private TextBox textTurmaAno;
        private Label label4;
        private ComboBox comboBoxStatusTurma;
        private Label label5;
    }
}