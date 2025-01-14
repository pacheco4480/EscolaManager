using Biblioteca;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormDisciplinaEditar : Form
    {
        private List<Disciplina> Disciplinas;
        private Disciplina disciplinaSelecionada;

        public FormDisciplinaEditar(List<Disciplina> disciplinas, Disciplina disciplina)
        {
            InitializeComponent();
            Disciplinas = disciplinas;
            disciplinaSelecionada = disciplina;

            // Preencher campos com os dados da disciplina selecionada
            textIDDisciplinaEdit.Text = disciplinaSelecionada.ID.ToString();
            textNomeDisciplinaEdit.Text = disciplinaSelecionada.Nome;
            textCreditosDisciplinaEdit.Text = disciplinaSelecionada.Creditos.ToString();

            lblTituloEdit.Text = "Disciplina Editar Detalhes";
        }

        private void btnGuardarDisciplinaEdit_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                // Atualizar os dados da disciplina selecionada
                disciplinaSelecionada.Nome = textNomeDisciplinaEdit.Text;
                disciplinaSelecionada.Creditos = double.Parse(textCreditosDisciplinaEdit.Text);

                // Salvar dados atualizados
                SalvarDados();

                // Fechar o formulário
                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("Disciplina editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SalvarDados()
        {
            // Salvar lista atualizada no arquivo JSON
            GestorArquivos.SalvarDados(Disciplinas, "disciplinas.json");
        }

        private bool ValidaForm()
        {
            if (string.IsNullOrEmpty(textNomeDisciplinaEdit.Text))
            {
                MessageBox.Show("Insira o nome da disciplina", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textCreditosDisciplinaEdit.Text) || !double.TryParse(textCreditosDisciplinaEdit.Text, out _))
            {
                MessageBox.Show("Insira créditos válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelarDisciplinaEdit_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
