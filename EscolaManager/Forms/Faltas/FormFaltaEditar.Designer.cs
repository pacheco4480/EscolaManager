namespace EscolaManager.Forms
{
    partial class FormFaltaEditar
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
            dateTimePickerDataHoraEdit = new DateTimePicker();
            comboBoxAlunosEdit = new ComboBox();
            comboBoxDisciplinasEdit = new ComboBox();
            textIDFaltaEdit = new TextBox();
            textMotivoEdit = new TextBox();
            label14 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnCancelarFaltaEdit = new Button();
            btnGuardarFaltaEdit = new Button();
            panel2 = new Panel();
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
            panel1.Controls.Add(dateTimePickerDataHoraEdit);
            panel1.Controls.Add(comboBoxAlunosEdit);
            panel1.Controls.Add(comboBoxDisciplinasEdit);
            panel1.Controls.Add(textIDFaltaEdit);
            panel1.Controls.Add(textMotivoEdit);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 364);
            panel1.TabIndex = 0;
            // 
            // dateTimePickerDataHoraEdit
            // 
            dateTimePickerDataHoraEdit.Format = DateTimePickerFormat.Short;
            dateTimePickerDataHoraEdit.Location = new Point(483, 100);
            dateTimePickerDataHoraEdit.Name = "dateTimePickerDataHoraEdit";
            dateTimePickerDataHoraEdit.Size = new Size(142, 23);
            dateTimePickerDataHoraEdit.TabIndex = 84;
            // 
            // comboBoxAlunosEdit
            // 
            comboBoxAlunosEdit.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxAlunosEdit.Font = new Font("Lato", 9F);
            comboBoxAlunosEdit.ForeColor = Color.White;
            comboBoxAlunosEdit.FormattingEnabled = true;
            comboBoxAlunosEdit.Location = new Point(148, 100);
            comboBoxAlunosEdit.Name = "comboBoxAlunosEdit";
            comboBoxAlunosEdit.Size = new Size(128, 23);
            comboBoxAlunosEdit.TabIndex = 82;
            // 
            // comboBoxDisciplinasEdit
            // 
            comboBoxDisciplinasEdit.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxDisciplinasEdit.Font = new Font("Lato", 9F);
            comboBoxDisciplinasEdit.ForeColor = Color.White;
            comboBoxDisciplinasEdit.FormattingEnabled = true;
            comboBoxDisciplinasEdit.Location = new Point(316, 100);
            comboBoxDisciplinasEdit.Name = "comboBoxDisciplinasEdit";
            comboBoxDisciplinasEdit.Size = new Size(128, 23);
            comboBoxDisciplinasEdit.TabIndex = 83;
            // 
            // textIDFaltaEdit
            // 
            textIDFaltaEdit.BackColor = Color.White;
            textIDFaltaEdit.Enabled = false;
            textIDFaltaEdit.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textIDFaltaEdit.ForeColor = Color.White;
            textIDFaltaEdit.Location = new Point(42, 101);
            textIDFaltaEdit.Name = "textIDFaltaEdit";
            textIDFaltaEdit.Size = new Size(67, 22);
            textIDFaltaEdit.TabIndex = 80;
            // 
            // textMotivoEdit
            // 
            textMotivoEdit.BackColor = Color.FromArgb(26, 26, 26);
            textMotivoEdit.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textMotivoEdit.ForeColor = Color.White;
            textMotivoEdit.Location = new Point(40, 179);
            textMotivoEdit.Multiline = true;
            textMotivoEdit.Name = "textMotivoEdit";
            textMotivoEdit.Size = new Size(280, 108);
            textMotivoEdit.TabIndex = 81;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(483, 79);
            label14.Name = "label14";
            label14.Size = new Size(39, 18);
            label14.TabIndex = 79;
            label14.Text = "Data";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(42, 159);
            label6.Name = "label6";
            label6.Size = new Size(90, 18);
            label6.TabIndex = 78;
            label6.Text = "Justificação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(316, 79);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 77;
            label4.Text = "Disciplina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(148, 79);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 76;
            label3.Text = "Nome Aluno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 79);
            label1.Name = "label1";
            label1.Size = new Size(22, 18);
            label1.TabIndex = 75;
            label1.Text = "ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 26, 26);
            panel3.Controls.Add(btnCancelarFaltaEdit);
            panel3.Controls.Add(btnGuardarFaltaEdit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(749, 55);
            panel3.TabIndex = 9;
            // 
            // btnCancelarFaltaEdit
            // 
            btnCancelarFaltaEdit.BackColor = Color.FromArgb(255, 128, 0);
            btnCancelarFaltaEdit.Cursor = Cursors.Hand;
            btnCancelarFaltaEdit.FlatStyle = FlatStyle.Flat;
            btnCancelarFaltaEdit.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarFaltaEdit.Location = new Point(606, 14);
            btnCancelarFaltaEdit.Name = "btnCancelarFaltaEdit";
            btnCancelarFaltaEdit.Size = new Size(101, 29);
            btnCancelarFaltaEdit.TabIndex = 87;
            btnCancelarFaltaEdit.Text = "Cancelar";
            btnCancelarFaltaEdit.UseVisualStyleBackColor = false;
            btnCancelarFaltaEdit.Click += btnCancelarFaltaEdit_Click;
            // 
            // btnGuardarFaltaEdit
            // 
            btnGuardarFaltaEdit.BackColor = Color.FromArgb(118, 201, 79);
            btnGuardarFaltaEdit.Cursor = Cursors.Hand;
            btnGuardarFaltaEdit.FlatStyle = FlatStyle.Flat;
            btnGuardarFaltaEdit.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarFaltaEdit.Location = new Point(467, 14);
            btnGuardarFaltaEdit.Name = "btnGuardarFaltaEdit";
            btnGuardarFaltaEdit.Size = new Size(101, 29);
            btnGuardarFaltaEdit.TabIndex = 0;
            btnGuardarFaltaEdit.Text = "Guardar";
            btnGuardarFaltaEdit.UseVisualStyleBackColor = false;
            btnGuardarFaltaEdit.Click += btnGuardarFaltaEdit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 26);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblTituloEdit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(749, 55);
            panel2.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.close;
            button1.Location = new Point(684, 16);
            button1.Name = "button1";
            button1.Size = new Size(23, 28);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // FormFaltaEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 364);
            Controls.Add(panel1);
            Name = "FormFaltaEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFaltaEditar";
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
        private Button btnGuardarFaltaEdit;
        private Panel panel2;
        private Button button1;
        private Label lblTituloEdit;
        private DateTimePicker dateTimePickerDataHoraEdit;
        private ComboBox comboBoxAlunosEdit;
        private ComboBox comboBoxDisciplinasEdit;
        private TextBox textIDFaltaEdit;
        private TextBox textMotivoEdit;
        private Label label14;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnCancelarFaltaEdit;
    }
}