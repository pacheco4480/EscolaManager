namespace EscolaManager.Forms
{
    partial class FormDisciplinaDetalhes
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
            textNomeDisciplina = new TextBox();
            textCreditosDisciplina = new TextBox();
            textIDDisciplina = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnCancelarDisciplina = new Button();
            btnGuardarDisciplina = new Button();
            panel2 = new Panel();
            button2 = new Button();
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
            panel1.Controls.Add(textNomeDisciplina);
            panel1.Controls.Add(textCreditosDisciplina);
            panel1.Controls.Add(textIDDisciplina);
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
            // textNomeDisciplina
            // 
            textNomeDisciplina.BackColor = Color.FromArgb(26, 26, 26);
            textNomeDisciplina.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNomeDisciplina.ForeColor = Color.White;
            textNomeDisciplina.Location = new Point(171, 96);
            textNomeDisciplina.Name = "textNomeDisciplina";
            textNomeDisciplina.Size = new Size(128, 22);
            textNomeDisciplina.TabIndex = 94;
            // 
            // textCreditosDisciplina
            // 
            textCreditosDisciplina.BackColor = Color.FromArgb(26, 26, 26);
            textCreditosDisciplina.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCreditosDisciplina.ForeColor = Color.White;
            textCreditosDisciplina.Location = new Point(338, 96);
            textCreditosDisciplina.Name = "textCreditosDisciplina";
            textCreditosDisciplina.Size = new Size(67, 22);
            textCreditosDisciplina.TabIndex = 93;
            // 
            // textIDDisciplina
            // 
            textIDDisciplina.BackColor = Color.White;
            textIDDisciplina.Enabled = false;
            textIDDisciplina.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textIDDisciplina.ForeColor = Color.White;
            textIDDisciplina.Location = new Point(40, 95);
            textIDDisciplina.Name = "textIDDisciplina";
            textIDDisciplina.Size = new Size(67, 22);
            textIDDisciplina.TabIndex = 93;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(338, 74);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 91;
            label3.Text = "Créditos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(171, 74);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 92;
            label2.Text = "Disciplina Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 74);
            label1.Name = "label1";
            label1.Size = new Size(22, 18);
            label1.TabIndex = 90;
            label1.Text = "ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 26, 26);
            panel3.Controls.Add(btnCancelarDisciplina);
            panel3.Controls.Add(btnGuardarDisciplina);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(446, 55);
            panel3.TabIndex = 11;
            // 
            // btnCancelarDisciplina
            // 
            btnCancelarDisciplina.BackColor = Color.FromArgb(255, 128, 0);
            btnCancelarDisciplina.Cursor = Cursors.Hand;
            btnCancelarDisciplina.FlatStyle = FlatStyle.Flat;
            btnCancelarDisciplina.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarDisciplina.Location = new Point(305, 14);
            btnCancelarDisciplina.Name = "btnCancelarDisciplina";
            btnCancelarDisciplina.Size = new Size(101, 29);
            btnCancelarDisciplina.TabIndex = 95;
            btnCancelarDisciplina.Text = "Cancelar";
            btnCancelarDisciplina.UseVisualStyleBackColor = false;
            btnCancelarDisciplina.Click += btnCancelarDisciplina_Click;
            // 
            // btnGuardarDisciplina
            // 
            btnGuardarDisciplina.BackColor = Color.FromArgb(118, 201, 79);
            btnGuardarDisciplina.Cursor = Cursors.Hand;
            btnGuardarDisciplina.FlatStyle = FlatStyle.Flat;
            btnGuardarDisciplina.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarDisciplina.Location = new Point(166, 14);
            btnGuardarDisciplina.Name = "btnGuardarDisciplina";
            btnGuardarDisciplina.Size = new Size(101, 29);
            btnGuardarDisciplina.TabIndex = 0;
            btnGuardarDisciplina.Text = "Guardar";
            btnGuardarDisciplina.UseVisualStyleBackColor = false;
            btnGuardarDisciplina.Click += btnGuardarDisciplina_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 26);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 55);
            panel2.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.close;
            button2.Location = new Point(382, 16);
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
            button1.Location = new Point(681, 15);
            button1.Name = "button1";
            button1.Size = new Size(23, 28);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
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
            // FormDisciplinaDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 198);
            Controls.Add(panel1);
            Name = "FormDisciplinaDetalhes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDisciplinaDetalhes";
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
        private Button btnGuardarDisciplina;
        private Panel panel2;
        private Button button1;
        private Label lblTitulo;
        private TextBox textNomeDisciplina;
        private TextBox textCreditosDisciplina;
        private TextBox textIDDisciplina;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button btnCancelarDisciplina;
    }
}