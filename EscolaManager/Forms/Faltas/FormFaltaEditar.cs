using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormFaltaEditar : Form
    {
        public Faltas FaltaSelecionada { get; private set; }
        private List<Alunos> Alunos;
        private List<Disciplina> Disciplinas;
        private List<Faltas> Faltas;

        public FormFaltaEditar(List<Alunos> alunos, List<Disciplina> disciplinas, Faltas falta)
        {
            InitializeComponent();
            Alunos = alunos;
            Disciplinas = disciplinas;
            FaltaSelecionada = falta;

            comboBoxAlunosEdit.DataSource = Alunos;
            comboBoxAlunosEdit.DisplayMember = "NomeCompleto";
            comboBoxAlunosEdit.ValueMember = "ID";
            comboBoxAlunosEdit.SelectedIndexChanged += ComboBoxAlunosEdit_SelectedIndexChanged;

            comboBoxDisciplinasEdit.DisplayMember = "Nome";
            comboBoxDisciplinasEdit.ValueMember = "ID";
            comboBoxDisciplinasEdit.Enabled = false; // Desabilitar até que um aluno seja selecionado

            textIDFaltaEdit.Text = FaltaSelecionada.ID.ToString();
            comboBoxAlunosEdit.SelectedValue = FaltaSelecionada.AlunoID;
            dateTimePickerDataHoraEdit.Value = FaltaSelecionada.DataFalta;
            textMotivoEdit.Text = FaltaSelecionada.Motivo;

            lblTituloEdit.Text = "Falta Editar Detalhes";
        }



        private void ComboBoxAlunosEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAlunosEdit.SelectedItem is Alunos alunoSelecionado)
            {
                // Carregar as disciplinas inscritas pelo aluno selecionado
                comboBoxDisciplinasEdit.DataSource = alunoSelecionado.DisciplinasInscritas;
                comboBoxDisciplinasEdit.Enabled = true; // Habilitar o ComboBox de disciplinas

                // Selecionar a disciplina da falta editada, se aplicável
                if (FaltaSelecionada != null && alunoSelecionado.DisciplinasInscritas.Any(d => d.ID == FaltaSelecionada.DisciplinaID))
                {
                    comboBoxDisciplinasEdit.SelectedValue = FaltaSelecionada.DisciplinaID;
                }
                else
                {
                    comboBoxDisciplinasEdit.SelectedIndex = -1; // Limpar a seleção
                }
            }
        }


        private void btnGuardarFaltaEdit_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                FaltaSelecionada.AlunoID = (int)comboBoxAlunosEdit.SelectedValue;
                FaltaSelecionada.DisciplinaID = (int)comboBoxDisciplinasEdit.SelectedValue;
                FaltaSelecionada.DataFalta = dateTimePickerDataHoraEdit.Value;
                FaltaSelecionada.Motivo = textMotivoEdit.Text;

                // Salvar os dados atualizados
                SalvarDados();

                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("Falta editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalvarDados()
        {
            GestorArquivos.SalvarDados(Faltas, "faltas.json");
        }

        private bool ValidaForm()
        {
            if (comboBoxAlunosEdit.SelectedValue == null || comboBoxDisciplinasEdit.SelectedValue == null)
            {
                MessageBox.Show("Selecione um aluno e uma disciplina.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textMotivoEdit.Text))
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

        private void btnCancelarFaltaEdit_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
