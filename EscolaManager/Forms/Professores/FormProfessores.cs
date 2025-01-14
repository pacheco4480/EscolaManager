using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormProfessores : Form
    {
        public string Titulo { get; set; } = "Professores";
        private List<Disciplina> Disciplinas;
        private List<Professores> Professores;
        private List<Salarios> Salarios;

        public FormProfessores()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
            AtualizarDataGridView();
        }

        private void CarregarDados()
        {
            Professores = GestorArquivos.CarregarDados<List<Professores>>("professores.json") ?? new List<Professores>();
            Disciplinas = GestorArquivos.CarregarDados<List<Disciplina>>("disciplinas.json") ?? new List<Disciplina>();
            Salarios = GestorArquivos.CarregarDados<List<Salarios>>("salarios.json") ?? new List<Salarios>();
        }

        private void ConfigurarDataGridView()
        {
            // Limpar colunas existentes, se houver
            dataGridViewProfessores.Columns.Clear();

            // Configurar colunas da DataGridView
            dataGridViewProfessores.AutoGenerateColumns = false;

            // Definir colunas
            DataGridViewTextBoxColumn colunaID = new DataGridViewTextBoxColumn();
            colunaID.DataPropertyName = "ID";
            colunaID.HeaderText = "ID";
            colunaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProfessores.Columns.Add(colunaID);

            DataGridViewTextBoxColumn colunaNomeCompleto = new DataGridViewTextBoxColumn();
            colunaNomeCompleto.DataPropertyName = "NomeCompleto";
            colunaNomeCompleto.HeaderText = "Nome Completo";
            colunaNomeCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewProfessores.Columns.Add(colunaNomeCompleto);

            DataGridViewTextBoxColumn colunaEmail = new DataGridViewTextBoxColumn();
            colunaEmail.DataPropertyName = "Email";
            colunaEmail.HeaderText = "Email";
            colunaEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewProfessores.Columns.Add(colunaEmail);

            DataGridViewTextBoxColumn colunaTelefone = new DataGridViewTextBoxColumn();
            colunaTelefone.DataPropertyName = "Telefone";
            colunaTelefone.HeaderText = "Telefone";
            colunaTelefone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewProfessores.Columns.Add(colunaTelefone);

            DataGridViewTextBoxColumn colunaDisciplinas = new DataGridViewTextBoxColumn();
            colunaDisciplinas.DataPropertyName = "DisciplinasLecionadas";
            colunaDisciplinas.HeaderText = "Disciplinas Lecionadas";
            colunaDisciplinas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewProfessores.Columns.Add(colunaDisciplinas);

            DataGridViewTextBoxColumn colunaStatus = new DataGridViewTextBoxColumn();
            colunaStatus.DataPropertyName = "Status";
            colunaStatus.HeaderText = "Status";
            colunaStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewProfessores.Columns.Add(colunaStatus);

            // Adicionar coluna de botão Editar
            DataGridViewButtonColumn colunaEditar = new DataGridViewButtonColumn();
            colunaEditar.HeaderText = "Editar";
            colunaEditar.Text = "Editar";
            colunaEditar.UseColumnTextForButtonValue = true;
            colunaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaEditar.FlatStyle = FlatStyle.Flat;
            colunaEditar.CellTemplate.Style.BackColor = SystemColors.ControlLight;
            dataGridViewProfessores.Columns.Add(colunaEditar);

            // Adicionar coluna de botão Apagar
            DataGridViewButtonColumn colunaApagar = new DataGridViewButtonColumn();
            colunaApagar.HeaderText = "Apagar";
            colunaApagar.Text = "Apagar";
            colunaApagar.UseColumnTextForButtonValue = true;
            colunaApagar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaApagar.FlatStyle = FlatStyle.Flat;
            colunaApagar.CellTemplate.Style.BackColor = Color.LightCoral;
            dataGridViewProfessores.Columns.Add(colunaApagar);

            // Associar evento de clique dos botões
            dataGridViewProfessores.CellContentClick += DataGridViewProfessores_CellContentClick;
        }

        private void DataGridViewProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verificar índices válidos
            {
                if (dataGridViewProfessores.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < Professores.Count)
                {
                    if (dataGridViewProfessores.Columns[e.ColumnIndex].HeaderText == "Editar")
                    {
                        EditarProfessor(e.RowIndex);
                    }
                    else if (dataGridViewProfessores.Columns[e.ColumnIndex].HeaderText == "Apagar")
                    {
                        ApagarProfessor(e.RowIndex);
                    }
                }
            }
        }

        private void EditarProfessor(int rowIndex)
        {
            // Obter o professor a ser editado
            Professores professorSelecionado = Professores[rowIndex];

            // Abrir o formulário de edição
            using (var formEditar = new FormProfessorEditar(Disciplinas, Salarios, professorSelecionado))
            {
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    SalvarDados();
                    // Atualizar DataGridView após edição
                    AtualizarDataGridView();
                    MessageBox.Show("Dados do Professor editados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edição dos dados do Professor cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ApagarProfessor(int rowIndex)
        {
            // Confirmar a exclusão com uma mensagem de confirmação
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este professor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Remover professor da lista
                Professores.RemoveAt(rowIndex);

                // Salvar alterações
                SalvarDados();

                // Atualizar DataGridView após exclusão
                AtualizarDataGridView();
                MessageBox.Show("Professor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalvarDados()
        {
            // Salvar lista atualizada no arquivo JSON
            GestorArquivos.SalvarDados(Professores, "professores.json");
        }

        private void AtualizarDataGridView()
        {
            dataGridViewProfessores.DataSource = null;
            dataGridViewProfessores.DataSource = Professores.Select(p => new
            {
                p.ID,
                NomeCompleto = $"{p.Nome} {p.Apelido}",
                p.Email,
                p.Telefone,
                DisciplinasLecionadas = string.Join(", ", p.DisciplinasLecionadas.Select(d => d.Nome)),
                p.Status
            }).ToList();
        }

        private void btnAdicionarProfessores_Click(object sender, EventArgs e)
        {
            using (var formProfessorDetalhes = new FormProfessorDetalhes(Disciplinas, Professores))
            {
                formProfessorDetalhes.ShowDialog();

                if (formProfessorDetalhes.DialogResult == DialogResult.OK)
                {
                    var novoProfessor = formProfessorDetalhes.NovoProfessor;
                    if (novoProfessor != null)
                    {
                        Professores.Add(novoProfessor);
                        SalvarDados();
                        AtualizarDataGridView();
                        MessageBox.Show("Professor adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Adição do Professor cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static int CalcularTotalProfessoresAtivos(List<Professores> professores)
        {
            return professores.Count(p => p.Status == "Ativo");
        }

        public static int CalcularTotalProfessoresFemininos(List<Professores> professores)
        {
            return professores.Count(p => p.Genero == "Feminino");
        }

        public static int CalcularTotalProfessoresMasculinos(List<Professores> professores)
        {
            return professores.Count(p => p.Genero == "Masculino");
        }
    }
}
