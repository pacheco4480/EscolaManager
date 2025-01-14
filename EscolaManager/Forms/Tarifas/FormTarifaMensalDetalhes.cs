using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormTarifaMensalDetalhes : Form
    {
        public TarifasMensais NovaTarifa { get; private set; }
        private List<TarifasMensais> tarifas;

        public FormTarifaMensalDetalhes(List<TarifasMensais> tarifas)
        {
            InitializeComponent();
            this.tarifas = tarifas; // Atribui a lista de tarifas passada como parâmetro
            CarregarDados();

            comboBoxStatusTarifa.Items.AddRange(new string[] { "Activa", "Desativa" });
            comboBoxStatusTarifa.SelectedIndex = 0;

            lblTitulo.Text = "Tarifas Mensais Detalhes";
        }

        private void CarregarDados()
        {
            int proximoIDTarifa = tarifas.Count > 0 ? tarifas.Max(t => t.ID) + 1 : 1;
            textBoxIDTarifa.Text = proximoIDTarifa.ToString();
        }

        private void btnGuardarTarifas_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                NovaTarifa = new TarifasMensais
                {
                    ID = int.Parse(textBoxIDTarifa.Text),
                    Nome = textBoxNomeTarifa.Text,
                    Descricao = textBoxDescricaoTarifa.Text,
                    Valor = Convert.ToDouble(textBoxValorTarifa.Text),
                    Status = comboBoxStatusTarifa.SelectedItem.ToString()
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
            if (string.IsNullOrWhiteSpace(textBoxNomeTarifa.Text))
            {
                MessageBox.Show("Insira o nome da tarifa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescricaoTarifa.Text))
            {
                MessageBox.Show("Insira a descrição da tarifa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxValorTarifa.Text) || !double.TryParse(textBoxValorTarifa.Text, out _))
            {
                MessageBox.Show("Insira um valor válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxStatusTarifa.SelectedItem == null)
            {
                MessageBox.Show("Selecione o status da tarifa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelarTarifa_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário atual
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); // Fecha o formulário atual
        }
    }
}
