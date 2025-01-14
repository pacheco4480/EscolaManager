namespace EscolaManager.Forms
{
    partial class FormTarifaMensalEditar
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
            comboBoxStatusTarifaEdit = new ComboBox();
            textBoxValorTarifaEdit = new TextBox();
            textBoxDescricaoTarifaEdit = new TextBox();
            textBoxIDTarifaEdit = new TextBox();
            textBoxNomeTarifaEdit = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnCancelarTarifaEdit = new Button();
            btnGuardarTarifasEdit = new Button();
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
            panel1.Controls.Add(comboBoxStatusTarifaEdit);
            panel1.Controls.Add(textBoxValorTarifaEdit);
            panel1.Controls.Add(textBoxDescricaoTarifaEdit);
            panel1.Controls.Add(textBoxIDTarifaEdit);
            panel1.Controls.Add(textBoxNomeTarifaEdit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 288);
            panel1.TabIndex = 0;
            // 
            // comboBoxStatusTarifaEdit
            // 
            comboBoxStatusTarifaEdit.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxStatusTarifaEdit.Font = new Font("Lato", 9F);
            comboBoxStatusTarifaEdit.ForeColor = Color.White;
            comboBoxStatusTarifaEdit.FormattingEnabled = true;
            comboBoxStatusTarifaEdit.Location = new Point(145, 189);
            comboBoxStatusTarifaEdit.Name = "comboBoxStatusTarifaEdit";
            comboBoxStatusTarifaEdit.Size = new Size(103, 23);
            comboBoxStatusTarifaEdit.TabIndex = 107;
            // 
            // textBoxValorTarifaEdit
            // 
            textBoxValorTarifaEdit.BackColor = Color.FromArgb(26, 26, 26);
            textBoxValorTarifaEdit.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxValorTarifaEdit.ForeColor = Color.White;
            textBoxValorTarifaEdit.Location = new Point(40, 189);
            textBoxValorTarifaEdit.Name = "textBoxValorTarifaEdit";
            textBoxValorTarifaEdit.Size = new Size(67, 22);
            textBoxValorTarifaEdit.TabIndex = 105;
            // 
            // textBoxDescricaoTarifaEdit
            // 
            textBoxDescricaoTarifaEdit.BackColor = Color.FromArgb(26, 26, 26);
            textBoxDescricaoTarifaEdit.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescricaoTarifaEdit.ForeColor = Color.White;
            textBoxDescricaoTarifaEdit.Location = new Point(252, 92);
            textBoxDescricaoTarifaEdit.Name = "textBoxDescricaoTarifaEdit";
            textBoxDescricaoTarifaEdit.Size = new Size(191, 22);
            textBoxDescricaoTarifaEdit.TabIndex = 106;
            // 
            // textBoxIDTarifaEdit
            // 
            textBoxIDTarifaEdit.BackColor = Color.White;
            textBoxIDTarifaEdit.Enabled = false;
            textBoxIDTarifaEdit.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxIDTarifaEdit.ForeColor = Color.White;
            textBoxIDTarifaEdit.Location = new Point(40, 91);
            textBoxIDTarifaEdit.Name = "textBoxIDTarifaEdit";
            textBoxIDTarifaEdit.Size = new Size(67, 22);
            textBoxIDTarifaEdit.TabIndex = 103;
            // 
            // textBoxNomeTarifaEdit
            // 
            textBoxNomeTarifaEdit.BackColor = Color.FromArgb(26, 26, 26);
            textBoxNomeTarifaEdit.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomeTarifaEdit.ForeColor = Color.White;
            textBoxNomeTarifaEdit.Location = new Point(145, 91);
            textBoxNomeTarifaEdit.Name = "textBoxNomeTarifaEdit";
            textBoxNomeTarifaEdit.Size = new Size(67, 22);
            textBoxNomeTarifaEdit.TabIndex = 104;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 168);
            label3.Name = "label3";
            label3.Size = new Size(43, 18);
            label3.TabIndex = 101;
            label3.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(252, 70);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 102;
            label2.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(145, 168);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 98;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 70);
            label5.Name = "label5";
            label5.Size = new Size(22, 18);
            label5.TabIndex = 99;
            label5.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(145, 70);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 100;
            label1.Text = "Nome";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 26, 26);
            panel3.Controls.Add(btnCancelarTarifaEdit);
            panel3.Controls.Add(btnGuardarTarifasEdit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 233);
            panel3.Name = "panel3";
            panel3.Size = new Size(483, 55);
            panel3.TabIndex = 13;
            // 
            // btnCancelarTarifaEdit
            // 
            btnCancelarTarifaEdit.BackColor = Color.FromArgb(255, 128, 0);
            btnCancelarTarifaEdit.Cursor = Cursors.Hand;
            btnCancelarTarifaEdit.FlatStyle = FlatStyle.Flat;
            btnCancelarTarifaEdit.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarTarifaEdit.Location = new Point(342, 14);
            btnCancelarTarifaEdit.Name = "btnCancelarTarifaEdit";
            btnCancelarTarifaEdit.Size = new Size(101, 29);
            btnCancelarTarifaEdit.TabIndex = 0;
            btnCancelarTarifaEdit.Text = "Cancelar";
            btnCancelarTarifaEdit.UseVisualStyleBackColor = false;
            btnCancelarTarifaEdit.Click += btnCancelarTarifaEdit_Click;
            // 
            // btnGuardarTarifasEdit
            // 
            btnGuardarTarifasEdit.BackColor = Color.FromArgb(118, 201, 79);
            btnGuardarTarifasEdit.Cursor = Cursors.Hand;
            btnGuardarTarifasEdit.FlatStyle = FlatStyle.Flat;
            btnGuardarTarifasEdit.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarTarifasEdit.Location = new Point(203, 14);
            btnGuardarTarifasEdit.Name = "btnGuardarTarifasEdit";
            btnGuardarTarifasEdit.Size = new Size(101, 29);
            btnGuardarTarifasEdit.TabIndex = 0;
            btnGuardarTarifasEdit.Text = "Guardar";
            btnGuardarTarifasEdit.UseVisualStyleBackColor = false;
            btnGuardarTarifasEdit.Click += btnGuardarTarifasEdit_Click_1;
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
            panel2.Size = new Size(483, 55);
            panel2.TabIndex = 12;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Black;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.close;
            button2.Location = new Point(420, 12);
            button2.Name = "button2";
            button2.Size = new Size(23, 28);
            button2.TabIndex = 3;
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
            button1.Location = new Point(1001, 15);
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
            // FormTarifaMensalEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 288);
            Controls.Add(panel1);
            Name = "FormTarifaMensalEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTarifaMensalEditar";
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
        private Button btnCancelarTarifaEdit;
        private Button btnGuardarTarifasEdit;
        private Panel panel2;
        private Button button1;
        private Label lblTituloEdit;
        private ComboBox comboBoxStatusTarifaEdit;
        private TextBox textBoxValorTarifaEdit;
        private TextBox textBoxDescricaoTarifaEdit;
        private TextBox textBoxIDTarifaEdit;
        private TextBox textBoxNomeTarifaEdit;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label1;
        private Button button2;
    }
}