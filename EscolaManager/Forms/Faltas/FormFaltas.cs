using Biblioteca;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormFaltas : Form
    {
        public string Titulo { get; set; } = "Faltas";
        private List<Faltas> Faltas;
        private List<Alunos> Alunos;
        private List<Disciplina> Disciplinas;

        public FormFaltas()
        {
            InitializeComponent();
            CarregarDados();
            ConfigurarDataGridView();
            AtualizarDataGridView();
        }

        private void CarregarDados()
        {
            Faltas = GestorArquivos.CarregarDados<List<Faltas>>("faltas.json") ?? new List<Faltas>();
            Alunos = GestorArquivos.CarregarDados<List<Alunos>>("alunos.json") ?? new List<Alunos>();
            Disciplinas = GestorArquivos.CarregarDados<List<Disciplina>>("disciplinas.json") ?? new List<Disciplina>();
        }

        private void ConfigurarDataGridView()
        {
            // Limpar colunas existentes, se houver
            dataGridViewFaltas.Columns.Clear();

            // Configurar colunas da DataGridView
            dataGridViewFaltas.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaID = new DataGridViewTextBoxColumn();
            colunaID.DataPropertyName = "ID";
            colunaID.HeaderText = "ID";
            colunaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFaltas.Columns.Add(colunaID);

            DataGridViewTextBoxColumn colunaAluno = new DataGridViewTextBoxColumn();
            colunaAluno.DataPropertyName = "AlunoNome";
            colunaAluno.HeaderText = "Aluno";
            colunaAluno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFaltas.Columns.Add(colunaAluno);

            DataGridViewTextBoxColumn colunaDisciplina = new DataGridViewTextBoxColumn();
            colunaDisciplina.DataPropertyName = "DisciplinaNome";
            colunaDisciplina.HeaderText = "Disciplina";
            colunaDisciplina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFaltas.Columns.Add(colunaDisciplina);

            DataGridViewTextBoxColumn colunaData = new DataGridViewTextBoxColumn();
            colunaData.DataPropertyName = "DataFalta";
            colunaData.HeaderText = "Data";
            colunaData.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFaltas.Columns.Add(colunaData);

            DataGridViewTextBoxColumn colunaMotivo = new DataGridViewTextBoxColumn();
            colunaMotivo.DataPropertyName = "Motivo";
            colunaMotivo.HeaderText = "Motivo";
            colunaMotivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewFaltas.Columns.Add(colunaMotivo);

            DataGridViewButtonColumn colunaEditar = new DataGridViewButtonColumn();
            colunaEditar.HeaderText = "Editar";
            colunaEditar.Text = "Editar";
            colunaEditar.UseColumnTextForButtonValue = true;
            colunaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaEditar.FlatStyle = FlatStyle.Flat;
            colunaEditar.CellTemplate.Style.BackColor = SystemColors.ControlLight;
            dataGridViewFaltas.Columns.Add(colunaEditar);

            DataGridViewButtonColumn colunaApagar = new DataGridViewButtonColumn();
            colunaApagar.HeaderText = "Apagar";
            colunaApagar.Text = "Apagar";
            colunaApagar.UseColumnTextForButtonValue = true;
            colunaApagar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaApagar.FlatStyle = FlatStyle.Flat;
            colunaApagar.CellTemplate.Style.BackColor = Color.LightCoral;
            dataGridViewFaltas.Columns.Add(colunaApagar);

            dataGridViewFaltas.CellContentClick += DataGridViewFaltas_CellContentClick;
        }

        private void DataGridViewFaltas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewFaltas.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (dataGridViewFaltas.Columns[e.ColumnIndex].HeaderText == "Editar")
                    {
                        EditarFalta(e.RowIndex);
                    }
                    else if (dataGridViewFaltas.Columns[e.ColumnIndex].HeaderText == "Apagar")
                    {
                        ApagarFalta(e.RowIndex);
                    }
                }
            }
        }

        private void EditarFalta(int rowIndex)
        {
            Faltas faltaSelecionada = Faltas[rowIndex];

            using (var formEditar = new FormFaltaEditar(Alunos, Disciplinas, faltaSelecionada))
            {
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    SalvarDados();
                    AtualizarDataGridView();
                    MessageBox.Show("Dados da Falta editados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edição dos dados da Falta cancelados.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ApagarFalta(int rowIndex)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta falta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Faltas.RemoveAt(rowIndex);
                SalvarDados();
                AtualizarDataGridView();
                MessageBox.Show("Falta excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalvarDados()
        {
            GestorArquivos.SalvarDados(Faltas, "faltas.json");
        }

        private void AtualizarDataGridView()
        {
            dataGridViewFaltas.DataSource = null;
            dataGridViewFaltas.DataSource = Faltas.Select(f => new
            {
                f.ID,
                AlunoNome = Alunos.FirstOrDefault(a => a.ID == f.AlunoID)?.NomeCompleto ?? "N/A",
                DisciplinaNome = Alunos.FirstOrDefault(a => a.ID == f.AlunoID)?.DisciplinasInscritas.FirstOrDefault(d => d.ID == f.DisciplinaID)?.Nome ?? "N/A",
                f.DataFalta,
                f.Motivo
            }).ToList();
        }

        private void btnAdicionarFalta_Click_1(object sender, EventArgs e)
        {
            using (var formFaltaDetalhes = new FormFaltaDetalhes(Alunos, Disciplinas, Faltas))
            {
                if (formFaltaDetalhes.ShowDialog() == DialogResult.OK)
                {
                    var novaFalta = formFaltaDetalhes.NovaFalta;
                    if (novaFalta != null)
                    {
                        Faltas.Add(novaFalta);
                        SalvarDados();
                        AtualizarDataGridView();
                        MessageBox.Show("Falta adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Adição da Falta cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
