using Biblioteca;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormPaiEditar : Form
    {
        private Pais paiSelecionado;
        private List<Pais> Pais;

        public FormPaiEditar(Pais pai, List<Pais> pais)
        {
            InitializeComponent();
            paiSelecionado = pai;
            Pais = pais;

            // Carregar os dados do pai nos controles do formulário
            textIDPaiEdit.Text = paiSelecionado.ID.ToString();
            textNomePaiEdit.Text = paiSelecionado.Nome;
            textApelidoPaiEdit.Text = paiSelecionado.Apelido;
            comboBoxGeneroPaiEdit.Items.AddRange(new string[] { "Masculino", "Feminino" });
            comboBoxGeneroPaiEdit.SelectedItem = paiSelecionado.Genero;
            textTelemovelPaiEdit.Text = paiSelecionado.Telemovel;
            textMoradaPaiEdit.Text = paiSelecionado.Morada;
            textEmailPaiEdit.Text = paiSelecionado.Email;
            comboBoxStatusPaiEdit.Items.AddRange(new string[] { "Ativo", "Desativo" });
            comboBoxStatusPaiEdit.SelectedItem = paiSelecionado.Status;

            lblTituloEdit.Text = "Parente Editar Detalhes";
        }

        private void btnGuardarPaiEdit_Click_1(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                // Atualizar os dados do pai selecionado com os valores dos controles
                paiSelecionado.Nome = textNomePaiEdit.Text;
                paiSelecionado.Apelido = textApelidoPaiEdit.Text;
                paiSelecionado.Genero = comboBoxGeneroPaiEdit.SelectedItem.ToString();
                paiSelecionado.Telemovel = textTelemovelPaiEdit.Text;
                paiSelecionado.Morada = textMoradaPaiEdit.Text;
                paiSelecionado.Email = textEmailPaiEdit.Text;
                paiSelecionado.Status = comboBoxStatusPaiEdit.SelectedItem.ToString();

                // Salvar os dados atualizados
                SalvarDados();

                // Fechar o formulário com DialogResult.OK
                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("Parente editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalvarDados()
        {
            // Salvar lista atualizada no arquivo JSON
            GestorArquivos.SalvarDados(Pais, "pais.json");
        }

        private bool ValidaForm()
        {
            // Validação dos campos do formulário
            if (string.IsNullOrWhiteSpace(textNomePaiEdit.Text))
            {
                MessageBox.Show("Insira o nome do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textApelidoPaiEdit.Text))
            {
                MessageBox.Show("Insira o apelido do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxGeneroPaiEdit.SelectedItem == null)
            {
                MessageBox.Show("Selecione o gênero do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textTelemovelPaiEdit.Text))
            {
                MessageBox.Show("Insira o número de telefone do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(textTelemovelPaiEdit.Text))
            {
                MessageBox.Show("Insira o número de telefone do Parente válido (9xxxxxxxx)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textMoradaPaiEdit.Text))
            {
                MessageBox.Show("Insira a morada do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textEmailPaiEdit.Text))
            {
                MessageBox.Show("Insira o email do pai", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(textEmailPaiEdit.Text))
            {
                MessageBox.Show("Insira o email do Parente válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxStatusPaiEdit.SelectedItem == null)
            {
                MessageBox.Show("Selecione o status do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Validação básica para números de telemóvel em Portugal
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 9 && phoneNumber.StartsWith("9");
        }

        private void btnCancelarPaiEdit_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
