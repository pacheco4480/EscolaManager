using Biblioteca;
using System;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormInformacoesEscola : Form
    {
        public string Titulo { get; set; } = "Escola";

        private InformacoesEscola informacoes;

        public FormInformacoesEscola()
        {
            InitializeComponent();
            informacoes = GestorArquivos.CarregarDados<InformacoesEscola>("informacoesEscola.json") ?? new InformacoesEscola();
            ExibirInformacoes();
        }

        private void ExibirInformacoes()
        {
            textBoxNomeEscola.Text = informacoes.Nome;
            textMoradaEscola.Text = informacoes.Morada;
            textCAgrupamento.Text = informacoes.CodigoAgrupamento.ToString();
            textTelemovelEscola.Text = informacoes.Telemovel.ToString();
            textTelefoneEscola.Text = informacoes.Telefone.ToString();
            textSiteEscola.Text = informacoes.Website;
            textEmailEscola.Text = informacoes.Email;
        }

        public void AtualizarInformacoes(InformacoesEscola novasInformacoes)
        {
            informacoes = novasInformacoes;
            ExibirInformacoes();
            GestorArquivos.SalvarDados(informacoes, "informacoesEscola.json");
        }

        private void btnGuardarInformacoes_Click(object sender, EventArgs e)
        {
            informacoes.Nome = textBoxNomeEscola.Text;
            informacoes.Morada = textMoradaEscola.Text;
            informacoes.CodigoAgrupamento = int.Parse(textCAgrupamento.Text);
            informacoes.Telemovel = int.Parse(textTelemovelEscola.Text);
            informacoes.Telefone = int.Parse(textTelefoneEscola.Text);
            informacoes.Website = textSiteEscola.Text;
            informacoes.Email = textEmailEscola.Text;

            GestorArquivos.SalvarDados(informacoes, "informacoesEscola.json");

            MessageBox.Show("Informações da escola foram atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdicionarInfoEscola_Click_1(object sender, EventArgs e)
        {
            FormInformacaoEscolaDetalhes formDetalhes = new FormInformacaoEscolaDetalhes(this, informacoes);
            formDetalhes.ShowDialog();
        }

    }

}
