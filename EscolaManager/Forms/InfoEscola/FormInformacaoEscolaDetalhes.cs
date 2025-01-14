using Biblioteca;
using System;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormInformacaoEscolaDetalhes : Form
    {
        private FormInformacoesEscola formInformacoesEscola;

        public InformacoesEscola NovaInformacao { get; private set; }

        public FormInformacaoEscolaDetalhes(FormInformacoesEscola formInformacoesEscola, InformacoesEscola informacoes)
        {
            InitializeComponent();
            lblTitulo.Text = "Escola Detalhes";

            this.formInformacoesEscola = formInformacoesEscola;

            // Exibir informações passadas
            ExibirInformacoes(informacoes);
        }

        private void ExibirInformacoes(InformacoesEscola informacoes)
        {
            textBoxNomeEscola.Text = informacoes.Nome;
            textMoradaEscola.Text = informacoes.Morada;
            textCAgrupamento.Text = informacoes.CodigoAgrupamento.ToString();
            textTelemovelEscola.Text = informacoes.Telemovel.ToString();
            textTelefoneEscola.Text = informacoes.Telefone.ToString();
            textSiteEscola.Text = informacoes.Website;
            textEmailEscola.Text = informacoes.Email;
        }

        private bool ValidaForm()
        {
            // Validar os campos do formulário
            if (string.IsNullOrWhiteSpace(textCAgrupamento.Text))
            {
                MessageBox.Show("O Código de Agrupamento é obrigatório", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(textCAgrupamento.Text, out _))
            {
                MessageBox.Show("O Código de Agrupamento deve ser um número válido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNomeEscola.Text))
            {
                MessageBox.Show("O Nome da Escola é obrigatório", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textMoradaEscola.Text))
            {
                MessageBox.Show("A Morada da Escola é obrigatória", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textTelemovelEscola.Text))
            {
                MessageBox.Show("Insira um número de telemóvel", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(textTelemovelEscola.Text))
            {
                MessageBox.Show("Insira um número de telemóvel válido (9xxxxxxxx)", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (string.IsNullOrWhiteSpace(textTelefoneEscola.Text))
            {
                MessageBox.Show("O Telefone da Escola é obrigatório", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(textTelefoneEscola.Text, out _))
            {
                MessageBox.Show("O Telefone da Escola deve ser um número válido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textSiteEscola.Text))
            {
                MessageBox.Show("O Site da Escola é obrigatório", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textEmailEscola.Text))
            {
                MessageBox.Show("O Email da Escola é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(textEmailEscola.Text))
            {
                MessageBox.Show("Insira um Email da Escola válido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnGuardarInfoEscola_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                NovaInformacao = new InformacoesEscola
                {
                    CodigoAgrupamento = int.Parse(textCAgrupamento.Text),
                    Nome = textBoxNomeEscola.Text,
                    Morada = textMoradaEscola.Text,
                    Telemovel = int.Parse(textTelemovelEscola.Text),
                    Telefone = int.Parse(textTelefoneEscola.Text),
                    Website = textSiteEscola.Text,
                    Email = textEmailEscola.Text
                };

                // Atualizar informações no FormInformacoesEscola
                formInformacoesEscola.AtualizarInformacoes(NovaInformacao);

                MessageBox.Show("Informações adicionadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarInfoEscola_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
