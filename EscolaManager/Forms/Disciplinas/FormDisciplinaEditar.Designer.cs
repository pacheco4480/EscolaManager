namespace EscolaManager.Forms
{
    partial class FormDisciplinaEditar
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
            textNomeDisciplinaEdit = new TextBox();
            textCreditosDisciplinaEdit = new TextBox();
            textIDDisciplinaEdit = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnCancelarDisciplinaEdit = new Button();
            btnGuardarDisciplinaEdit = new Button();
            panel2 = new Panel();
            button2 = new Button();
            lblTituloEdit = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(textNomeDisciplinaEdit);
            panel1.Controls.Add(textCreditosDisciplinaEdit);
            panel1.Controls.Add(textIDDisciplinaEdit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 198);
            panel1.TabIndex = 0;
            // 
            // textNomeDisciplinaEdit
            // 
            textNomeDisciplinaEdit.BackColor = Color.FromArgb(26, 26, 26);
            textNomeDisciplinaEdit.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNomeDisciplinaEdit.ForeColor = Color.White;
            textNomeDisciplinaEdit.Location = new Point(172, 96);
            textNomeDisciplinaEdit.Name = "textNomeDisciplinaEdit";
            textNomeDisciplinaEdit.Size = new Size(128, 22);
            textNomeDisciplinaEdit.TabIndex = 103;
            // 
            // textCreditosDisciplinaEdit
            // 
            textCreditosDisciplinaEdit.BackColor = Color.FromArgb(26, 26, 26);
            textCreditosDisciplinaEdit.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCreditosDisciplinaEdit.ForeColor = Color.White;
            textCreditosDisciplinaEdit.Location = new Point(339, 96);
            textCreditosDisciplinaEdit.Name = "textCreditosDisciplinaEdit";
            textCreditosDisciplinaEdit.Size = new Size(67, 22);
            textCreditosDisciplinaEdit.TabIndex = 101;
            // 
            // textIDDisciplinaEdit
            // 
            textIDDisciplinaEdit.BackColor = Color.White;
            textIDDisciplinaEdit.Enabled = false;
            textIDDisciplinaEdit.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textIDDisciplinaEdit.ForeColor = Color.White;
            textIDDisciplinaEdit.Location = new Point(41, 95);
            textIDDisciplinaEdit.Name = "textIDDisciplinaEdit";
            textIDDisciplinaEdit.Size = new Size(67, 22);
            textIDDisciplinaEdit.TabIndex = 102;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(339, 74);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 99;
            label3.Text = "Créditos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(172, 74);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 100;
            label2.Text = "Disciplina Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 74);
            label1.Name = "label1";
            label1.Size = new Size(22, 18);
            label1.TabIndex = 98;
            label1.Text = "ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 26, 26);
            panel3.Controls.Add(btnCancelarDisciplinaEdit);
            panel3.Controls.Add(btnGuardarDisciplinaEdit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(446, 55);
            panel3.TabIndex = 13;
            // 
            // btnCancelarDisciplinaEdit
            // 
            btnCancelarDisciplinaEdit.BackColor = Color.FromArgb(255, 128, 0);
            btnCancelarDisciplinaEdit.Cursor = Cursors.Hand;
            btnCancelarDisciplinaEdit.FlatStyle = FlatStyle.Flat;
            btnCancelarDisciplinaEdit.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarDisciplinaEdit.Location = new Point(302, 14);
            btnCancelarDisciplinaEdit.Name = "btnCancelarDisciplinaEdit";
            btnCancelarDisciplinaEdit.Size = new Size(101, 29);
            btnCancelarDisciplinaEdit.TabIndex = 104;
            btnCancelarDisciplinaEdit.Text = "Cancelar";
            btnCancelarDisciplinaEdit.UseVisualStyleBackColor = false;
            btnCancelarDisciplinaEdit.Click += btnCancelarDisciplinaEdit_Click;
            // 
            // btnGuardarDisciplinaEdit
            // 
            btnGuardarDisciplinaEdit.BackColor = Color.FromArgb(118, 201, 79);
            btnGuardarDisciplinaEdit.Cursor = Cursors.Hand;
            btnGuardarDisciplinaEdit.FlatStyle = FlatStyle.Flat;
            btnGuardarDisciplinaEdit.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarDisciplinaEdit.Location = new Point(163, 14);
            btnGuardarDisciplinaEdit.Name = "btnGuardarDisciplinaEdit";
            btnGuardarDisciplinaEdit.Size = new Size(101, 29);
            btnGuardarDisciplinaEdit.TabIndex = 0;
            btnGuardarDisciplinaEdit.Text = "Guardar";
            btnGuardarDisciplinaEdit.UseVisualStyleBackColor = false;
            btnGuardarDisciplinaEdit.Click += btnGuardarDisciplinaEdit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 26);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(lblTituloEdit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 55);
            panel2.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.close;
            button2.Location = new Point(383, 16);
            button2.Name = "button2";
            button2.Size = new Size(23, 28);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // FormDisciplinaEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 198);
            Controls.Add(panel1);
            Name = "FormDisciplinaEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDisciplinaEditar";
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
        private Button btnGuardarDisciplinaEdit;
        private Panel panel2;
        private Button button1;
        private Label lblTituloEdit;
        private TextBox textNomeDisciplinaEdit;
        private TextBox textCreditosDisciplinaEdit;
        private TextBox textIDDisciplinaEdit;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblTitulo;
        private Button button2;
        private Button btnCancelarDisciplinaEdit;
    }
}