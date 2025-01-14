namespace EscolaManager.Forms
{
    partial class FormTurmaEditar
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
            comboBoxStatusTurmaEdit = new ComboBox();
            comboBoxPeriodoTurmaEdit = new ComboBox();
            textTurmaAnoEdit = new TextBox();
            textNomeTurmaEdit = new TextBox();
            textIDTurmaEdit = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnCancelarTurmaEdit = new Button();
            btnGuardarTurmaEdit = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            lblTituloEdit = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(comboBoxStatusTurmaEdit);
            panel1.Controls.Add(comboBoxPeriodoTurmaEdit);
            panel1.Controls.Add(textTurmaAnoEdit);
            panel1.Controls.Add(textNomeTurmaEdit);
            panel1.Controls.Add(textIDTurmaEdit);
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
            // comboBoxStatusTurmaEdit
            // 
            comboBoxStatusTurmaEdit.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxStatusTurmaEdit.Font = new Font("Lato", 9F);
            comboBoxStatusTurmaEdit.ForeColor = Color.White;
            comboBoxStatusTurmaEdit.FormattingEnabled = true;
            comboBoxStatusTurmaEdit.Location = new Point(201, 194);
            comboBoxStatusTurmaEdit.Name = "comboBoxStatusTurmaEdit";
            comboBoxStatusTurmaEdit.Size = new Size(128, 23);
            comboBoxStatusTurmaEdit.TabIndex = 98;
            // 
            // comboBoxPeriodoTurmaEdit
            // 
            comboBoxPeriodoTurmaEdit.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxPeriodoTurmaEdit.Font = new Font("Lato", 9F);
            comboBoxPeriodoTurmaEdit.ForeColor = Color.White;
            comboBoxPeriodoTurmaEdit.FormattingEnabled = true;
            comboBoxPeriodoTurmaEdit.Location = new Point(34, 194);
            comboBoxPeriodoTurmaEdit.Name = "comboBoxPeriodoTurmaEdit";
            comboBoxPeriodoTurmaEdit.Size = new Size(128, 23);
            comboBoxPeriodoTurmaEdit.TabIndex = 99;
            // 
            // textTurmaAnoEdit
            // 
            textTurmaAnoEdit.BackColor = Color.FromArgb(26, 26, 26);
            textTurmaAnoEdit.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTurmaAnoEdit.ForeColor = Color.White;
            textTurmaAnoEdit.Location = new Point(314, 99);
            textTurmaAnoEdit.Name = "textTurmaAnoEdit";
            textTurmaAnoEdit.Size = new Size(128, 22);
            textTurmaAnoEdit.TabIndex = 96;
            // 
            // textNomeTurmaEdit
            // 
            textNomeTurmaEdit.BackColor = Color.FromArgb(26, 26, 26);
            textNomeTurmaEdit.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNomeTurmaEdit.ForeColor = Color.White;
            textNomeTurmaEdit.Location = new Point(147, 99);
            textNomeTurmaEdit.Name = "textNomeTurmaEdit";
            textNomeTurmaEdit.Size = new Size(128, 22);
            textNomeTurmaEdit.TabIndex = 97;
            // 
            // textIDTurmaEdit
            // 
            textIDTurmaEdit.BackColor = Color.White;
            textIDTurmaEdit.Enabled = false;
            textIDTurmaEdit.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textIDTurmaEdit.ForeColor = Color.White;
            textIDTurmaEdit.Location = new Point(40, 98);
            textIDTurmaEdit.Name = "textIDTurmaEdit";
            textIDTurmaEdit.Size = new Size(67, 22);
            textIDTurmaEdit.TabIndex = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(314, 77);
            label3.Name = "label3";
            label3.Size = new Size(34, 18);
            label3.TabIndex = 93;
            label3.Text = "Ano";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(147, 77);
            label2.Name = "label2";
            label2.Size = new Size(95, 18);
            label2.TabIndex = 94;
            label2.Text = "Turma Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(202, 173);
            label5.Name = "label5";
            label5.Size = new Size(51, 18);
            label5.TabIndex = 90;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(35, 173);
            label4.Name = "label4";
            label4.Size = new Size(59, 18);
            label4.TabIndex = 91;
            label4.Text = "Periodo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 77);
            label1.Name = "label1";
            label1.Size = new Size(22, 18);
            label1.TabIndex = 92;
            label1.Text = "ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 26, 26);
            panel3.Controls.Add(btnCancelarTurmaEdit);
            panel3.Controls.Add(btnGuardarTurmaEdit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 240);
            panel3.Name = "panel3";
            panel3.Size = new Size(484, 55);
            panel3.TabIndex = 11;
            // 
            // btnCancelarTurmaEdit
            // 
            btnCancelarTurmaEdit.BackColor = Color.FromArgb(255, 128, 0);
            btnCancelarTurmaEdit.Cursor = Cursors.Hand;
            btnCancelarTurmaEdit.FlatStyle = FlatStyle.Flat;
            btnCancelarTurmaEdit.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarTurmaEdit.Location = new Point(342, 14);
            btnCancelarTurmaEdit.Name = "btnCancelarTurmaEdit";
            btnCancelarTurmaEdit.Size = new Size(101, 29);
            btnCancelarTurmaEdit.TabIndex = 0;
            btnCancelarTurmaEdit.Text = "Cancelar";
            btnCancelarTurmaEdit.UseVisualStyleBackColor = false;
            btnCancelarTurmaEdit.Click += btnCancelarTurmaEdit_Click;
            // 
            // btnGuardarTurmaEdit
            // 
            btnGuardarTurmaEdit.BackColor = Color.FromArgb(118, 201, 79);
            btnGuardarTurmaEdit.Cursor = Cursors.Hand;
            btnGuardarTurmaEdit.FlatStyle = FlatStyle.Flat;
            btnGuardarTurmaEdit.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarTurmaEdit.Location = new Point(203, 14);
            btnGuardarTurmaEdit.Name = "btnGuardarTurmaEdit";
            btnGuardarTurmaEdit.Size = new Size(101, 29);
            btnGuardarTurmaEdit.TabIndex = 0;
            btnGuardarTurmaEdit.Text = "Guardar";
            btnGuardarTurmaEdit.UseVisualStyleBackColor = false;
            btnGuardarTurmaEdit.Click += btnGuardarTurmaEdit_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 26);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblTituloEdit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 55);
            panel2.TabIndex = 10;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Black;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.close;
            button2.Location = new Point(436, 15);
            button2.Name = "button2";
            button2.Size = new Size(23, 28);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.close;
            button1.Location = new Point(720, 15);
            button1.Name = "button1";
            button1.Size = new Size(23, 28);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // lblTituloEdit
            // 
            lblTituloEdit.AutoSize = true;
            lblTituloEdit.Font = new Font("Roboto", 15.75F, FontStyle.Bold);
            lblTituloEdit.ForeColor = Color.White;
            lblTituloEdit.Location = new Point(35, 15);
            lblTituloEdit.Name = "lblTituloEdit";
            lblTituloEdit.Size = new Size(70, 25);
            lblTituloEdit.TabIndex = 0;
            lblTituloEdit.Text = "label1";
            // 
            // FormTurmaEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 295);
            Controls.Add(panel1);
            Name = "FormTurmaEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTurmaEditar";
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
        private Button btnCancelarTurmaEdit;
        private Button btnGuardarTurmaEdit;
        private Panel panel2;
        private Button button1;
        private Label lblTituloEdit;
        private Button button2;
        private ComboBox comboBoxStatusTurmaEdit;
        private ComboBox comboBoxPeriodoTurmaEdit;
        private TextBox textTurmaAnoEdit;
        private TextBox textNomeTurmaEdit;
        private TextBox textIDTurmaEdit;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label1;
    }
}