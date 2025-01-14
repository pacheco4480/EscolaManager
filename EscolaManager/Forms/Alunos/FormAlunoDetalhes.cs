using Biblioteca;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormAlunoDetalhes : Form
    {
        public Alunos NovoAluno { get; private set; }
        private List<Disciplina> Disciplinas;
        private List<Alunos> Alunos;
        private List<Turma> Turmas;
        private List<TarifasMensais> Tarifas;
        private List<Pais> Pais;

        public FormAlunoDetalhes(List<Disciplina> disciplinas, List<Alunos> alunos, Alunos aluno)
        {
            InitializeComponent();
            Disciplinas = disciplinas;
            Alunos = alunos;
            Turmas = GestorArquivos.CarregarDados<List<Turma>>("turmas.json") ?? new List<Turma>();
            Tarifas = GestorArquivos.CarregarDados<List<TarifasMensais>>("tarifasMensais.json") ?? new List<TarifasMensais>();
            Pais = GestorArquivos.CarregarDados<List<Pais>>("pais.json") ?? new List<Pais>();

            CarregarDados();

            checkedListDAluno.DataSource = Disciplinas;
            checkedListDAluno.DisplayMember = "Nome";

            comboBoxGeneroAluno.Items.AddRange(new string[] { "Masculino", "Feminino" });
            comboBoxGeneroAluno.SelectedIndex = 0;

            comboBoxStatusAluno.Items.AddRange(new string[] { "Inscrito", "Não inscrito", "Graduado" });
            comboBoxStatusAluno.SelectedIndex = 0;

            comboBoxTurmaAluno.DataSource = Turmas;
            comboBoxTurmaAluno.DisplayMember = "Nome";
            comboBoxTurmaAluno.ValueMember = "ID";

            comboBoxMensalidadeAluno.DataSource = Tarifas;
            comboBoxMensalidadeAluno.DisplayMember = "Nome";
            comboBoxMensalidadeAluno.ValueMember = "ID";

            comboBoxAlunoParente.DataSource = Pais;
            comboBoxAlunoParente.DisplayMember = "IDNome";
            comboBoxAlunoParente.ValueMember = "ID";


            lblTitulo.Text = "Alunos Detalhes";
        }


        private void CarregarDados()
        {
            int proximoIDAluno = Alunos.Count > 0 ? Alunos.Max(a => a.ID) + 1 : 1;
            textIDAluno.Text = proximoIDAluno.ToString();

        }


        private void btnGuardarAlunos_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                NovoAluno = new Alunos
                {
                    ID = int.Parse(textIDAluno.Text),
                    Nome = textNomeAluno.Text,
                    Apelido = textApelidoAluno.Text,
                    Genero = comboBoxGeneroAluno.SelectedItem.ToString(),
                    DataMatricula = DateOnly.Parse(textDMatriculaAluno.Text),
                    Email = textEmailAluno.Text,
                    Morada = textMoradaAluno.Text,
                    Telemovel = textTelemovelAluno.Text,
                    TurmaID = (int)comboBoxTurmaAluno.SelectedValue,
                    EscolaAnterior = textEscolaAAluno.Text,
                    MensalidadeID = (int)comboBoxMensalidadeAluno.SelectedValue,
                    PaiID = (int)comboBoxAlunoParente.SelectedValue,
                    DisciplinasInscritas = ObterDisciplinasSelecionadas(),
                    Status = comboBoxStatusAluno.SelectedItem.ToString(),
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Disciplina> ObterDisciplinasSelecionadas()
        {
            List<Disciplina> disciplinasSelecionadas = new List<Disciplina>();

            foreach (var item in checkedListDAluno.CheckedItems)
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
            if (string.IsNullOrWhiteSpace(textNomeAluno.Text))
            {
                MessageBox.Show("Insira o nome do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textApelidoAluno.Text))
            {
                MessageBox.Show("Insira o apelido do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (string.IsNullOrWhiteSpace(textDMatriculaAluno.Text))
            {
                MessageBox.Show("Insira a data de entrada do professor (formato: dd/MM/yyyy)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateOnly.TryParseExact(textDMatriculaAluno.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Insira uma data de entrada válida (formato: dd/MM/yyyy)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textEmailAluno.Text))
            {
                MessageBox.Show("Insira o email do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidEmail(textEmailAluno.Text))
            {
                MessageBox.Show("Insira um email válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textMoradaAluno.Text))
            {
                MessageBox.Show("Insira a morada do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textTelemovelAluno.Text))
            {
                MessageBox.Show("Insira o telemóvel do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidPhoneNumber(textTelemovelAluno.Text))
            {
                MessageBox.Show("Insira um número de telemóvel válido (9xxxxxxxx)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxTurmaAluno.SelectedItem == null)
            {
                MessageBox.Show("Selecione a turma do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxMensalidadeAluno.SelectedItem == null)
            {
                MessageBox.Show("Selecione a mensalidade do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxAlunoParente.SelectedItem == null)
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
