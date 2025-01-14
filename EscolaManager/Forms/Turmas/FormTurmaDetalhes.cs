using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormTurmaDetalhes : Form
    {
        public Turma NovaTurma { get; private set; }
        private List<Turma> turmas;
        private List<Alunos> alunos;

        public FormTurmaDetalhes(List<Turma> turmas, List<Alunos> alunos)
        {
            InitializeComponent();
            this.turmas = turmas;
            this.alunos = alunos;
            CarregarDados();

            comboBoxPeriodoTurma.Items.AddRange(new string[] { "Diurno", "Noturno" });
            comboBoxStatusTurma.Items.AddRange(new string[] { "Ativo", "Inativo" });

            lblTitulo.Text = "Turma Detalhes";
        }

        private void CarregarDados()
        {
            int proximoID = turmas.Count > 0 ? turmas.Max(t => t.ID) + 1 : 1;
            textIDTurma.Text = proximoID.ToString();
        }

        private void btnGuardarTurma_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                NovaTurma = new Turma
                {
                    ID = int.Parse(textIDTurma.Text),
                    Nome = textNomeTurma.Text,
                    Ano = textTurmaAno.Text,
                    Periodo = comboBoxPeriodoTurma.SelectedItem.ToString(),
                    Status = comboBoxStatusTurma.SelectedItem.ToString(),
                };

                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("Turma adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha corretamente todos os campos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaForm()
        {
            if (string.IsNullOrWhiteSpace(textNomeTurma.Text))
            {
                MessageBox.Show("Insira o nome da Turma", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textTurmaAno.Text))
            {
                MessageBox.Show("Insira o ano da Turma", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxPeriodoTurma.SelectedItem == null)
            {
                MessageBox.Show("Insira o periodo da Turma", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxStatusTurma.SelectedItem == null)
            {
                MessageBox.Show("Insira o estado da Turma", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelarTurma_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário atual
        }
    }
}
