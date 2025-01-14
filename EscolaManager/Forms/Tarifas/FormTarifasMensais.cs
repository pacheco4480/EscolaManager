using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormTarifasMensais : Form
    {
        public string Titulo { get; set; } = "Tarifas Mensais";
        private List<TarifasMensais> tarifas;

        public FormTarifasMensais()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
            AtualizarDataGridView();
        }

        private void CarregarDados()
        {
            tarifas = GestorArquivos.CarregarDados<List<TarifasMensais>>("tarifasMensais.json") ?? new List<TarifasMensais>();
        }

        private void ConfigurarDataGridView()
        {
            // Limpar colunas existentes, se houver
            dataGridViewTarifas.Columns.Clear();

            dataGridViewTarifas.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaID = new DataGridViewTextBoxColumn();
            colunaID.DataPropertyName = "ID";
            colunaID.HeaderText = "ID";
            colunaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTarifas.Columns.Add(colunaID);

            DataGridViewTextBoxColumn colunaNome = new DataGridViewTextBoxColumn();
            colunaNome.DataPropertyName = "Nome";
            colunaNome.HeaderText = "Nome";
            colunaNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTarifas.Columns.Add(colunaNome);

            DataGridViewTextBoxColumn colunaValor = new DataGridViewTextBoxColumn();
            colunaValor.DataPropertyName = "Valor";
            colunaValor.HeaderText = "Valor";
            colunaValor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTarifas.Columns.Add(colunaValor);

            DataGridViewTextBoxColumn colunaDescricao = new DataGridViewTextBoxColumn();
            colunaDescricao.DataPropertyName = "Descricao";
            colunaDescricao.HeaderText = "Descrição";
            colunaDescricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTarifas.Columns.Add(colunaDescricao);

            DataGridViewTextBoxColumn colunaStatus = new DataGridViewTextBoxColumn();
            colunaStatus.DataPropertyName = "Status";
            colunaStatus.HeaderText = "Status";
            colunaStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTarifas.Columns.Add(colunaStatus);

            DataGridViewButtonColumn colunaEditar = new DataGridViewButtonColumn();
            colunaEditar.HeaderText = "Editar";
            colunaEditar.Text = "Editar";
            colunaEditar.UseColumnTextForButtonValue = true;
            colunaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaEditar.FlatStyle = FlatStyle.Flat;
            colunaEditar.CellTemplate.Style.BackColor = SystemColors.ControlLight;
            dataGridViewTarifas.Columns.Add(colunaEditar);

            DataGridViewButtonColumn colunaApagar = new DataGridViewButtonColumn();
            colunaApagar.HeaderText = "Apagar";
            colunaApagar.Text = "Apagar";
            colunaApagar.UseColumnTextForButtonValue = true;
            colunaApagar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaApagar.FlatStyle = FlatStyle.Flat;
            colunaApagar.CellTemplate.Style.BackColor = Color.LightCoral;
            dataGridViewTarifas.Columns.Add(colunaApagar);

            dataGridViewTarifas.CellContentClick += DataGridViewTarifas_CellContentClick;
        }

        private void DataGridViewTarifas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewTarifas.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < tarifas.Count)
                {
                    if (dataGridViewTarifas.Columns[e.ColumnIndex].HeaderText == "Editar")
                    {
                        EditarTarifa(e.RowIndex);
                    }
                    else if (dataGridViewTarifas.Columns[e.ColumnIndex].HeaderText == "Apagar")
                    {
                        ApagarTarifa(e.RowIndex);
                    }
                }
            }
        }

        private void EditarTarifa(int rowIndex)
        {
            TarifasMensais tarifaSelecionada = tarifas[rowIndex];

            using (var formEditar = new FormTarifaMensalEditar(tarifas, tarifaSelecionada))
            {
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    SalvarDados();
                    AtualizarDataGridView();
                    MessageBox.Show("Tarifa editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edição de tarifa cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ApagarTarifa(int rowIndex)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta tarifa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                tarifas.RemoveAt(rowIndex);
                SalvarDados();
                AtualizarDataGridView();
                MessageBox.Show("Tarifa excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalvarDados()
        {
            GestorArquivos.SalvarDados(tarifas, "tarifasMensais.json");
        }

        private void AtualizarDataGridView()
        {
            dataGridViewTarifas.DataSource = null;
            dataGridViewTarifas.DataSource = tarifas.Select(t => new
            {
                ID = t.ID,
                Nome = t.Nome,
                Descricao = t.Descricao,
                Valor = t.Valor,
                Status = t.Status
            }).ToList();
        }

        private void btnAdicionarTarifas_Click(object sender, EventArgs e)
        {
            using (var formDetalhes = new FormTarifaMensalDetalhes(tarifas))
            {
                if (formDetalhes.ShowDialog() == DialogResult.OK)
                {
                    TarifasMensais novaTarifa = formDetalhes.NovaTarifa;
                    if (novaTarifa != null)
                    {
                        tarifas.Add(novaTarifa);
                        SalvarDados();
                        AtualizarDataGridView();
                        MessageBox.Show("Tarifa adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Adição de tarifa cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
