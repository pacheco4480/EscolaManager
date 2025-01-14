using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormFaltaDetalhes : Form
    {
        public Faltas NovaFalta { get; private set; }
        private List<Alunos> Alunos;
        private List<Disciplina> Disciplinas;
        private List<Faltas> Faltas;

        public FormFaltaDetalhes(List<Alunos> alunos, List<Disciplina> disciplinas, List<Faltas> faltas)
        {
            InitializeComponent();
            Alunos = alunos;
            Disciplinas = disciplinas;
            Faltas = faltas;

            CarregarDados();

            comboBoxAlunos.DataSource = Alunos;
            comboBoxAlunos.DisplayMember = "NomeCompleto";
            comboBoxAlunos.ValueMember = "ID";
            comboBoxAlunos.SelectedIndexChanged += ComboBoxAlunos_SelectedIndexChanged;

            comboBoxDisciplinas.DisplayMember = "Nome";
            comboBoxDisciplinas.ValueMember = "ID";
            comboBoxDisciplinas.Enabled = false;

            lblTitulo.Text = "Faltas Detalhes";
        }

        private void CarregarDados()
        {
            int proximoIDFalta = Faltas.Count > 0 ? Faltas.Max(f => f.ID) + 1 : 1;
            textIDFalta.Text = proximoIDFalta.ToString();
        }

        private void ComboBoxAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAlunos.SelectedItem is Alunos alunoSelecionado)
            {
                comboBoxDisciplinas.DataSource = alunoSelecionado.DisciplinasInscritas;
                comboBoxDisciplinas.Enabled = true;
            }
        }

        private void btnGuardarFalta_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                NovaFalta = new Faltas
                {
                    ID = int.Parse(textIDFalta.Text),
                    AlunoID = (int)comboBoxAlunos.SelectedValue,
                    DisciplinaID = (int)comboBoxDisciplinas.SelectedValue,
                    DataFalta = dateTimePickerDataHora.Value,
                    Motivo = textMotivo.Text
                };

                DialogResult = DialogResult.OK;
                Close();
            }

            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaForm()
        {
            if (comboBoxAlunos.SelectedValue == null || comboBoxDisciplinas.SelectedValue == null)
            {
                MessageBox.Show("Selecione um aluno e uma disciplina.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textMotivo.Text))
            {
                MessageBox.Show("Insira o motivo da falta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCancelarFalta_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
