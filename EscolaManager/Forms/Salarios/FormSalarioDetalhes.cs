using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormSalarioDetalhes : Form
    {
        public Salarios NovoSalario { get; private set; }
        private List<Salarios> salarios;

        public FormSalarioDetalhes(List<Salarios> salarios)
        {
            InitializeComponent();
            this.salarios = salarios; // Atribui a lista de salários passada como parâmetro
            CarregarDados();

            lblTitulo.Text = "Salários Detalhes";
        }

        private void CarregarDados()
        {
            int proximoIDSalario = salarios.Count > 0 ? salarios.Max(a => a.ID) + 1 : 1;
            textIDSalario.Text = proximoIDSalario.ToString();
        }

        private void btnGuardarSalarios_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                NovoSalario = new Salarios
                {
                    ID = int.Parse(textIDSalario.Text),
                    Nome = textNomeSalario.Text,
                    Descricao = textDescricaoSalario.Text,
                    Valor = double.Parse(textValorSalario.Text)
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
            if (string.IsNullOrEmpty(textNomeSalario.Text))
            {
                MessageBox.Show("Insira o nome do salário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textValorSalario.Text) || !double.TryParse(textValorSalario.Text, out _))
            {
                MessageBox.Show("Insira um valor válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelarSalario_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário atual
        }
    }
}
