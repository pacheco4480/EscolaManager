using Biblioteca;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormSalarioEditar : Form
    {
        private List<Salarios> salarios;
        private Salarios salarioSelecionado;

        public FormSalarioEditar(List<Salarios> salarios, Salarios salario)
        {
            InitializeComponent();
            this.salarios = salarios;
            salarioSelecionado = salario;

            textIDSalarioEdit.Text = salarioSelecionado.ID.ToString();
            textNomeSalarioEdit.Text = salarioSelecionado.Nome;
            textDescricaoSalarioEdit.Text = salarioSelecionado.Descricao;
            textValorSalarioEdit.Text = salarioSelecionado.Valor.ToString();

            lblTituloEdit.Text = "Salário Editar Detalhes";
        }

        private void btnGuardarSalariosEdit_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                salarioSelecionado.Nome = textNomeSalarioEdit.Text;
                salarioSelecionado.Descricao = textDescricaoSalarioEdit.Text;
                salarioSelecionado.Valor = double.Parse(textValorSalarioEdit.Text);

                SalvarDados();
                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("Salário editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalvarDados()
        {
            GestorArquivos.SalvarDados(salarios, "salarios.json");
        }

        private bool ValidaForm()
        {
            if (string.IsNullOrEmpty(textNomeSalarioEdit.Text))
            {
                MessageBox.Show("Insira o nome do salário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textValorSalarioEdit.Text) || !double.TryParse(textValorSalarioEdit.Text, out _))
            {
                MessageBox.Show("Insira um valor válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelarSalarioEdit_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
