using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormSalarios : Form
    {
        public string Titulo { get; set; } = "Salários";
        private List<Salarios> salarios;

        public FormSalarios()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
            AtualizarDataGridView();
        }

        private void CarregarDados()
        {
            salarios = GestorArquivos.CarregarDados<List<Salarios>>("salarios.json") ?? new List<Salarios>();
        }

        private void ConfigurarDataGridView()
        {
            // Limpar colunas existentes, se houver
            dataGridViewSalarios.Columns.Clear();

            dataGridViewSalarios.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaID = new DataGridViewTextBoxColumn();
            colunaID.DataPropertyName = "ID";
            colunaID.HeaderText = "ID";
            colunaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSalarios.Columns.Add(colunaID);

            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome";
            colunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSalarios.Columns.Add(colunaNome);

            DataGridViewTextBoxColumn colunaValor = new DataGridViewTextBoxColumn();
            colunaValor.DataPropertyName = "Valor";
            colunaValor.HeaderText = "Valor";
            colunaValor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSalarios.Columns.Add(colunaValor);

            DataGridViewTextBoxColumn colunaDescricao = new DataGridViewTextBoxColumn();
            colunaDescricao.DataPropertyName = "Descricao";
            colunaDescricao.HeaderText = "Descrição";
            colunaDescricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSalarios.Columns.Add(colunaDescricao);

            DataGridViewButtonColumn colunaEditar = new DataGridViewButtonColumn();
            colunaEditar.HeaderText = "Editar";
            colunaEditar.Text = "Editar";
            colunaEditar.UseColumnTextForButtonValue = true;
            colunaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaEditar.FlatStyle = FlatStyle.Flat;
            colunaEditar.CellTemplate.Style.BackColor = SystemColors.ControlLight;
            dataGridViewSalarios.Columns.Add(colunaEditar);

            DataGridViewButtonColumn colunaApagar = new DataGridViewButtonColumn();
            colunaApagar.HeaderText = "Apagar";
            colunaApagar.Text = "Apagar";
            colunaApagar.UseColumnTextForButtonValue = true;
            colunaApagar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaApagar.FlatStyle = FlatStyle.Flat;
            colunaApagar.CellTemplate.Style.BackColor = Color.LightCoral;
            dataGridViewSalarios.Columns.Add(colunaApagar);

            dataGridViewSalarios.CellContentClick += DataGridViewSalarios_CellContentClick;
        }

        private void DataGridViewSalarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewSalarios.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < salarios.Count)
                {
                    if (dataGridViewSalarios.Columns[e.ColumnIndex].HeaderText == "Editar")
                    {
                        EditarSalario(e.RowIndex);
                    }
                    else if (dataGridViewSalarios.Columns[e.ColumnIndex].HeaderText == "Apagar")
                    {
                        ApagarSalario(e.RowIndex);
                    }
                }
            }
        }

        private void EditarSalario(int rowIndex)
        {
            Salarios salarioSelecionado = salarios[rowIndex];

            using (var formEditar = new FormSalarioEditar(salarios, salarioSelecionado))
            {
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    AtualizarDataGridView();
                    MessageBox.Show("Salário editado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edição de salário cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ApagarSalario(int rowIndex)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este salário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                salarios.RemoveAt(rowIndex);
                SalvarDados();
                AtualizarDataGridView();
                MessageBox.Show("Salário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalvarDados()
        {
            GestorArquivos.SalvarDados(salarios, "salarios.json");
        }

        private void AtualizarDataGridView()
        {
            dataGridViewSalarios.DataSource = null;
            dataGridViewSalarios.DataSource = salarios.Select(s => new
            {
                ID = s.ID,
                Nome = s.Nome,
                Valor = s.Valor,
                Descricao = s.Descricao
            }).ToList();
        }

        private void btnAdicionarSalario_Click(object sender, EventArgs e)
        {
            using (var formSalarioDetalhes = new FormSalarioDetalhes(salarios))
            {
                formSalarioDetalhes.ShowDialog();

                if (formSalarioDetalhes.DialogResult == DialogResult.OK)
                {
                    Salarios novoSalario = formSalarioDetalhes.NovoSalario;
                    if (novoSalario != null)
                    {
                        salarios.Add(novoSalario);
                        GestorArquivos.SalvarDados(salarios, "salarios.json");
                        AtualizarDataGridView();
                        MessageBox.Show("Salário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Adição de salário cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
