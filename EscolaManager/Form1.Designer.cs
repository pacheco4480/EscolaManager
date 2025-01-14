namespace EscolaManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            panelPrincipal = new Panel();
            panel19 = new Panel();
            lblTitulo = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel18 = new Panel();
            lblNomeEscola = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnDashboard = new Button();
            menuContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            btnStaff = new Button();
            panel4 = new Panel();
            btnProfessores = new Button();
            panel6 = new Panel();
            btnSalarios = new Button();
            menuContainer2 = new FlowLayoutPanel();
            panel13 = new Panel();
            btnMenuAlunos = new Button();
            panel14 = new Panel();
            btnAlunos = new Button();
            panel17 = new Panel();
            btnFaltas = new Button();
            panel5 = new Panel();
            btnPais = new Button();
            menuContainer3 = new FlowLayoutPanel();
            panel7 = new Panel();
            btnMenuTurmas = new Button();
            panel8 = new Panel();
            btnTurmas = new Button();
            panel9 = new Panel();
            btnDisciplina = new Button();
            panel16 = new Panel();
            btnTarifas = new Button();
            menuContainer4 = new FlowLayoutPanel();
            panel10 = new Panel();
            btnDefinicoes = new Button();
            panel12 = new Panel();
            btnInfoEscola = new Button();
            panel11 = new Panel();
            btnGeral = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            menuTransition2 = new System.Windows.Forms.Timer(components);
            menuTransition3 = new System.Windows.Forms.Timer(components);
            menuTransition4 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel19.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            menuContainer2.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel17.SuspendLayout();
            panel5.SuspendLayout();
            menuContainer3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel16.SuspendLayout();
            menuContainer4.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(panelPrincipal);
            panel2.Controls.Add(panel19);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1209, 681);
            panel2.TabIndex = 1;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(227, 50);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(982, 631);
            panelPrincipal.TabIndex = 4;
            // 
            // panel19
            // 
            panel19.Controls.Add(lblTitulo);
            panel19.Dock = DockStyle.Top;
            panel19.Location = new Point(227, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(982, 50);
            panel19.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Roboto", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(17, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(115, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Dashboard";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(26, 26, 26);
            flowLayoutPanel1.Controls.Add(panel18);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(menuContainer);
            flowLayoutPanel1.Controls.Add(menuContainer2);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(menuContainer3);
            flowLayoutPanel1.Controls.Add(menuContainer4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 30, 0, 0);
            flowLayoutPanel1.Size = new Size(227, 681);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.Controls.Add(lblNomeEscola);
            panel18.Controls.Add(pictureBox1);
            panel18.Dock = DockStyle.Top;
            panel18.Location = new Point(0, 30);
            panel18.Margin = new Padding(0);
            panel18.Name = "panel18";
            panel18.Size = new Size(227, 124);
            panel18.TabIndex = 1;
            // 
            // lblNomeEscola
            // 
            lblNomeEscola.Font = new Font("Lato Black", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeEscola.ForeColor = Color.White;
            lblNomeEscola.Location = new Point(12, 71);
            lblNomeEscola.Name = "lblNomeEscola";
            lblNomeEscola.Size = new Size(201, 38);
            lblNomeEscola.TabIndex = 1;
            lblNomeEscola.Text = "EscolaManager";
            lblNomeEscola.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.school_logo;
            pictureBox1.Location = new Point(81, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(3, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 45);
            panel1.TabIndex = 4;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(26, 26, 26);
            btnDashboard.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboard3;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-8, -7);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(25, 0, 0, 0);
            btnDashboard.Size = new Size(236, 63);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "          Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(26, 26, 26);
            menuContainer.Controls.Add(panel3);
            menuContainer.Controls.Add(panel4);
            menuContainer.Controls.Add(panel6);
            menuContainer.Location = new Point(0, 205);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(224, 45);
            menuContainer.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnStaff);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 45);
            panel3.TabIndex = 4;
            // 
            // btnStaff
            // 
            btnStaff.BackColor = Color.FromArgb(26, 26, 26);
            btnStaff.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaff.ForeColor = Color.White;
            btnStaff.Image = Properties.Resources.staff;
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(-8, -7);
            btnStaff.Name = "btnStaff";
            btnStaff.Padding = new Padding(25, 0, 0, 0);
            btnStaff.Size = new Size(236, 63);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "          Staff >";
            btnStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnStaff.UseVisualStyleBackColor = false;
            btnStaff.Click += btnStaff_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnProfessores);
            panel4.Location = new Point(0, 45);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 45);
            panel4.TabIndex = 4;
            // 
            // btnProfessores
            // 
            btnProfessores.BackColor = Color.FromArgb(26, 26, 26);
            btnProfessores.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfessores.ForeColor = Color.White;
            btnProfessores.Image = Properties.Resources.teacher;
            btnProfessores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfessores.Location = new Point(-8, -7);
            btnProfessores.Name = "btnProfessores";
            btnProfessores.Padding = new Padding(25, 0, 0, 0);
            btnProfessores.Size = new Size(236, 63);
            btnProfessores.TabIndex = 3;
            btnProfessores.Text = "          Professores";
            btnProfessores.TextAlign = ContentAlignment.MiddleLeft;
            btnProfessores.UseVisualStyleBackColor = false;
            btnProfessores.Click += btnProfessores_Click_1;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSalarios);
            panel6.Location = new Point(0, 90);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(224, 45);
            panel6.TabIndex = 4;
            // 
            // btnSalarios
            // 
            btnSalarios.BackColor = Color.FromArgb(26, 26, 26);
            btnSalarios.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalarios.ForeColor = Color.White;
            btnSalarios.Image = Properties.Resources.salary;
            btnSalarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalarios.Location = new Point(-8, -7);
            btnSalarios.Name = "btnSalarios";
            btnSalarios.Padding = new Padding(25, 0, 0, 0);
            btnSalarios.Size = new Size(236, 63);
            btnSalarios.TabIndex = 3;
            btnSalarios.Text = "          Salários";
            btnSalarios.TextAlign = ContentAlignment.MiddleLeft;
            btnSalarios.UseVisualStyleBackColor = false;
            btnSalarios.Click += btnSalarios_Click;
            // 
            // menuContainer2
            // 
            menuContainer2.BackColor = Color.FromArgb(26, 26, 26);
            menuContainer2.Controls.Add(panel13);
            menuContainer2.Controls.Add(panel14);
            menuContainer2.Controls.Add(panel17);
            menuContainer2.Location = new Point(0, 250);
            menuContainer2.Margin = new Padding(0);
            menuContainer2.Name = "menuContainer2";
            menuContainer2.Size = new Size(224, 45);
            menuContainer2.TabIndex = 5;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnMenuAlunos);
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(224, 45);
            panel13.TabIndex = 4;
            // 
            // btnMenuAlunos
            // 
            btnMenuAlunos.BackColor = Color.FromArgb(26, 26, 26);
            btnMenuAlunos.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuAlunos.ForeColor = Color.White;
            btnMenuAlunos.Image = Properties.Resources.student;
            btnMenuAlunos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuAlunos.Location = new Point(-8, -7);
            btnMenuAlunos.Name = "btnMenuAlunos";
            btnMenuAlunos.Padding = new Padding(25, 0, 0, 0);
            btnMenuAlunos.Size = new Size(236, 63);
            btnMenuAlunos.TabIndex = 3;
            btnMenuAlunos.Text = "          Alunos >";
            btnMenuAlunos.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuAlunos.UseVisualStyleBackColor = false;
            btnMenuAlunos.Click += btnMenuAlunos_Click;
            // 
            // panel14
            // 
            panel14.Controls.Add(btnAlunos);
            panel14.Location = new Point(0, 45);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(224, 45);
            panel14.TabIndex = 4;
            // 
            // btnAlunos
            // 
            btnAlunos.BackColor = Color.FromArgb(26, 26, 26);
            btnAlunos.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlunos.ForeColor = Color.White;
            btnAlunos.Image = Properties.Resources.student;
            btnAlunos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlunos.Location = new Point(-8, -7);
            btnAlunos.Name = "btnAlunos";
            btnAlunos.Padding = new Padding(25, 0, 0, 0);
            btnAlunos.Size = new Size(236, 63);
            btnAlunos.TabIndex = 3;
            btnAlunos.Text = "          Alunos";
            btnAlunos.TextAlign = ContentAlignment.MiddleLeft;
            btnAlunos.UseVisualStyleBackColor = false;
            btnAlunos.Click += btnAlunos_Click;
            // 
            // panel17
            // 
            panel17.Controls.Add(btnFaltas);
            panel17.Location = new Point(0, 90);
            panel17.Margin = new Padding(0);
            panel17.Name = "panel17";
            panel17.Size = new Size(224, 45);
            panel17.TabIndex = 4;
            // 
            // btnFaltas
            // 
            btnFaltas.BackColor = Color.FromArgb(26, 26, 26);
            btnFaltas.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFaltas.ForeColor = Color.White;
            btnFaltas.Image = Properties.Resources.attendance;
            btnFaltas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFaltas.Location = new Point(-8, -7);
            btnFaltas.Name = "btnFaltas";
            btnFaltas.Padding = new Padding(25, 0, 0, 0);
            btnFaltas.Size = new Size(236, 63);
            btnFaltas.TabIndex = 3;
            btnFaltas.Text = "          Faltas";
            btnFaltas.TextAlign = ContentAlignment.MiddleLeft;
            btnFaltas.UseVisualStyleBackColor = false;
            btnFaltas.Click += btnFaltas_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnPais);
            panel5.Location = new Point(3, 298);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 45);
            panel5.TabIndex = 4;
            // 
            // btnPais
            // 
            btnPais.BackColor = Color.FromArgb(26, 26, 26);
            btnPais.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPais.ForeColor = Color.White;
            btnPais.Image = Properties.Resources.parents;
            btnPais.ImageAlign = ContentAlignment.MiddleLeft;
            btnPais.Location = new Point(-8, -7);
            btnPais.Name = "btnPais";
            btnPais.Padding = new Padding(25, 0, 0, 0);
            btnPais.Size = new Size(236, 63);
            btnPais.TabIndex = 3;
            btnPais.Text = "          Pais";
            btnPais.TextAlign = ContentAlignment.MiddleLeft;
            btnPais.UseVisualStyleBackColor = false;
            btnPais.Click += btnPais_Click;
            // 
            // menuContainer3
            // 
            menuContainer3.BackColor = Color.FromArgb(26, 26, 26);
            menuContainer3.Controls.Add(panel7);
            menuContainer3.Controls.Add(panel8);
            menuContainer3.Controls.Add(panel9);
            menuContainer3.Controls.Add(panel16);
            menuContainer3.Location = new Point(0, 346);
            menuContainer3.Margin = new Padding(0);
            menuContainer3.Name = "menuContainer3";
            menuContainer3.Size = new Size(224, 45);
            menuContainer3.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnMenuTurmas);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(224, 45);
            panel7.TabIndex = 4;
            // 
            // btnMenuTurmas
            // 
            btnMenuTurmas.BackColor = Color.FromArgb(26, 26, 26);
            btnMenuTurmas.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuTurmas.ForeColor = Color.White;
            btnMenuTurmas.Image = Properties.Resources.classroom;
            btnMenuTurmas.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuTurmas.Location = new Point(-8, -7);
            btnMenuTurmas.Name = "btnMenuTurmas";
            btnMenuTurmas.Padding = new Padding(25, 0, 0, 0);
            btnMenuTurmas.Size = new Size(236, 63);
            btnMenuTurmas.TabIndex = 3;
            btnMenuTurmas.Text = "          Turmas >";
            btnMenuTurmas.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuTurmas.UseVisualStyleBackColor = false;
            btnMenuTurmas.Click += btnMenuTurmas_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnTurmas);
            panel8.Location = new Point(0, 45);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(224, 45);
            panel8.TabIndex = 4;
            // 
            // btnTurmas
            // 
            btnTurmas.BackColor = Color.FromArgb(26, 26, 26);
            btnTurmas.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTurmas.ForeColor = Color.White;
            btnTurmas.Image = Properties.Resources.classroom;
            btnTurmas.ImageAlign = ContentAlignment.MiddleLeft;
            btnTurmas.Location = new Point(-8, -7);
            btnTurmas.Name = "btnTurmas";
            btnTurmas.Padding = new Padding(25, 0, 0, 0);
            btnTurmas.Size = new Size(236, 63);
            btnTurmas.TabIndex = 3;
            btnTurmas.Text = "          Turmas";
            btnTurmas.TextAlign = ContentAlignment.MiddleLeft;
            btnTurmas.UseVisualStyleBackColor = false;
            btnTurmas.Click += btnTurmas_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnDisciplina);
            panel9.Location = new Point(0, 90);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(224, 45);
            panel9.TabIndex = 4;
            // 
            // btnDisciplina
            // 
            btnDisciplina.BackColor = Color.FromArgb(26, 26, 26);
            btnDisciplina.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisciplina.ForeColor = Color.White;
            btnDisciplina.Image = Properties.Resources.courses;
            btnDisciplina.ImageAlign = ContentAlignment.MiddleLeft;
            btnDisciplina.Location = new Point(-8, -7);
            btnDisciplina.Name = "btnDisciplina";
            btnDisciplina.Padding = new Padding(25, 0, 0, 0);
            btnDisciplina.Size = new Size(236, 63);
            btnDisciplina.TabIndex = 3;
            btnDisciplina.Text = "          Disciplinas";
            btnDisciplina.TextAlign = ContentAlignment.MiddleLeft;
            btnDisciplina.UseVisualStyleBackColor = false;
            btnDisciplina.Click += btnDisciplina_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(btnTarifas);
            panel16.Location = new Point(0, 135);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.Size = new Size(224, 45);
            panel16.TabIndex = 4;
            // 
            // btnTarifas
            // 
            btnTarifas.BackColor = Color.FromArgb(26, 26, 26);
            btnTarifas.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTarifas.ForeColor = Color.White;
            btnTarifas.Image = Properties.Resources.money;
            btnTarifas.ImageAlign = ContentAlignment.MiddleLeft;
            btnTarifas.Location = new Point(-8, -7);
            btnTarifas.Name = "btnTarifas";
            btnTarifas.Padding = new Padding(25, 0, 0, 0);
            btnTarifas.Size = new Size(236, 63);
            btnTarifas.TabIndex = 3;
            btnTarifas.Text = "          Tarifas";
            btnTarifas.TextAlign = ContentAlignment.MiddleLeft;
            btnTarifas.UseVisualStyleBackColor = false;
            btnTarifas.Click += btnTarifas_Click;
            // 
            // menuContainer4
            // 
            menuContainer4.BackColor = Color.FromArgb(26, 26, 26);
            menuContainer4.Controls.Add(panel10);
            menuContainer4.Controls.Add(panel12);
            menuContainer4.Controls.Add(panel11);
            menuContainer4.Location = new Point(0, 391);
            menuContainer4.Margin = new Padding(0);
            menuContainer4.Name = "menuContainer4";
            menuContainer4.Size = new Size(224, 45);
            menuContainer4.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnDefinicoes);
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(224, 45);
            panel10.TabIndex = 4;
            // 
            // btnDefinicoes
            // 
            btnDefinicoes.BackColor = Color.FromArgb(26, 26, 26);
            btnDefinicoes.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDefinicoes.ForeColor = Color.White;
            btnDefinicoes.Image = Properties.Resources.settings;
            btnDefinicoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnDefinicoes.Location = new Point(-8, -7);
            btnDefinicoes.Name = "btnDefinicoes";
            btnDefinicoes.Padding = new Padding(25, 0, 0, 0);
            btnDefinicoes.Size = new Size(236, 63);
            btnDefinicoes.TabIndex = 3;
            btnDefinicoes.Text = "          Definições >";
            btnDefinicoes.TextAlign = ContentAlignment.MiddleLeft;
            btnDefinicoes.UseVisualStyleBackColor = false;
            btnDefinicoes.Click += btnDefinicoes_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnInfoEscola);
            panel12.Location = new Point(0, 45);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(224, 45);
            panel12.TabIndex = 4;
            // 
            // btnInfoEscola
            // 
            btnInfoEscola.BackColor = Color.FromArgb(26, 26, 26);
            btnInfoEscola.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfoEscola.ForeColor = Color.White;
            btnInfoEscola.Image = Properties.Resources.school_info;
            btnInfoEscola.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfoEscola.Location = new Point(-8, -7);
            btnInfoEscola.Name = "btnInfoEscola";
            btnInfoEscola.Padding = new Padding(25, 0, 0, 0);
            btnInfoEscola.Size = new Size(236, 63);
            btnInfoEscola.TabIndex = 3;
            btnInfoEscola.Text = "          Info Escola";
            btnInfoEscola.TextAlign = ContentAlignment.MiddleLeft;
            btnInfoEscola.UseVisualStyleBackColor = false;
            btnInfoEscola.Click += btnInfoEscola_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnGeral);
            panel11.Location = new Point(0, 90);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(224, 45);
            panel11.TabIndex = 4;
            // 
            // btnGeral
            // 
            btnGeral.BackColor = Color.FromArgb(26, 26, 26);
            btnGeral.Font = new Font("Roboto", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGeral.ForeColor = Color.White;
            btnGeral.Image = Properties.Resources.overview;
            btnGeral.ImageAlign = ContentAlignment.MiddleLeft;
            btnGeral.Location = new Point(-8, -7);
            btnGeral.Name = "btnGeral";
            btnGeral.Padding = new Padding(25, 0, 0, 0);
            btnGeral.Size = new Size(236, 63);
            btnGeral.TabIndex = 3;
            btnGeral.Text = "          Geral";
            btnGeral.TextAlign = ContentAlignment.MiddleLeft;
            btnGeral.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Tick += menuTransition_Tick;
            // 
            // menuTransition2
            // 
            menuTransition2.Tick += menuTransition2_Tick;
            // 
            // menuTransition3
            // 
            menuTransition3.Tick += menuTransition3_Tick;
            // 
            // menuTransition4
            // 
            menuTransition4.Tick += menuTransition4_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 681);
            Controls.Add(panel2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel2.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            menuContainer2.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel5.ResumeLayout(false);
            menuContainer3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel16.ResumeLayout(false);
            menuContainer4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDashboard;
        private Panel panel1;
        private Panel panel3;
        private Button btnStaff;
        private FlowLayoutPanel menuContainer;
        private Panel panel4;
        private Button btnProfessores;
        private Panel panel6;
        private Button btnSalarios;
        private Panel panel5;
        private Button btnPais;
        private System.Windows.Forms.Timer menuTransition;
        private FlowLayoutPanel menuContainer2;
        private Panel panel13;
        private Button btnMenuAlunos;
        private Panel panel14;
        private Button btnAlunos;
        private FlowLayoutPanel menuContainer4;
        private Panel panel10;
        private Button btnDefinicoes;
        private Panel panel11;
        private Button btnGeral;
        private Panel panel12;
        private Button btnInfoEscola;
        private System.Windows.Forms.Timer menuTransition2;
        private System.Windows.Forms.Timer menuTransition3;
        private System.Windows.Forms.Timer menuTransition4;
        private Panel panel17;
        private Button btnFaltas;
        private FlowLayoutPanel menuContainer3;
        private Panel panel7;
        private Button btnMenuTurmas;
        private Panel panel8;
        private Button btnTurmas;
        private Panel panel9;
        private Button btnDisciplina;
        private Panel panel16;
        private Button btnTarifas;
        private Panel panel18;
        private PictureBox pictureBox1;
        private Label lblNomeEscola;
        private Label lblTitulo;
        private Panel panel19;
        private Panel panelPrincipal;
    }
}
