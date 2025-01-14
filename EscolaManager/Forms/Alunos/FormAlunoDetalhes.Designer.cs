namespace EscolaManager.Forms
{
    partial class FormAlunoDetalhes
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
            button1 = new Button();
            lblTitulo = new Label();
            panel2 = new Panel();
            checkedListDAluno = new CheckedListBox();
            label15 = new Label();
            comboBoxStatusAluno = new ComboBox();
            comboBoxMensalidadeAluno = new ComboBox();
            comboBoxTurmaAluno = new ComboBox();
            comboBoxAlunoParente = new ComboBox();
            comboBoxGeneroAluno = new ComboBox();
            textEscolaAAluno = new TextBox();
            textMoradaAluno = new TextBox();
            textEmailAluno = new TextBox();
            textTelemovelAluno = new TextBox();
            textApelidoAluno = new TextBox();
            textNomeAluno = new TextBox();
            textDMatriculaAluno = new TextBox();
            textIDAluno = new TextBox();
            panel3 = new Panel();
            btnCancelarAlunosEdit = new Button();
            btnGuardarAlunos = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label14 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 26);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 55);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.close;
            button1.Location = new Point(597, 15);
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
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(checkedListDAluno);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(comboBoxStatusAluno);
            panel2.Controls.Add(comboBoxMensalidadeAluno);
            panel2.Controls.Add(comboBoxTurmaAluno);
            panel2.Controls.Add(comboBoxAlunoParente);
            panel2.Controls.Add(comboBoxGeneroAluno);
            panel2.Controls.Add(textEscolaAAluno);
            panel2.Controls.Add(textMoradaAluno);
            panel2.Controls.Add(textEmailAluno);
            panel2.Controls.Add(textTelemovelAluno);
            panel2.Controls.Add(textApelidoAluno);
            panel2.Controls.Add(textNomeAluno);
            panel2.Controls.Add(textDMatriculaAluno);
            panel2.Controls.Add(textIDAluno);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(661, 587);
            panel2.TabIndex = 1;
            // 
            // checkedListDAluno
            // 
            checkedListDAluno.FormattingEnabled = true;
            checkedListDAluno.Location = new Point(40, 412);
            checkedListDAluno.Name = "checkedListDAluno";
            checkedListDAluno.Size = new Size(120, 94);
            checkedListDAluno.TabIndex = 36;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(40, 391);
            label15.Name = "label15";
            label15.Size = new Size(82, 18);
            label15.TabIndex = 35;
            label15.Text = "Disciplinas";
            // 
            // comboBoxStatusAluno
            // 
            comboBoxStatusAluno.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxStatusAluno.Font = new Font("Lato", 9F);
            comboBoxStatusAluno.ForeColor = Color.White;
            comboBoxStatusAluno.FormattingEnabled = true;
            comboBoxStatusAluno.Location = new Point(361, 411);
            comboBoxStatusAluno.Name = "comboBoxStatusAluno";
            comboBoxStatusAluno.Size = new Size(121, 23);
            comboBoxStatusAluno.TabIndex = 3;
            // 
            // comboBoxMensalidadeAluno
            // 
            comboBoxMensalidadeAluno.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxMensalidadeAluno.Font = new Font("Lato", 9F);
            comboBoxMensalidadeAluno.ForeColor = Color.White;
            comboBoxMensalidadeAluno.FormattingEnabled = true;
            comboBoxMensalidadeAluno.Location = new Point(201, 411);
            comboBoxMensalidadeAluno.Name = "comboBoxMensalidadeAluno";
            comboBoxMensalidadeAluno.Size = new Size(121, 23);
            comboBoxMensalidadeAluno.TabIndex = 3;
            // 
            // comboBoxTurmaAluno
            // 
            comboBoxTurmaAluno.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxTurmaAluno.Font = new Font("Lato", 9F);
            comboBoxTurmaAluno.ForeColor = Color.White;
            comboBoxTurmaAluno.FormattingEnabled = true;
            comboBoxTurmaAluno.Location = new Point(40, 320);
            comboBoxTurmaAluno.Name = "comboBoxTurmaAluno";
            comboBoxTurmaAluno.Size = new Size(121, 23);
            comboBoxTurmaAluno.TabIndex = 3;
            // 
            // comboBoxAlunoParente
            // 
            comboBoxAlunoParente.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxAlunoParente.Font = new Font("Lato", 9F);
            comboBoxAlunoParente.ForeColor = Color.White;
            comboBoxAlunoParente.FormattingEnabled = true;
            comboBoxAlunoParente.Location = new Point(361, 135);
            comboBoxAlunoParente.Name = "comboBoxAlunoParente";
            comboBoxAlunoParente.Size = new Size(140, 23);
            comboBoxAlunoParente.TabIndex = 3;
            // 
            // comboBoxGeneroAluno
            // 
            comboBoxGeneroAluno.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxGeneroAluno.Font = new Font("Lato", 9F);
            comboBoxGeneroAluno.ForeColor = Color.White;
            comboBoxGeneroAluno.FormattingEnabled = true;
            comboBoxGeneroAluno.Location = new Point(480, 44);
            comboBoxGeneroAluno.Name = "comboBoxGeneroAluno";
            comboBoxGeneroAluno.Size = new Size(140, 23);
            comboBoxGeneroAluno.TabIndex = 3;
            // 
            // textEscolaAAluno
            // 
            textEscolaAAluno.BackColor = Color.FromArgb(26, 26, 26);
            textEscolaAAluno.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEscolaAAluno.ForeColor = Color.White;
            textEscolaAAluno.Location = new Point(198, 321);
            textEscolaAAluno.Name = "textEscolaAAluno";
            textEscolaAAluno.Size = new Size(283, 22);
            textEscolaAAluno.TabIndex = 2;
            // 
            // textMoradaAluno
            // 
            textMoradaAluno.BackColor = Color.FromArgb(26, 26, 26);
            textMoradaAluno.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textMoradaAluno.ForeColor = Color.White;
            textMoradaAluno.Location = new Point(312, 228);
            textMoradaAluno.Name = "textMoradaAluno";
            textMoradaAluno.Size = new Size(308, 22);
            textMoradaAluno.TabIndex = 2;
            // 
            // textEmailAluno
            // 
            textEmailAluno.BackColor = Color.FromArgb(26, 26, 26);
            textEmailAluno.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEmailAluno.ForeColor = Color.White;
            textEmailAluno.Location = new Point(38, 228);
            textEmailAluno.Name = "textEmailAluno";
            textEmailAluno.Size = new Size(234, 22);
            textEmailAluno.TabIndex = 2;
            // 
            // textTelemovelAluno
            // 
            textTelemovelAluno.BackColor = Color.FromArgb(26, 26, 26);
            textTelemovelAluno.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textTelemovelAluno.ForeColor = Color.White;
            textTelemovelAluno.Location = new Point(196, 134);
            textTelemovelAluno.Name = "textTelemovelAluno";
            textTelemovelAluno.Size = new Size(128, 22);
            textTelemovelAluno.TabIndex = 2;
            // 
            // textApelidoAluno
            // 
            textApelidoAluno.BackColor = Color.FromArgb(26, 26, 26);
            textApelidoAluno.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textApelidoAluno.ForeColor = Color.White;
            textApelidoAluno.Location = new Point(312, 45);
            textApelidoAluno.Name = "textApelidoAluno";
            textApelidoAluno.Size = new Size(128, 22);
            textApelidoAluno.TabIndex = 2;
            // 
            // textNomeAluno
            // 
            textNomeAluno.BackColor = Color.FromArgb(26, 26, 26);
            textNomeAluno.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNomeAluno.ForeColor = Color.White;
            textNomeAluno.Location = new Point(145, 45);
            textNomeAluno.Name = "textNomeAluno";
            textNomeAluno.Size = new Size(128, 22);
            textNomeAluno.TabIndex = 2;
            // 
            // textDMatriculaAluno
            // 
            textDMatriculaAluno.BackColor = Color.FromArgb(26, 26, 26);
            textDMatriculaAluno.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDMatriculaAluno.ForeColor = Color.White;
            textDMatriculaAluno.Location = new Point(38, 135);
            textDMatriculaAluno.Name = "textDMatriculaAluno";
            textDMatriculaAluno.PlaceholderText = "dd/MM/yyyy";
            textDMatriculaAluno.Size = new Size(122, 22);
            textDMatriculaAluno.TabIndex = 2;
            // 
            // textIDAluno
            // 
            textIDAluno.BackColor = Color.White;
            textIDAluno.Enabled = false;
            textIDAluno.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textIDAluno.ForeColor = Color.White;
            textIDAluno.Location = new Point(38, 45);
            textIDAluno.Name = "textIDAluno";
            textIDAluno.Size = new Size(67, 22);
            textIDAluno.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 26, 26);
            panel3.Controls.Add(btnCancelarAlunosEdit);
            panel3.Controls.Add(btnGuardarAlunos);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 532);
            panel3.Name = "panel3";
            panel3.Size = new Size(661, 55);
            panel3.TabIndex = 1;
            // 
            // btnCancelarAlunosEdit
            // 
            btnCancelarAlunosEdit.BackColor = Color.FromArgb(255, 128, 0);
            btnCancelarAlunosEdit.Cursor = Cursors.Hand;
            btnCancelarAlunosEdit.FlatStyle = FlatStyle.Flat;
            btnCancelarAlunosEdit.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarAlunosEdit.Location = new Point(519, 14);
            btnCancelarAlunosEdit.Name = "btnCancelarAlunosEdit";
            btnCancelarAlunosEdit.Size = new Size(101, 29);
            btnCancelarAlunosEdit.TabIndex = 37;
            btnCancelarAlunosEdit.Text = "Cancelar";
            btnCancelarAlunosEdit.UseVisualStyleBackColor = false;
            btnCancelarAlunosEdit.Click += btnCancelarAlunosEdit_Click;
            // 
            // btnGuardarAlunos
            // 
            btnGuardarAlunos.BackColor = Color.FromArgb(118, 201, 79);
            btnGuardarAlunos.Cursor = Cursors.Hand;
            btnGuardarAlunos.FlatStyle = FlatStyle.Flat;
            btnGuardarAlunos.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarAlunos.Location = new Point(381, 14);
            btnGuardarAlunos.Name = "btnGuardarAlunos";
            btnGuardarAlunos.Size = new Size(101, 29);
            btnGuardarAlunos.TabIndex = 0;
            btnGuardarAlunos.Text = "Guardar";
            btnGuardarAlunos.UseVisualStyleBackColor = false;
            btnGuardarAlunos.Click += btnGuardarAlunos_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(361, 391);
            label13.Name = "label13";
            label13.Size = new Size(51, 18);
            label13.TabIndex = 0;
            label13.Text = "Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(201, 391);
            label12.Name = "label12";
            label12.Size = new Size(93, 18);
            label12.TabIndex = 0;
            label12.Text = "Mensalidade";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(198, 299);
            label11.Name = "label11";
            label11.Size = new Size(107, 18);
            label11.TabIndex = 0;
            label11.Text = "Escola anterior";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(40, 299);
            label10.Name = "label10";
            label10.Size = new Size(51, 18);
            label10.TabIndex = 0;
            label10.Text = "Turma";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(312, 207);
            label9.Name = "label9";
            label9.Size = new Size(58, 18);
            label9.TabIndex = 0;
            label9.Text = "Morada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(38, 207);
            label8.Name = "label8";
            label8.Size = new Size(45, 18);
            label8.TabIndex = 0;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(361, 114);
            label7.Name = "label7";
            label7.Size = new Size(104, 18);
            label7.TabIndex = 0;
            label7.Text = "Nome Parente";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(198, 114);
            label14.Name = "label14";
            label14.Size = new Size(77, 18);
            label14.TabIndex = 0;
            label14.Text = "Telemóvel";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 114);
            label5.Name = "label5";
            label5.Size = new Size(126, 18);
            label5.TabIndex = 0;
            label5.Text = "Data da Matricúla";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(480, 23);
            label4.Name = "label4";
            label4.Size = new Size(55, 18);
            label4.TabIndex = 0;
            label4.Text = "Género";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(312, 24);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 0;
            label3.Text = "Apelido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(145, 24);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 24);
            label1.Name = "label1";
            label1.Size = new Size(22, 18);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // FormAlunoDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 642);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAlunoDetalhes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAlunoDetalhes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTitulo;
        private Label label2;
        private Label label1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Button btnGuardarAlunos;
        private TextBox textIDAluno;
        private ComboBox comboBoxGeneroAluno;
        private TextBox textEscolaAAluno;
        private TextBox textNomeAluno;
        private TextBox textDMatriculaAluno;
        private ComboBox comboBoxStatusAluno;
        private ComboBox comboBoxMensalidadeAluno;
        private ComboBox comboBoxTurmaAluno;
        private TextBox textMoradaAluno;
        private TextBox textEmailAluno;
        private TextBox textApelidoAluno;
        private Button button1;
        private TextBox textTelemovelAluno;
        private Label label14;
        private CheckedListBox checkedListDAluno;
        private Label label15;
        private ComboBox comboBoxAlunoParente;
        private Button btnCancelarAlunosEdit;
    }
}