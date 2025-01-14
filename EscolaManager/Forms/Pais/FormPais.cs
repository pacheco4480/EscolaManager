using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormPais : Form
    {
        public string Titulo { get; set; } = "Parente";
        private List<Pais> Pais;

        public FormPais()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarDados();
            AtualizarDataGridView();
        }

        private void CarregarDados()
        {
            Pais = GestorArquivos.CarregarDados<List<Pais>>("pais.json") ?? new List<Pais>();
        }

        private void ConfigurarDataGridView()
        {
            // Limpar colunas existentes, se houver
            dataGridViewPais.Columns.Clear();

            // Configurar colunas da DataGridView
            dataGridViewPais.AutoGenerateColumns = false;

            // Coluna ID
            DataGridViewTextBoxColumn colunaID = new DataGridViewTextBoxColumn();
            colunaID.DataPropertyName = "ID";
            colunaID.HeaderText = "ID";
            colunaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPais.Columns.Add(colunaID);

            // Coluna Nome Completo
            DataGridViewTextBoxColumn colunaNomeCompleto = new DataGridViewTextBoxColumn();
            colunaNomeCompleto.DataPropertyName = "NomeCompleto";
            colunaNomeCompleto.HeaderText = "Nome Completo";
            colunaNomeCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPais.Columns.Add(colunaNomeCompleto);

            // Coluna Email
            DataGridViewTextBoxColumn colunaEmail = new DataGridViewTextBoxColumn();
            colunaEmail.DataPropertyName = "Email";
            colunaEmail.HeaderText = "Email";
            colunaEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPais.Columns.Add(colunaEmail);

            // Coluna Telefone
            DataGridViewTextBoxColumn colunaTelefone = new DataGridViewTextBoxColumn();
            colunaTelefone.DataPropertyName = "Telemovel";
            colunaTelefone.HeaderText = "Telemovel";
            colunaTelefone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPais.Columns.Add(colunaTelefone);

            // Coluna Morada
            DataGridViewTextBoxColumn colunaMorada = new DataGridViewTextBoxColumn();
            colunaMorada.DataPropertyName = "Morada";
            colunaMorada.HeaderText = "Morada";
            colunaMorada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPais.Columns.Add(colunaMorada);

            // Coluna Status
            DataGridViewTextBoxColumn colunaStatus = new DataGridViewTextBoxColumn();
            colunaStatus.DataPropertyName = "Status";
            colunaStatus.HeaderText = "Status";
            colunaStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPais.Columns.Add(colunaStatus);

            // Coluna Editar
            DataGridViewButtonColumn colunaEditar = new DataGridViewButtonColumn();
            colunaEditar.HeaderText = "Editar";
            colunaEditar.Text = "Editar";
            colunaEditar.UseColumnTextForButtonValue = true;
            colunaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaEditar.FlatStyle = FlatStyle.Flat;
            colunaEditar.DefaultCellStyle.BackColor = SystemColors.ControlLight;
            dataGridViewPais.Columns.Add(colunaEditar);

            // Coluna Apagar
            DataGridViewButtonColumn colunaApagar = new DataGridViewButtonColumn();
            colunaApagar.HeaderText = "Apagar";
            colunaApagar.Text = "Apagar";
            colunaApagar.UseColumnTextForButtonValue = true;
            colunaApagar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colunaApagar.FlatStyle = FlatStyle.Flat;
            colunaApagar.DefaultCellStyle.BackColor = Color.LightCoral;
            dataGridViewPais.Columns.Add(colunaApagar);

            // Associar evento de clique dos botões
            dataGridViewPais.CellContentClick += DataGridViewPais_CellContentClick;
        }



        private void DataGridViewPais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewPais.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    if (dataGridViewPais.Columns[e.ColumnIndex].HeaderText == "Editar")
                    {
                        EditarPai(e.RowIndex);
                    }
                    else if (dataGridViewPais.Columns[e.ColumnIndex].HeaderText == "Apagar")
                    {
                        ApagarPai(e.RowIndex);
                    }
                }
            }
        }

        private void EditarPai(int rowIndex)
        {
            Pais paiSelecionado = Pais[rowIndex];

            using (var formEditar = new FormPaiEditar(paiSelecionado, Pais))
            {
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    SalvarDados();
                    AtualizarDataGridView();
                    MessageBox.Show("Dados do Parente editados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Edição do dados do Parente cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ApagarPai(int rowIndex)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este Parente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Pais.RemoveAt(rowIndex);
                SalvarDados();
                AtualizarDataGridView();
                MessageBox.Show("Parente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SalvarDados()
        {
            GestorArquivos.SalvarDados(Pais, "pais.json");
        }


        private void AtualizarDataGridView()
        {
            dataGridViewPais.DataSource = null;
            dataGridViewPais.DataSource = Pais.Select(p => new
            {
                p.ID,
                NomeCompleto = $"{p.Nome} {p.Apelido}",
                p.Email,
                p.Telemovel,
                p.Morada,
                p.Status
            }).ToList();
        }



        private void btnAdicionarPais_Click(object sender, EventArgs e)
        {
            using (var formPaiDetalhes = new FormPaiDetalhes(Pais))
            {
                formPaiDetalhes.ShowDialog();

                if (formPaiDetalhes.DialogResult == DialogResult.OK)
                {
                    var novoPai = formPaiDetalhes.NovoPai;
                    if (novoPai != null)
                    {
                        Pais.Add(novoPai);
                        SalvarDados();
                        AtualizarDataGridView();
                        MessageBox.Show("Parente adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Adição de Parente cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
