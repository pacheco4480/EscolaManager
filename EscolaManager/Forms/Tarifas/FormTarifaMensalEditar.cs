using Biblioteca;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormTarifaMensalEditar : Form
    {
        private List<TarifasMensais> tarifas;
        private TarifasMensais tarifaSelecionada;

        public FormTarifaMensalEditar(List<TarifasMensais> tarifas, TarifasMensais tarifa)
        {
            InitializeComponent();
            this.tarifas = tarifas;
            tarifaSelecionada = tarifa;

            textBoxIDTarifaEdit.Text = tarifaSelecionada.ID.ToString();
            textBoxNomeTarifaEdit.Text = tarifaSelecionada.Nome;
            textBoxDescricaoTarifaEdit.Text = tarifaSelecionada.Descricao;
            textBoxValorTarifaEdit.Text = tarifaSelecionada.Valor.ToString();
            comboBoxStatusTarifaEdit.Items.AddRange(new string[] { "Activa", "Desativa" });
            comboBoxStatusTarifaEdit.SelectedItem = tarifaSelecionada.Status;

            lblTituloEdit.Text = "Tarifa Mensal Editar Detalhes";
        }

        private void btnGuardarTarifasEdit_Click_1(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                tarifaSelecionada.Nome = textBoxNomeTarifaEdit.Text;
                tarifaSelecionada.Descricao = textBoxDescricaoTarifaEdit.Text;
                tarifaSelecionada.Valor = Convert.ToDouble(textBoxValorTarifaEdit.Text);
                tarifaSelecionada.Status = comboBoxStatusTarifaEdit.SelectedItem.ToString();

                SalvarDados();
                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("Tarifa editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalvarDados()
        {
            GestorArquivos.SalvarDados(tarifas, "tarifasMensais.json");
        }

        private bool ValidaForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeTarifaEdit.Text))
            {
                MessageBox.Show("Insira o nome da tarifa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescricaoTarifaEdit.Text))
            {
                MessageBox.Show("Insira a descrição da tarifa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxValorTarifaEdit.Text) || !double.TryParse(textBoxValorTarifaEdit.Text, out _))
            {
                MessageBox.Show("Insira um valor válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxStatusTarifaEdit.SelectedItem == null)
            {
                MessageBox.Show("Selecione o status da tarifa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelarTarifaEdit_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
