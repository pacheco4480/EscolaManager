namespace EscolaManager.Forms
{
    partial class FormSalarioDetalhes
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
            textValorSalario = new TextBox();
            textDescricaoSalario = new TextBox();
            textNomeSalario = new TextBox();
            textIDSalario = new TextBox();
            label14 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnCancelarSalario = new Button();
            btnGuardarSalarios = new Button();
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
            panel1.Controls.Add(textValorSalario);
            panel1.Controls.Add(textDescricaoSalario);
            panel1.Controls.Add(textNomeSalario);
            panel1.Controls.Add(textIDSalario);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 286);
            panel1.TabIndex = 0;
            // 
            // textValorSalario
            // 
            textValorSalario.BackColor = Color.FromArgb(26, 26, 26);
            textValorSalario.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textValorSalario.ForeColor = Color.White;
            textValorSalario.Location = new Point(39, 188);
            textValorSalario.Name = "textValorSalario";
            textValorSalario.Size = new Size(128, 22);
            textValorSalario.TabIndex = 49;
            // 
            // textDescricaoSalario
            // 
            textDescricaoSalario.BackColor = Color.FromArgb(26, 26, 26);
            textDescricaoSalario.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDescricaoSalario.ForeColor = Color.White;
            textDescricaoSalario.Location = new Point(315, 99);
            textDescricaoSalario.Name = "textDescricaoSalario";
            textDescricaoSalario.Size = new Size(309, 22);
            textDescricaoSalario.TabIndex = 47;
            // 
            // textNomeSalario
            // 
            textNomeSalario.BackColor = Color.FromArgb(26, 26, 26);
            textNomeSalario.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNomeSalario.ForeColor = Color.White;
            textNomeSalario.Location = new Point(148, 99);
            textNomeSalario.Name = "textNomeSalario";
            textNomeSalario.Size = new Size(128, 22);
            textNomeSalario.TabIndex = 46;
            // 
            // textIDSalario
            // 
            textIDSalario.BackColor = Color.White;
            textIDSalario.Enabled = false;
            textIDSalario.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textIDSalario.ForeColor = Color.White;
            textIDSalario.Location = new Point(41, 99);
            textIDSalario.Name = "textIDSalario";
            textIDSalario.Size = new Size(67, 22);
            textIDSalario.TabIndex = 45;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(41, 168);
            label14.Name = "label14";
            label14.Size = new Size(43, 18);
            label14.TabIndex = 39;
            label14.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(315, 78);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 36;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(148, 78);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 44;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 78);
            label1.Name = "label1";
            label1.Size = new Size(22, 18);
            label1.TabIndex = 35;
            label1.Text = "ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 26, 26);
            panel3.Controls.Add(btnCancelarSalario);
            panel3.Controls.Add(btnGuardarSalarios);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 231);
            panel3.Name = "panel3";
            panel3.Size = new Size(661, 55);
            panel3.TabIndex = 5;
            // 
            // btnCancelarSalario
            // 
            btnCancelarSalario.BackColor = Color.FromArgb(255, 128, 0);
            btnCancelarSalario.Cursor = Cursors.Hand;
            btnCancelarSalario.FlatStyle = FlatStyle.Flat;
            btnCancelarSalario.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarSalario.Location = new Point(519, 14);
            btnCancelarSalario.Name = "btnCancelarSalario";
            btnCancelarSalario.Size = new Size(101, 29);
            btnCancelarSalario.TabIndex = 0;
            btnCancelarSalario.Text = "Cancelar";
            btnCancelarSalario.UseVisualStyleBackColor = false;
            btnCancelarSalario.Click += btnCancelarSalario_Click;
            // 
            // btnGuardarSalarios
            // 
            btnGuardarSalarios.BackColor = Color.FromArgb(118, 201, 79);
            btnGuardarSalarios.Cursor = Cursors.Hand;
            btnGuardarSalarios.FlatStyle = FlatStyle.Flat;
            btnGuardarSalarios.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarSalarios.Location = new Point(380, 14);
            btnGuardarSalarios.Name = "btnGuardarSalarios";
            btnGuardarSalarios.Size = new Size(101, 29);
            btnGuardarSalarios.TabIndex = 0;
            btnGuardarSalarios.Text = "Guardar";
            btnGuardarSalarios.UseVisualStyleBackColor = false;
            btnGuardarSalarios.Click += btnGuardarSalarios_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 26);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(661, 55);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.close;
            button1.Location = new Point(601, 15);
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
            // FormSalarioDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 286);
            Controls.Add(panel1);
            Name = "FormSalarioDetalhes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSalarioDetalhes";
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
        private Button btnCancelarSalario;
        private Button btnGuardarSalarios;
        private Panel panel2;
        private Button button1;
        private Label lblTitulo;
        private TextBox textValorSalario;
        private TextBox textDescricaoSalario;
        private TextBox textNomeSalario;
        private TextBox textIDSalario;
        private Label label14;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}