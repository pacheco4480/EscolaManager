using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormPaiDetalhes : Form
    {
        public Pais NovoPai { get; private set; }
        private List<Pais> Pais;

        public FormPaiDetalhes(List<Pais> pais)
        {
            InitializeComponent();
            Pais = pais;

            CarregarDados();

            comboBoxGeneroPai.Items.AddRange(new string[] { "Masculino", "Feminino" });
            comboBoxGeneroPai.SelectedIndex = 0;

            comboBoxStatusPai.Items.AddRange(new string[] { "Ativo", "Desativo" });
            comboBoxStatusPai.SelectedIndex = 0;

            lblTitulo.Text = "Parente Detalhes";
        }

        private void CarregarDados()
        {
            int proximoIDPai = Pais.Count > 0 ? Pais.Max(a => a.ID) + 1 : 1;
            textIDPai.Text = proximoIDPai.ToString();
        }

        private void btnGuardarPai_Click_1(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                NovoPai = new Pais
                {
                    ID = int.Parse(textIDPai.Text),
                    Nome = textNomePai.Text,
                    Apelido = textApelidoPai.Text,
                    Genero = comboBoxGeneroPai.SelectedItem.ToString(),
                    Telemovel = textTelemovelPai.Text,
                    Email = textEmailPai.Text,
                    Morada = textMoradaPai.Text,
                    Status = comboBoxStatusPai.SelectedItem.ToString(),
                };

                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("Parente adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaForm()
        {
            // Validação dos campos do formulário
            if (string.IsNullOrEmpty(textNomePai.Text))
            {
                MessageBox.Show("Insira o nome do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textApelidoPai.Text))
            {
                MessageBox.Show("Insira o apelido do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxGeneroPai.SelectedItem == null)
            {
                MessageBox.Show("Selecione o gênero do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textTelemovelPai.Text))
            {
                MessageBox.Show("Insira o telemóvel do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(textTelemovelPai.Text))
            {
                MessageBox.Show("Insira o número de telefone do Parente válido (9xxxxxxxx)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificação adicional para garantir que o telemóvel contenha apenas números
            if (!int.TryParse(textTelemovelPai.Text, out _))
            {
                MessageBox.Show("O telemóvel do Parente deve ser um número válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textMoradaPai.Text))
            {
                MessageBox.Show("Insira a morada do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxStatusPai.SelectedItem == null)
            {
                MessageBox.Show("Selecione o status do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar apenas se o campo de email está preenchido
            if (string.IsNullOrEmpty(textEmailPai.Text))
            {
                MessageBox.Show("Insira o email do Parente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(textEmailPai.Text))
            {
                MessageBox.Show("Insira o email do Parente válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancelarPai_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
