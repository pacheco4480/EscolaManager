using Biblioteca;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormAlunoEditar : Form
    {
        private Alunos AlunoSelecionado;
        private List<Disciplina> Disciplinas;
        private List<Turma> Turmas;
        private List<TarifasMensais> Tarifas;
        private List<Pais> Pais;


        public FormAlunoEditar(List<Disciplina> disciplinas, List<Turma> turmas, List<TarifasMensais> tarifas, List<Pais> pais, Alunos aluno)
        {
            InitializeComponent();
            Disciplinas = disciplinas;
            Turmas = turmas;
            Tarifas = tarifas;
            Pais = pais;
            AlunoSelecionado = aluno;

            textIDAlunoEdit.Text = AlunoSelecionado.ID.ToString();
            textNomeAlunoEdit.Text = AlunoSelecionado.Nome;
            textApelidoAlunoEdit.Text = AlunoSelecionado.Apelido;
            textDMatriculaAlunoEdit.Text = AlunoSelecionado.DataMatricula.ToString();
            textEmailAlunoEdit.Text = AlunoSelecionado.Email;
            textMoradaAlunoEdit.Text = AlunoSelecionado.Morada;
            textTelemovelAlunoEdit.Text = AlunoSelecionado.Telemovel;
            textEscolaAAlunoEdit.Text = AlunoSelecionado.EscolaAnterior;

            // Configurar DataSource e DisplayMember para checkedListDAlunoEdit
            checkedListDAlunoEdit.DataSource = Disciplinas;
            checkedListDAlunoEdit.DisplayMember = "Nome";

            // Marcar as disciplinas matriculadas pelo aluno
            foreach (var disciplina in AlunoSelecionado.DisciplinasInscritas)
            {
                int index = Disciplinas.FindIndex(d => d.ID == disciplina.ID);
                if (index >= 0 && index < checkedListDAlunoEdit.Items.Count)
                {
                    checkedListDAlunoEdit.SetItemChecked(index, true);
                }
            }

            // Configurar combobox GeneroAlunoEdit
            comboBoxGeneroAlunoEdit.Items.AddRange(new string[] { "Masculino", "Feminino" });
            comboBoxGeneroAlunoEdit.SelectedItem = AlunoSelecionado.Genero;

            // Configurar combobox StatusAlunoEdit
            comboBoxStatusAlunoEdit.Items.AddRange(new string[] { "Inscrito", "Não inscrito", "Graduado" });
            comboBoxStatusAlunoEdit.SelectedItem = AlunoSelecionado.Status;

            // Configurar DataSource e DisplayMember para comboBoxTurmaAlunoEdit
            comboBoxTurmaAlunoEdit.DataSource = Turmas;
            comboBoxTurmaAlunoEdit.DisplayMember = "Nome";
            comboBoxTurmaAlunoEdit.ValueMember = "ID";
            comboBoxTurmaAlunoEdit.SelectedValue = AlunoSelecionado.TurmaID;

            // Configurar DataSource e DisplayMember para comboBoxMensalidadeAlunoEdit
            comboBoxMensalidadeAlunoEdit.DataSource = Tarifas;
            comboBoxMensalidadeAlunoEdit.DisplayMember = "Nome";
            comboBoxMensalidadeAlunoEdit.ValueMember = "ID";
            comboBoxMensalidadeAlunoEdit.SelectedValue = AlunoSelecionado.MensalidadeID;

            // Configurar DataSource e DisplayMember para comboBoxAlunoParenteEdit
            comboBoxAlunoParenteEdit.DataSource = Pais;
            comboBoxAlunoParenteEdit.DisplayMember = "IDNome";
            comboBoxAlunoParenteEdit.ValueMember = "ID";
            comboBoxAlunoParenteEdit.SelectedValue = AlunoSelecionado.PaiID;

            lblTituloEdit.Text = "Aluno Editar Detalhes";
        }


        private void btnGuardarAlunosEdit_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                // Atualizar os dados do aluno selecionado
                AlunoSelecionado.Nome = textNomeAlunoEdit.Text;
                AlunoSelecionado.Apelido = textApelidoAlunoEdit.Text;
                AlunoSelecionado.Genero = comboBoxGeneroAlunoEdit.SelectedItem.ToString();
                AlunoSelecionado.DataMatricula = DateOnly.Parse(textDMatriculaAlunoEdit.Text);
                AlunoSelecionado.Email = textEmailAlunoEdit.Text;
                AlunoSelecionado.Morada = textMoradaAlunoEdit.Text;
                AlunoSelecionado.Telemovel = textTelemovelAlunoEdit.Text;
                AlunoSelecionado.EscolaAnterior = textEscolaAAlunoEdit.Text;
                AlunoSelecionado.TurmaID = (int)comboBoxTurmaAlunoEdit.SelectedValue;
                AlunoSelecionado.MensalidadeID = (int)comboBoxMensalidadeAlunoEdit.SelectedValue;
                AlunoSelecionado.PaiID = (int)comboBoxAlunoParenteEdit.SelectedValue;
                AlunoSelecionado.DisciplinasInscritas = ObterDisciplinasSelecionadas();
                AlunoSelecionado.Status = comboBoxStatusAlunoEdit.SelectedItem.ToString();

                // Salvar dados atualizados
                SalvarDados();

                // Fechar o formulário
                DialogResult = DialogResult.OK;
                Close();
                MessageBox.Show("Aluno editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Disciplina> ObterDisciplinasSelecionadas()
        {
            List<Disciplina> disciplinasSelecionadas = new List<Disciplina>();

            foreach (var item in checkedListDAlunoEdit.CheckedItems)
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
            GestorArquivos.SalvarDados(AlunoSelecionado, "alunos.json");
        }

        private bool ValidaForm()
        {
            if (string.IsNullOrWhiteSpace(textNomeAlunoEdit.Text))
            {
                MessageBox.Show("Insira o nome do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textApelidoAlunoEdit.Text))
            {
                MessageBox.Show("Insira o apelido do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textDMatriculaAlunoEdit.Text))
            {
                MessageBox.Show("Insira a data de entrada do professor (formato: dd/MM/yyyy)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateOnly.TryParseExact(textDMatriculaAlunoEdit.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Insira uma data de entrada válida (formato: dd/MM/yyyy)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (string.IsNullOrWhiteSpace(textEmailAlunoEdit.Text))
            {
                MessageBox.Show("Insira o email do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(textEmailAlunoEdit.Text))
            {
                MessageBox.Show("Insira um email válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textMoradaAlunoEdit.Text))
            {
                MessageBox.Show("Insira a morada do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textTelemovelAlunoEdit.Text))
            {
                MessageBox.Show("Insira o telemóvel do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(textTelemovelAlunoEdit.Text))
            {
                MessageBox.Show("Insira um número de telemóvel válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxTurmaAlunoEdit.SelectedItem == null)
            {
                MessageBox.Show("Selecione a turma do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxMensalidadeAlunoEdit.SelectedItem == null)
            {
                MessageBox.Show("Selecione a mensalidade do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxAlunoParenteEdit.SelectedItem == null)
            {
                MessageBox.Show("Selecione o Parente do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCancelarAlunosEdit_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
