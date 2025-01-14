namespace EscolaManager.Forms
{
    partial class FormSobre
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
            lblDescricao = new Label();
            lblVersao = new Label();
            lblData = new Label();
            lblAutor = new Label();
            lblTitulo = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnFechar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(118, 201, 83);
            panel1.Controls.Add(lblDescricao);
            panel1.Controls.Add(lblVersao);
            panel1.Controls.Add(lblData);
            panel1.Controls.Add(lblAutor);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnFechar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 454);
            panel1.TabIndex = 0;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Lato", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(151, 172);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(39, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "label6";
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersao.Location = new Point(151, 133);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(52, 19);
            lblVersao.TabIndex = 2;
            lblVersao.Text = "label6";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(151, 94);
            lblData.Name = "lblData";
            lblData.Size = new Size(52, 19);
            lblData.TabIndex = 2;
            lblData.Text = "label6";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(151, 55);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(52, 19);
            lblAutor.TabIndex = 2;
            lblAutor.Text = "label6";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(151, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(52, 19);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 170);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(113, 23);
            label5.TabIndex = 1;
            label5.Text = "DESCRIÇÃO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 131);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(84, 23);
            label4.TabIndex = 1;
            label4.Text = "VERSÃO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 92);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(58, 23);
            label3.TabIndex = 1;
            label3.Text = "DATA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 53);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(73, 23);
            label2.TabIndex = 1;
            label2.Text = "AUTOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 14);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(75, 23);
            label1.TabIndex = 1;
            label1.Text = "TITULO";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(450, 419);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 454);
            Controls.Add(panel1);
            Name = "FormSobre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSobre";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnFechar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblDescricao;
        private Label lblVersao;
        private Label lblData;
        private Label lblAutor;
        private Label lblTitulo;
        private Label label5;
        private Label label4;
    }
}