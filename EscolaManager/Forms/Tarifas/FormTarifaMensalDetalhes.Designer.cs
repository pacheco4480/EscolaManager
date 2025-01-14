namespace EscolaManager.Forms
{
    partial class FormTarifaMensalDetalhes
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
            comboBoxStatusTarifa = new ComboBox();
            textBoxValorTarifa = new TextBox();
            textBoxDescricaoTarifa = new TextBox();
            textBoxIDTarifa = new TextBox();
            textBoxNomeTarifa = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnCancelarTarifa = new Button();
            btnGuardarTarifas = new Button();
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
            panel1.Controls.Add(comboBoxStatusTarifa);
            panel1.Controls.Add(textBoxValorTarifa);
            panel1.Controls.Add(textBoxDescricaoTarifa);
            panel1.Controls.Add(textBoxIDTarifa);
            panel1.Controls.Add(textBoxNomeTarifa);
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
            // comboBoxStatusTarifa
            // 
            comboBoxStatusTarifa.BackColor = Color.FromArgb(26, 26, 26);
            comboBoxStatusTarifa.Font = new Font("Lato", 9F);
            comboBoxStatusTarifa.ForeColor = Color.White;
            comboBoxStatusTarifa.FormattingEnabled = true;
            comboBoxStatusTarifa.Location = new Point(144, 190);
            comboBoxStatusTarifa.Name = "comboBoxStatusTarifa";
            comboBoxStatusTarifa.Size = new Size(103, 23);
            comboBoxStatusTarifa.TabIndex = 95;
            // 
            // textBoxValorTarifa
            // 
            textBoxValorTarifa.BackColor = Color.FromArgb(26, 26, 26);
            textBoxValorTarifa.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxValorTarifa.ForeColor = Color.White;
            textBoxValorTarifa.Location = new Point(39, 190);
            textBoxValorTarifa.Name = "textBoxValorTarifa";
            textBoxValorTarifa.Size = new Size(67, 22);
            textBoxValorTarifa.TabIndex = 94;
            // 
            // textBoxDescricaoTarifa
            // 
            textBoxDescricaoTarifa.BackColor = Color.FromArgb(26, 26, 26);
            textBoxDescricaoTarifa.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescricaoTarifa.ForeColor = Color.White;
            textBoxDescricaoTarifa.Location = new Point(251, 93);
            textBoxDescricaoTarifa.Name = "textBoxDescricaoTarifa";
            textBoxDescricaoTarifa.Size = new Size(192, 22);
            textBoxDescricaoTarifa.TabIndex = 94;
            // 
            // textBoxIDTarifa
            // 
            textBoxIDTarifa.BackColor = Color.White;
            textBoxIDTarifa.Enabled = false;
            textBoxIDTarifa.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxIDTarifa.ForeColor = Color.White;
            textBoxIDTarifa.Location = new Point(39, 92);
            textBoxIDTarifa.Name = "textBoxIDTarifa";
            textBoxIDTarifa.Size = new Size(67, 22);
            textBoxIDTarifa.TabIndex = 93;
            // 
            // textBoxNomeTarifa
            // 
            textBoxNomeTarifa.BackColor = Color.FromArgb(26, 26, 26);
            textBoxNomeTarifa.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomeTarifa.ForeColor = Color.White;
            textBoxNomeTarifa.Location = new Point(144, 92);
            textBoxNomeTarifa.Name = "textBoxNomeTarifa";
            textBoxNomeTarifa.Size = new Size(67, 22);
            textBoxNomeTarifa.TabIndex = 93;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 169);
            label3.Name = "label3";
            label3.Size = new Size(43, 18);
            label3.TabIndex = 91;
            label3.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(251, 71);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 92;
            label2.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(144, 169);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 90;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(39, 71);
            label5.Name = "label5";
            label5.Size = new Size(22, 18);
            label5.TabIndex = 90;
            label5.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(144, 71);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 90;
            label1.Text = "Nome";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 26, 26);
            panel3.Controls.Add(btnCancelarTarifa);
            panel3.Controls.Add(btnGuardarTarifas);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 233);
            panel3.Name = "panel3";
            panel3.Size = new Size(483, 55);
            panel3.TabIndex = 11;
            // 
            // btnCancelarTarifa
            // 
            btnCancelarTarifa.BackColor = Color.FromArgb(255, 128, 0);
            btnCancelarTarifa.Cursor = Cursors.Hand;
            btnCancelarTarifa.FlatStyle = FlatStyle.Flat;
            btnCancelarTarifa.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarTarifa.Location = new Point(342, 14);
            btnCancelarTarifa.Name = "btnCancelarTarifa";
            btnCancelarTarifa.Size = new Size(101, 29);
            btnCancelarTarifa.TabIndex = 0;
            btnCancelarTarifa.Text = "Cancelar";
            btnCancelarTarifa.UseVisualStyleBackColor = false;
            btnCancelarTarifa.Click += btnCancelarTarifa_Click;
            // 
            // btnGuardarTarifas
            // 
            btnGuardarTarifas.BackColor = Color.FromArgb(118, 201, 79);
            btnGuardarTarifas.Cursor = Cursors.Hand;
            btnGuardarTarifas.FlatStyle = FlatStyle.Flat;
            btnGuardarTarifas.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarTarifas.Location = new Point(203, 14);
            btnGuardarTarifas.Name = "btnGuardarTarifas";
            btnGuardarTarifas.Size = new Size(101, 29);
            btnGuardarTarifas.TabIndex = 0;
            btnGuardarTarifas.Text = "Guardar";
            btnGuardarTarifas.UseVisualStyleBackColor = false;
            btnGuardarTarifas.Click += btnGuardarTarifas_Click;
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
            panel2.Size = new Size(483, 55);
            panel2.TabIndex = 10;
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
            button1.Location = new Point(718, 15);
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
            // FormTarifaMensalDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 288);
            Controls.Add(panel1);
            Name = "FormTarifaMensalDetalhes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTarifaMensalDetalhes";
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
        private Button btnCancelarTarifa;
        private Button btnGuardarTarifas;
        private Panel panel2;
        private Button button1;
        private Label lblTitulo;
        private ComboBox comboBoxStatusTarifa;
        private TextBox textBoxDescricaoTarifa;
        private TextBox textBoxNomeTarifa;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxValorTarifa;
        private Label label4;
        private TextBox textBoxIDTarifa;
        private Label label5;
        private Button button2;
    }
}