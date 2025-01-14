using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormTurmas : Form
    {
        public string Titulo { get; set; } = "Turmas";
        private List<Turma> Turmas;
        private List<Alunos> Alunos;

        public FormTurmas()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
            AtualizarDataGridView();
        }

        private void CarregarDados()
        {
            Turmas = GestorArquivos.CarregarDados<List<Turma>>("turmas.json") ?? new List<Turma>();
            Alunos = GestorArquivos.CarregarDados<List<Alunos>>("alunos.json") ?? new List<Alunos>();

            // Atualizar os IDs dos alunos inscritos em cada turma
            foreach (var turma in Turmas)
            {
                turma.AlunosIDs = Alunos.Where(a => a.TurmaID == turma.ID).Select(a => a.ID).ToList();
            }
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewTurmas.Columns.Clear();
            dataGridViewTurmas.AutoGenerateColumns = false;

            // Coluna ID
            DataGridViewTextBoxColumn colunaID = new DataGridViewTextBoxColumn();
            colunaID.DataPropertyName = "ID";
            colunaID.HeaderText = "ID";
            colunaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTurmas.Columns.Add(colunaID);

            // Coluna Nome
            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome";
            colunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTurmas.Columns.Add(colunaNome);

            // Coluna Ano
            DataGridViewTextBoxColumn colunaAno = new DataGridViewTextBoxColumn();
            colunaAno.DataPropertyName = "Ano";
            colunaAno.HeaderText = "Ano";
            colunaAno.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTurmas.Columns.Add(colunaAno);

            // Coluna Período
            DataGridViewTextBoxColumn colunaPeriodo = new DataGridViewTextBoxColumn();
            colunaPeriodo.DataPropertyName = "Periodo";
            colunaPeriodo.HeaderText = "Período";
            colunaPeriodo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTurmas.Columns.Add(colunaPeriodo);

            // Coluna Status
            DataGridViewTextBoxColumn colunaStatus = new DataGridViewTextBoxColumn();
            colunaStatus.DataPropertyName = "Status";
            colunaStatus.HeaderText = "Status";
            colunaStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTurmas.Columns.Add(colunaStatus);

            // Coluna Qtd. Alunos
            DataGridViewTextBoxColumn colunaQtdAlunos = new DataGridViewTextBoxColumn();
            colunaQtdAlunos.DataPropertyName = "QuantidadeAlunosInscritos";
            colunaQtdAlunos.HeaderText = "Qtd. Alunos";
            colunaQtdAlunos.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTurmas.Columns.Add(colunaQtdAlunos);

            // Coluna Editar
            DataGridViewButtonColumn colunaEditar = new DataGridViewButtonColumn();
            colunaEditar.HeaderText = "Editar";
            colunaEditar.Text = "Editar";
            colunaEditar.UseColumnTextForButtonValue = true;
            colunaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaEditar.FlatStyle = FlatStyle.Flat;
            colunaEditar.DefaultCellStyle.BackColor = SystemColors.ControlLight;
            dataGridViewTurmas.Columns.Add(colunaEditar);

            // Coluna Apagar
            DataGridViewButtonColumn colunaApagar = new DataGridViewButtonColumn();
            colunaApagar.HeaderText = "Apagar";
            colunaApagar.Text = "Apagar";
            colunaApagar.UseColumnTextForButtonValue = true;
            colunaApagar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaApagar.FlatStyle = FlatStyle.Flat;
            colunaApagar.DefaultCellStyle.BackColor = Color.LightCoral;
            dataGridViewTurmas.Columns.Add(colunaApagar);

            // Associar evento de clique dos botões
            dataGridViewTurmas.CellContentClick += DataGridViewTurmas_CellContentClick;
        }

        private void DataGridViewTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewTurmas.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (dataGridViewTurmas.Columns[e.ColumnIndex].HeaderText == "Editar")
                    {
                        EditarTurma(e.RowIndex);
                    }
                    else if (dataGridViewTurmas.Columns[e.ColumnIndex].HeaderText == "Apagar")
                    {
                        ApagarTurma(e.RowIndex);
                    }
                }
            }
        }

        private void EditarTurma(int rowIndex)
        {
            Turma turmaSelecionada = Turmas[rowIndex];

            using (var formEditar = new FormTurmaEditar(turmaSelecionada, Alunos))
            {
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    SalvarDados();
                    AtualizarDataGridView();
                    MessageBox.Show("Dados da Turma editados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edição dos dados da Turma cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ApagarTurma(int rowIndex)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta turma?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Turmas.RemoveAt(rowIndex);
                SalvarDados();
                AtualizarDataGridView();
                MessageBox.Show("Turma excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalvarDados()
        {
            GestorArquivos.SalvarDados(Turmas, "turmas.json");
        }

        private void AtualizarDataGridView()
        {
            dataGridViewTurmas.DataSource = null;
            dataGridViewTurmas.DataSource = Turmas.Select(t => new
            {
                t.ID,
                t.Nome,
                t.Ano,
                t.Periodo,
                t.Status,
                t.QuantidadeAlunosInscritos
            }).ToList();
        }

        private void btnAdicionarTurma_Click_1(object sender, EventArgs e)
        {
            using (var formTurmaDetalhes = new FormTurmaDetalhes(Turmas, Alunos))
            {
                formTurmaDetalhes.ShowDialog();

                if (formTurmaDetalhes.DialogResult == DialogResult.OK)
                {
                    var novaTurma = formTurmaDetalhes.NovaTurma;
                    if (novaTurma != null)
                    {
                        Turmas.Add(novaTurma);
                        SalvarDados();
                        AtualizarDataGridView();
                        MessageBox.Show("Turma adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Adição de Turma cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}