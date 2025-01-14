using Biblioteca;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormProfessorDetalhes : Form
    {
        public Professores NovoProfessor { get; private set; }
        private List<Disciplina> Disciplinas;
        private List<Professores> Professores;
        private List<Salarios> Salarios;

        public FormProfessorDetalhes(List<Disciplina> disciplinas, List<Professores> professores)
        {
            InitializeComponent();
            Disciplinas = disciplinas;
            Professores = professores;
            Salarios = GestorArquivos.CarregarDados<List<Salarios>>("salarios.json") ?? new List<Salarios>();
            CarregarDados();

            // Configurar DataSource e DisplayMember para o checkedListBoxDProfessor
            checkedListBoxDProfessor.DataSource = Disciplinas;
            checkedListBoxDProfessor.DisplayMember = "Nome";

            // Configurar combobox GeneroProfessor
            comboBoxGeneroProfessor.Items.AddRange(new string[] { "Masculino", "Feminino" });
            comboBoxGeneroProfessor.SelectedIndex = 0;

            // Configurar combobox StatusProfessor
            comboBoxStatusProfessor.Items.AddRange(new string[] { "Ativo", "Inativo" });
            comboBoxStatusProfessor.SelectedIndex = 0;

            // Configurar DataSource e DisplayMember para comboBoxSalarioProfessor
            comboBoxSalarioProfessor.DataSource = Salarios;
            comboBoxSalarioProfessor.DisplayMember = "Nome";
            comboBoxSalarioProfessor.ValueMember = "ID";

            // Configurar título do formulário
            lblTitulo.Text = "Detalhes do Professor";
        }


        private void CarregarDados()
        {
            // Determinar o próximo ID disponível para o novo professor
            int proximoIDProfessor = Professores.Count > 0 ? Professores.Max(p => p.ID) + 1 : 1;
            textIDStaff.Text = proximoIDProfessor.ToString();
        }

        private void btnGuardarProfessor_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                // Criar um novo objeto Professores com os dados preenchidos
                NovoProfessor = new Professores
                {
                    ID = int.Parse(textIDStaff.Text),
                    Nome = textNomeProfessor.Text,
                    Apelido = textApelidoProfessor.Text,
                    Genero = comboBoxGeneroProfessor.SelectedItem.ToString(),
                    DataEntrada = DateOnly.Parse(textDataEntradaProfessor.Text),
                    Telefone = textTelemovelProfessor.Text,
                    Email = textEmailProfessor.Text,
                    Morada = textMoradaProfessor.Text,
                    SalarioID = (int)comboBoxSalarioProfessor.SelectedValue,
                    DisciplinasLecionadas = ObterDisciplinasSelecionadas(),
                    Status = comboBoxStatusProfessor.SelectedItem.ToString()
                };

                DialogResult = DialogResult.OK; // Definir o resultado do diálogo como OK
                Close(); // Fechar o formulário
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Disciplina> ObterDisciplinasSelecionadas()
        {
            List<Disciplina> disciplinasSelecionadas = new List<Disciplina>();

            foreach (var item in checkedListBoxDProfessor.CheckedItems)
            {
                if (item is Disciplina disciplina)
                {
                    disciplinasSelecionadas.Add(disciplina);
                }
            }

            return disciplinasSelecionadas;
        }

        private bool ValidaForm()
        {
            // Validar se todos os campos obrigatórios estão preenchidos corretamente
            if (string.IsNullOrWhiteSpace(textNomeProfessor.Text))
            {
                MessageBox.Show("Insira o nome do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textApelidoProfessor.Text))
            {
                MessageBox.Show("Insira o apelido do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textDataEntradaProfessor.Text))
            {
                MessageBox.Show("Insira a data de entrada do professor (formato: dd/MM/yyyy)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateOnly.TryParseExact(textDataEntradaProfessor.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Insira uma data de entrada válida (formato: dd/MM/yyyy)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxGeneroProfessor.SelectedItem == null)
            {
                MessageBox.Show("Selecione o gênero do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxSalarioProfessor.SelectedItem == null)
            {
                MessageBox.Show("Selecione o salário do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (checkedListBoxDProfessor.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma disciplina lecionada pelo professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textTelemovelProfessor.Text))
            {
                MessageBox.Show("Insira o número de telefone do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(textTelemovelProfessor.Text))
            {
                MessageBox.Show("Insira o número de telefone do professor válido (9xxxxxxxx)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (string.IsNullOrWhiteSpace(textMoradaProfessor.Text))
            {
                MessageBox.Show("Insira a morada do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxStatusProfessor.SelectedItem == null)
            {
                MessageBox.Show("Selecione o status do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textEmailProfessor.Text))
            {
                MessageBox.Show("Insira o email do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar apenas se o campo de email está preenchido
            if (!IsValidEmail(textEmailProfessor.Text))
            {
                MessageBox.Show("Insira o email do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancelarProfessor_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
