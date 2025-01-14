using Biblioteca;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormProfessorEditar : Form
    {
        private List<Disciplina> Disciplinas;
        private List<Salarios> Salarios;
        private Professores ProfessorSelecionado;

        public FormProfessorEditar(List<Disciplina> disciplinas, List<Salarios> salarios, Professores professor)
        {
            InitializeComponent();
            Disciplinas = disciplinas;
            Salarios = salarios;
            ProfessorSelecionado = professor;

            // Preencher campos com os dados do professor selecionado
            textIDStaffEdit.Text = ProfessorSelecionado.ID.ToString();
            textNomeProfessorEdit.Text = ProfessorSelecionado.Nome;
            textApelidoProfessorEdit.Text = ProfessorSelecionado.Apelido;

            comboBoxGeneroProfessorEdit.Items.AddRange(new string[] { "Masculino", "Feminino" });
            comboBoxGeneroProfessorEdit.SelectedItem = ProfessorSelecionado.Genero;

            textDataEntradaProfessorEdit.Text = ProfessorSelecionado.DataEntrada.ToString();
            textTelemovelProfessorEdit.Text = ProfessorSelecionado.Telefone;
            textEmailProfessorEdit.Text = ProfessorSelecionado.Email;
            textMoradaProfessorEdit.Text = ProfessorSelecionado.Morada;

            // Configurar DataSource e DisplayMember para checkedListBoxDProfessorEdit
            checkedListBoxDProfessorEdit.DataSource = Disciplinas;
            checkedListBoxDProfessorEdit.DisplayMember = "Nome";

            // Marcar as disciplinas lecionadas pelo professor
            foreach (var disciplina in ProfessorSelecionado.DisciplinasLecionadas)
            {
                int index = Disciplinas.FindIndex(d => d.ID == disciplina.ID);
                if (index >= 0 && index < checkedListBoxDProfessorEdit.Items.Count)
                {
                    checkedListBoxDProfessorEdit.SetItemChecked(index, true);
                }
            }

            // Configurar combobox Salário
            comboBoxSalarioProfessorEdit.DataSource = Salarios;
            comboBoxSalarioProfessorEdit.DisplayMember = "Nome";
            comboBoxSalarioProfessorEdit.ValueMember = "ID";
            comboBoxSalarioProfessorEdit.SelectedValue = ProfessorSelecionado.SalarioID;

            // Configurar combobox Status
            comboBoxStatusProfessorEdit.Items.AddRange(new string[] { "Ativo", "Inativo" });
            comboBoxStatusProfessorEdit.SelectedItem = ProfessorSelecionado.Status;


            lblTituloEdit.Text = "Professor Editar Detalhes";
        }

        private void btnGuardarProfessorEdit_Click_1(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                // Atualizar os dados do professor selecionado
                ProfessorSelecionado.Nome = textNomeProfessorEdit.Text;
                ProfessorSelecionado.Apelido = textApelidoProfessorEdit.Text;
                ProfessorSelecionado.Genero = comboBoxGeneroProfessorEdit.SelectedItem.ToString();
                ProfessorSelecionado.DataEntrada = DateOnly.Parse(textDataEntradaProfessorEdit.Text);
                ProfessorSelecionado.Telefone = textTelemovelProfessorEdit.Text;
                ProfessorSelecionado.Email = textEmailProfessorEdit.Text;
                ProfessorSelecionado.Morada = textMoradaProfessorEdit.Text;
                ProfessorSelecionado.SalarioID = (int)comboBoxSalarioProfessorEdit.SelectedValue;
                ProfessorSelecionado.DisciplinasLecionadas = ObterDisciplinasSelecionadas();
                ProfessorSelecionado.Status = comboBoxStatusProfessorEdit.SelectedItem.ToString();

                // Salvar dados atualizados
                SalvarDados();

                // Fechar o formulário
                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("Professor editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Disciplina> ObterDisciplinasSelecionadas()
        {
            List<Disciplina> disciplinasSelecionadas = new List<Disciplina>();

            foreach (var item in checkedListBoxDProfessorEdit.CheckedItems)
            {
                if (item is Disciplina disciplina)
                {
                    disciplinasSelecionadas.Add(disciplina);
                }
            }

            return disciplinasSelecionadas;
        }



        private void SalvarDados()
        {
            // Salvar lista atualizada no arquivo JSON
            GestorArquivos.SalvarDados(ProfessorSelecionado, "professores.json");
        }

        private bool ValidaForm()
        {
            // Validar se todos os campos obrigatórios estão preenchidos corretamente
            if (string.IsNullOrWhiteSpace(textNomeProfessorEdit.Text))
            {
                MessageBox.Show("Insira o nome do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textApelidoProfessorEdit.Text))
            {
                MessageBox.Show("Insira o apelido do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textDataEntradaProfessorEdit.Text))
            {
                MessageBox.Show("Insira a data de entrada do professor (formato: dd/MM/yyyy)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateOnly.TryParseExact(textDataEntradaProfessorEdit.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Insira uma data de entrada válida (formato: dd/MM/yyyy)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxGeneroProfessorEdit.SelectedItem == null)
            {
                MessageBox.Show("Selecione o gênero do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxSalarioProfessorEdit.SelectedItem == null)
            {
                MessageBox.Show("Selecione o salário do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (checkedListBoxDProfessorEdit.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma disciplina lecionada pelo professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textTelemovelProfessorEdit.Text))
            {
                MessageBox.Show("Insira o número de telefone do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(textTelemovelProfessorEdit.Text))
            {
                MessageBox.Show("Insira o número de telefone do professor válido (9xxxxxxxx)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (string.IsNullOrWhiteSpace(textMoradaProfessorEdit.Text))
            {
                MessageBox.Show("Insira a morada do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxStatusProfessorEdit.SelectedItem == null)
            {
                MessageBox.Show("Selecione o status do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textEmailProfessorEdit.Text))
            {
                MessageBox.Show("Insira o email do professor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar apenas se o campo de email está preenchido
            if (!IsValidEmail(textEmailProfessorEdit.Text))
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

        private void btnCancelarProfessorEdit_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
