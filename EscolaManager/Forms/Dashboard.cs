using Biblioteca;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class Dashboard : Form
    {
        public string Titulo { get; set; } = "Dashboard";

        public Dashboard()
        {
            InitializeComponent();
            AtualizarLabels();
        }

        private void AtualizarLabels()
        {
            var alunos = GestorArquivos.CarregarDados<List<Alunos>>("alunos.json") ?? new List<Alunos>();
            var tarifas = GestorArquivos.CarregarDados<List<TarifasMensais>>("tarifasMensais.json") ?? new List<TarifasMensais>();
            var professores = GestorArquivos.CarregarDados<List<Professores>>("professores.json") ?? new List<Professores>();
            var disciplinas = GestorArquivos.CarregarDados<List<Disciplina>>("disciplinas.json") ?? new List<Disciplina>();

            lblDashTotalAlunos.Text = FormAlunos.CalcularTotalAlunosAtivos(alunos).ToString();
            lblGeneroFeminino.Text = FormAlunos.CalcularTotalAlunosFemininos(alunos).ToString();
            lblGeneroMasculino.Text = FormAlunos.CalcularTotalAlunosMasculinos(alunos).ToString();
            lblTotalGanhos.Text = FormAlunos.CalcularTotalGanhos(alunos, tarifas).ToString("C"); // "C" format for currency
            lblTotalGraduados.Text = FormAlunos.CalcularTotalGraduados(alunos).ToString();
            lblDashTotalStaff.Text = FormProfessores.CalcularTotalProfessoresAtivos(professores).ToString();
            lblGeneroPFeminino.Text = FormProfessores.CalcularTotalProfessoresFemininos(professores).ToString();
            lblGeneroPMasculino.Text = FormProfessores.CalcularTotalProfessoresMasculinos(professores).ToString();
            lblDashTotalDisci.Text = FormDisciplinas.CalcularTotalDisciplinas(disciplinas).ToString();
        }

        private void btnDashboardAlunos_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Alunos no painel principal do Form1
            if (this.ParentForm is Form1 form1)
            {
                form1.AbrirFormularioAlunos();
            }
        }

        private void btnDashboardStaff_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Professores no painel principal do Form1
            if (this.ParentForm is Form1 form1)
            {
                form1.AbrirFormularioProfessores();
            }
        }

        private void btnDashboardPais_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Pais no painel principal do Form1
            if (this.ParentForm is Form1 form1)
            {
                form1.AbrirFormularioPais();
            }
        }

        private void btnDashboardAulas_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Disciplinas no painel principal do Form1
            if (this.ParentForm is Form1 form1)
            {
                form1.AbrirFormularioDisciplinas();
            }
        }

        private void btnDashboardDefenicoes_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de Disciplinas no painel principal do Form1
            if (this.ParentForm is Form1 form1)
            {
                form1.AbrirFormularioInformacoesEscola();
            }
        }

        private void btnDashboardSobre_Click(object sender, EventArgs e)
        {
            using (var formSobre = new FormSobre())
            {
                formSobre.ShowDialog();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
