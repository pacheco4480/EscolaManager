using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormDisciplinas : Form
    {
        public string Titulo { get; set; } = "Disciplinas";
        private List<Disciplina> disciplinas;

        public FormDisciplinas()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
            AtualizarDataGridView();
        }

        private void CarregarDados()
        {
            disciplinas = GestorArquivos.CarregarDados<List<Disciplina>>("disciplinas.json") ?? new List<Disciplina>();
        }

        private void ConfigurarDataGridView()
        {
            // Limpar colunas existentes, se houver
            dataGridViewDisciplinas.Columns.Clear();

            dataGridViewDisciplinas.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaID = new DataGridViewTextBoxColumn();
            colunaID.DataPropertyName = "ID";
            colunaID.HeaderText = "ID";
            colunaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDisciplinas.Columns.Add(colunaID);

            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome";
            colunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewDisciplinas.Columns.Add(colunaNome);

            DataGridViewTextBoxColumn colunaCreditos = new DataGridViewTextBoxColumn();
            colunaCreditos.DataPropertyName = "Creditos";
            colunaCreditos.HeaderText = "Créditos";
            colunaCreditos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewDisciplinas.Columns.Add(colunaCreditos);

            DataGridViewButtonColumn colunaEditar = new DataGridViewButtonColumn();
            colunaEditar.HeaderText = "Editar";
            colunaEditar.Text = "Editar";
            colunaEditar.UseColumnTextForButtonValue = true;
            colunaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaEditar.FlatStyle = FlatStyle.Flat;
            colunaEditar.CellTemplate.Style.BackColor = SystemColors.ControlLight;
            dataGridViewDisciplinas.Columns.Add(colunaEditar);

            DataGridViewButtonColumn colunaApagar = new DataGridViewButtonColumn();
            colunaApagar.HeaderText = "Apagar";
            colunaApagar.Text = "Apagar";
            colunaApagar.UseColumnTextForButtonValue = true;
            colunaApagar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaApagar.FlatStyle = FlatStyle.Flat;
            colunaApagar.CellTemplate.Style.BackColor = Color.LightCoral;
            dataGridViewDisciplinas.Columns.Add(colunaApagar);

            dataGridViewDisciplinas.CellContentClick += DataGridViewDisciplinas_CellContentClick;
        }

        private void DataGridViewDisciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewDisciplinas.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < disciplinas.Count)
                {
                    if (dataGridViewDisciplinas.Columns[e.ColumnIndex].HeaderText == "Editar")
                    {
                        EditarDisciplina(e.RowIndex);
                    }
                    else if (dataGridViewDisciplinas.Columns[e.ColumnIndex].HeaderText == "Apagar")
                    {
                        ApagarDisciplina(e.RowIndex);
                    }
                }
            }
        }

        private void EditarDisciplina(int rowIndex)
        {
            Disciplina disciplinaSelecionada = disciplinas[rowIndex];

            using (var formEditar = new FormDisciplinaEditar(disciplinas, disciplinaSelecionada))
            {
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    AtualizarDataGridView();
                    MessageBox.Show("Disciplina editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edição de disciplina cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ApagarDisciplina(int rowIndex)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta disciplina?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                disciplinas.RemoveAt(rowIndex);
                SalvarDados();
                AtualizarDataGridView();
                MessageBox.Show("Disciplina excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalvarDados()
        {
            GestorArquivos.SalvarDados(disciplinas, "disciplinas.json");
        }

        private void AtualizarDataGridView()
        {
            dataGridViewDisciplinas.DataSource = null;
            dataGridViewDisciplinas.DataSource = disciplinas.Select(d => new
            {
                ID = d.ID,
                Nome = d.Nome,
                Creditos = d.Creditos
            }).ToList();
        }

        private void btnAdicionarDisciplina_Click(object sender, EventArgs e)
        {
            using (var formDisciplinaDetalhes = new FormDisciplinaDetalhes(disciplinas))
            {
                if (formDisciplinaDetalhes.ShowDialog() == DialogResult.OK)
                {
                    Disciplina novaDisciplina = formDisciplinaDetalhes.NovaDisciplina;
                    if (novaDisciplina != null)
                    {
                        disciplinas.Add(novaDisciplina);
                        SalvarDados();
                        AtualizarDataGridView();
                        MessageBox.Show("Disciplina adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Adição de disciplina cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static int CalcularTotalDisciplinas(List<Disciplina> disciplinas)
        {
            return disciplinas.Count;
        }

    }
}
