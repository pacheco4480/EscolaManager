using Biblioteca;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormTurmaEditar : Form
    {
        private Turma turmaSelecionada;
        private List<Turma> Turmas;
        private List<Alunos> Alunos;

        public FormTurmaEditar(Turma turma, List<Alunos> alunos)
        {
            InitializeComponent();
            turmaSelecionada = turma;
            Alunos = alunos;

            // Carregar os dados da turma nos controles do formulário
            textIDTurmaEdit.Text = turmaSelecionada.ID.ToString();
            textNomeTurmaEdit.Text = turmaSelecionada.Nome;
            textTurmaAnoEdit.Text = turmaSelecionada.Ano;
            comboBoxPeriodoTurmaEdit.Items.AddRange(new string[] { "Diurno", "Noturno" });
            comboBoxPeriodoTurmaEdit.SelectedItem = turmaSelecionada.Periodo;
            comboBoxStatusTurmaEdit.Items.AddRange(new string[] { "Ativo", "Inativo" });
            comboBoxStatusTurmaEdit.SelectedItem = turmaSelecionada.Status;

            lblTituloEdit.Text = "Turma Editar Detalhes";
        }

        private void btnGuardarTurmaEdit_Click_1(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                // Atualizar os dados da turma selecionada com os valores dos controles
                turmaSelecionada.Nome = textNomeTurmaEdit.Text;
                turmaSelecionada.Ano = textTurmaAnoEdit.Text;
                turmaSelecionada.Periodo = comboBoxPeriodoTurmaEdit.SelectedItem.ToString();
                turmaSelecionada.Status = comboBoxStatusTurmaEdit.SelectedItem.ToString();

                // Salvar os dados atualizados
                SalvarDados();

                // Fechar o formulário
                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("Turma editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SalvarDados()
        {
            GestorArquivos.SalvarDados(Turmas, "turmas.json");
        }


        private bool ValidaForm()
        {
            if (string.IsNullOrWhiteSpace(textNomeTurmaEdit.Text))
            {
                MessageBox.Show("Nome da turma é obrigatório.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textTurmaAnoEdit.Text))
            {
                MessageBox.Show("Ano da turma é obrigatório.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxPeriodoTurmaEdit.SelectedItem == null)
            {
                MessageBox.Show("Selecione o período da turma.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxStatusTurmaEdit.SelectedItem == null)
            {
                MessageBox.Show("Selecione o status da turma.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelarTurmaEdit_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }


    }
}
