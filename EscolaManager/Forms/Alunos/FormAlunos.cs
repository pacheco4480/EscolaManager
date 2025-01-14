using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormAlunos : Form
    {

        public string Titulo { get; set; } = "Alunos";

        private List<Disciplina> Disciplinas;
        private List<Alunos> Alunos;
        private List<Turma> Turmas;
        private List<TarifasMensais> Tarifas;
        private List<Pais> Pais;

        public FormAlunos()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
            AtualizarDataGridView();
        }

        private void CarregarDados()
        {
            Alunos = GestorArquivos.CarregarDados<List<Alunos>>("alunos.json") ?? new List<Alunos>();
            Disciplinas = GestorArquivos.CarregarDados<List<Disciplina>>("disciplinas.json") ?? new List<Disciplina>();
            Turmas = GestorArquivos.CarregarDados<List<Turma>>("turmas.json") ?? new List<Turma>();
            Tarifas = GestorArquivos.CarregarDados<List<TarifasMensais>>("tarifasMensais.json") ?? new List<TarifasMensais>();
            Pais = GestorArquivos.CarregarDados<List<Pais>>("pais.json") ?? new List<Pais>();
        }

        private void ConfigurarDataGridView()
        {
            // Limpar colunas existentes, se houver
            dataGridViewAlunos.Columns.Clear();

            // Configurar colunas da DataGridView
            dataGridViewAlunos.AutoGenerateColumns = false;

            // Definir colunas
            DataGridViewTextBoxColumn colunaID = new DataGridViewTextBoxColumn();
            colunaID.DataPropertyName = "ID";
            colunaID.HeaderText = "ID";
            colunaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewAlunos.Columns.Add(colunaID);

            DataGridViewTextBoxColumn colunaNomeCompleto = new DataGridViewTextBoxColumn();
            colunaNomeCompleto.DataPropertyName = "NomeCompleto";
            colunaNomeCompleto.HeaderText = "Nome Completo";
            colunaNomeCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAlunos.Columns.Add(colunaNomeCompleto);

            DataGridViewTextBoxColumn colunaEmail = new DataGridViewTextBoxColumn();
            colunaEmail.DataPropertyName = "Email";
            colunaEmail.HeaderText = "Email";
            colunaEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAlunos.Columns.Add(colunaEmail);

            DataGridViewTextBoxColumn colunaTelefone = new DataGridViewTextBoxColumn();
            colunaTelefone.DataPropertyName = "Telemovel";
            colunaTelefone.HeaderText = "Telemovel";
            colunaTelefone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAlunos.Columns.Add(colunaTelefone);

            DataGridViewTextBoxColumn colunaDisciplinas = new DataGridViewTextBoxColumn();
            colunaDisciplinas.DataPropertyName = "DisciplinasInscritas";
            colunaDisciplinas.HeaderText = "Disciplinas Inscritas";
            colunaDisciplinas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAlunos.Columns.Add(colunaDisciplinas);

            DataGridViewTextBoxColumn colunaStatus = new DataGridViewTextBoxColumn();
            colunaStatus.DataPropertyName = "Status";
            colunaStatus.HeaderText = "Status";
            colunaStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewAlunos.Columns.Add(colunaStatus);

            // Adicionar coluna de botão Editar
            DataGridViewButtonColumn colunaEditar = new DataGridViewButtonColumn();
            colunaEditar.HeaderText = "Editar";
            colunaEditar.Text = "Editar";
            colunaEditar.UseColumnTextForButtonValue = true;
            colunaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaEditar.FlatStyle = FlatStyle.Flat;
            colunaEditar.CellTemplate.Style.BackColor = SystemColors.ControlLight;
            dataGridViewAlunos.Columns.Add(colunaEditar);

            // Adicionar coluna de botão Apagar
            DataGridViewButtonColumn colunaApagar = new DataGridViewButtonColumn();
            colunaApagar.HeaderText = "Apagar";
            colunaApagar.Text = "Apagar";
            colunaApagar.UseColumnTextForButtonValue = true;
            colunaApagar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaApagar.FlatStyle = FlatStyle.Flat;
            colunaApagar.CellTemplate.Style.BackColor = Color.LightCoral;
            dataGridViewAlunos.Columns.Add(colunaApagar);


            // Associar evento de clique dos botões
            dataGridViewAlunos.CellContentClick += DataGridViewAlunos_CellContentClick;
        }

        private void DataGridViewAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewAlunos.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (dataGridViewAlunos.Columns[e.ColumnIndex].HeaderText == "Editar")
                    {
                        EditarAluno(e.RowIndex);
                    }
                    else if (dataGridViewAlunos.Columns[e.ColumnIndex].HeaderText == "Apagar")
                    {
                        ApagarAluno(e.RowIndex);
                    }
                }
            }
        }

        private void EditarAluno(int rowIndex)
        {
            Alunos alunoSelecionado = Alunos[rowIndex];

            using (var formEditar = new FormAlunoEditar(Disciplinas, Turmas, Tarifas, Pais, alunoSelecionado))
            {
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    SalvarDados();
                    AtualizarDataGridView();
                    MessageBox.Show("Dados do Aluno editados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edição dos dados do Aluno cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void ApagarAluno(int rowIndex)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este aluno?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Alunos.RemoveAt(rowIndex);
                SalvarDados();
                AtualizarDataGridView();
                MessageBox.Show("Aluno excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalvarDados()
        {
            GestorArquivos.SalvarDados(Alunos, "alunos.json");
        }

        private void AtualizarDataGridView()
        {
            dataGridViewAlunos.DataSource = null;
            dataGridViewAlunos.DataSource = Alunos.Select(a => new
            {
                a.ID,
                NomeCompleto = $"{a.Nome} {a.Apelido}",
                a.Email,
                a.Telemovel,
                DisciplinasInscritas = string.Join(", ", a.DisciplinasInscritas.Select(d => d.Nome)),
                a.Status,
            }).ToList();
        }


        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            using (var formAlunoDetalhes = new FormAlunoDetalhes(Disciplinas, Alunos, null))
            {
                formAlunoDetalhes.ShowDialog();

                if (formAlunoDetalhes.DialogResult == DialogResult.OK)
                {
                    var novoAluno = formAlunoDetalhes.NovoAluno;
                    if (novoAluno != null)
                    {
                        Alunos.Add(novoAluno);
                        SalvarDados();
                        AtualizarDataGridView();
                        MessageBox.Show("Aluno adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Adição do Aluno cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static int CalcularTotalAlunosAtivos(List<Alunos> alunos)
        {
            return alunos.Count(a => a.Status == "Inscrito");
        }

        public static int CalcularTotalAlunosFemininos(List<Alunos> alunos)
        {
            return alunos.Count(a => a.Genero == "Feminino");
        }

        public static int CalcularTotalAlunosMasculinos(List<Alunos> alunos)
        {
            return alunos.Count(a => a.Genero == "Masculino");
        }

        public static decimal CalcularTotalGanhos(List<Alunos> alunos, List<TarifasMensais> tarifas)
        {
            var alunosAtivos = alunos.Where(a => a.Status == "Inscrito").ToList();
            decimal totalGanhos = 0;

            foreach (var aluno in alunosAtivos)
            {
                var tarifa = tarifas.FirstOrDefault(t => t.ID == aluno.MensalidadeID);
                if (tarifa != null)
                {
                    totalGanhos += (decimal)tarifa.Valor;
                }
            }

            return totalGanhos * 12; // Multiplicando por 12 meses
        }


        public static int CalcularTotalGraduados(List<Alunos> alunos)
        {
            return alunos.Count(a => a.Status == "Graduado");
        }

    }
}
