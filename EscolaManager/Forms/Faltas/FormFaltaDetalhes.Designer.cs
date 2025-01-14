namespace EscolaManager.Forms
{
    partial class FormFaltaDetalhes
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
            dateTimePickerDataHora = new DateTimePicker();
            comboBoxAlunos = new ComboBox();
            comboBoxDisciplinas = new ComboBox();
            textIDFalta = new TextBox();
            textMotivo = new TextBox();
            label14 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnCancelarFalta = new Button();
            btnGuardarFalta = new Button();
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
            panel1.Controls.Add(dateTimePickerDataHora);
            panel1.Controls.Add(comboBoxAlunos);
            panel1.Controls.Add(comboBoxDisciplinas);
            panel1.Controls.Add(textIDFalta);
            panel1.Controls.Add(textMotivo);
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
            // dateTimePickerDataHora
            // 
            dateTimePickerDataHora.Format = DateTimePickerFormat.Short;
            dateTimePickerDataHora.Location = new Point(482, 98);
            dateTimePickerDataHora.Name = "dateTimePickerDataHora";
            dateTimePickerDataHora.Size = new Size(142, 23);
            dateTimePickerDataHora.TabIndex = 72;
            // 
            // comboBoxAlunos
            // 
            comboBoxAlunos.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxAlunos.Font = new Font("Lato", 9F);
            comboBoxAlunos.ForeColor = Color.White;
            comboBoxAlunos.FormattingEnabled = true;
            comboBoxAlunos.Location = new Point(147, 98);
            comboBoxAlunos.Name = "comboBoxAlunos";
            comboBoxAlunos.Size = new Size(128, 23);
            comboBoxAlunos.TabIndex = 68;
            // 
            // comboBoxDisciplinas
            // 
            comboBoxDisciplinas.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxDisciplinas.Font = new Font("Lato", 9F);
            comboBoxDisciplinas.ForeColor = Color.White;
            comboBoxDisciplinas.FormattingEnabled = true;
            comboBoxDisciplinas.Location = new Point(315, 98);
            comboBoxDisciplinas.Name = "comboBoxDisciplinas";
            comboBoxDisciplinas.Size = new Size(128, 23);
            comboBoxDisciplinas.TabIndex = 70;
            // 
            // textIDFalta
            // 
            textIDFalta.BackColor = Color.White;
            textIDFalta.Enabled = false;
            textIDFalta.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textIDFalta.ForeColor = Color.White;
            textIDFalta.Location = new Point(41, 99);
            textIDFalta.Name = "textIDFalta";
            textIDFalta.Size = new Size(67, 22);
            textIDFalta.TabIndex = 65;
            // 
            // textMotivo
            // 
            textMotivo.BackColor = Color.FromArgb(26, 26, 26);
            textMotivo.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textMotivo.ForeColor = Color.White;
            textMotivo.Location = new Point(39, 177);
            textMotivo.Multiline = true;
            textMotivo.Name = "textMotivo";
            textMotivo.Size = new Size(280, 108);
            textMotivo.TabIndex = 65;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(482, 77);
            label14.Name = "label14";
            label14.Size = new Size(39, 18);
            label14.TabIndex = 61;
            label14.Text = "Data";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(41, 157);
            label6.Name = "label6";
            label6.Size = new Size(90, 18);
            label6.TabIndex = 60;
            label6.Text = "Justificação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(315, 77);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 59;
            label4.Text = "Disciplina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(147, 77);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 58;
            label3.Text = "Nome Aluno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 77);
            label1.Name = "label1";
            label1.Size = new Size(22, 18);
            label1.TabIndex = 57;
            label1.Text = "ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 26, 26);
            panel3.Controls.Add(btnCancelarFalta);
            panel3.Controls.Add(btnGuardarFalta);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 309);
            panel3.Name = "panel3";
            panel3.Size = new Size(749, 55);
            panel3.TabIndex = 7;
            // 
            // btnCancelarFalta
            // 
            btnCancelarFalta.BackColor = Color.FromArgb(255, 128, 0);
            btnCancelarFalta.Cursor = Cursors.Hand;
            btnCancelarFalta.FlatStyle = FlatStyle.Flat;
            btnCancelarFalta.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarFalta.Location = new Point(606, 14);
            btnCancelarFalta.Name = "btnCancelarFalta";
            btnCancelarFalta.Size = new Size(101, 29);
            btnCancelarFalta.TabIndex = 89;
            btnCancelarFalta.Text = "Cancelar";
            btnCancelarFalta.UseVisualStyleBackColor = false;
            btnCancelarFalta.Click += btnCancelarFalta_Click;
            // 
            // btnGuardarFalta
            // 
            btnGuardarFalta.BackColor = Color.FromArgb(118, 201, 79);
            btnGuardarFalta.Cursor = Cursors.Hand;
            btnGuardarFalta.FlatStyle = FlatStyle.Flat;
            btnGuardarFalta.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarFalta.Location = new Point(467, 14);
            btnGuardarFalta.Name = "btnGuardarFalta";
            btnGuardarFalta.Size = new Size(101, 29);
            btnGuardarFalta.TabIndex = 0;
            btnGuardarFalta.Text = "Guardar";
            btnGuardarFalta.UseVisualStyleBackColor = false;
            btnGuardarFalta.Click += btnGuardarFalta_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 26);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(749, 55);
            panel2.TabIndex = 6;
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
            // FormFaltaDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 364);
            Controls.Add(panel1);
            Name = "FormFaltaDetalhes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFaltaDetalhes";
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
        private Button btnGuardarFalta;
        private Panel panel2;
        private Button button1;
        private Label lblTitulo;
        private ComboBox comboBoxAlunos;
        private ComboBox comboBoxDisciplinas;
        private TextBox textMotivo;
        private Label label14;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private DateTimePicker dateTimePickerDataHora;
        private TextBox textIDFalta;
        private Button btnCancelarFalta;
    }
}