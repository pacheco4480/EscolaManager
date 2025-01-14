using Biblioteca;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormDisciplinaDetalhes : Form
    {
        public Disciplina NovaDisciplina { get; private set; }
        private List<Disciplina> Disciplinas;

        public FormDisciplinaDetalhes(List<Disciplina> disciplinas)
        {
            InitializeComponent();
            Disciplinas = disciplinas;

            CarregarDados();

            lblTitulo.Text = "Disciplinas Detalhes";
        }

        private void CarregarDados()
        {
            int proximoIDDisciplina = Disciplinas.Count > 0 ? Disciplinas.Max(d => d.ID) + 1 : 1;
            textIDDisciplina.Text = proximoIDDisciplina.ToString();
        }

        private void btnGuardarDisciplina_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                NovaDisciplina = new Disciplina
                {
                    ID = int.Parse(textIDDisciplina.Text),
                    Nome = textNomeDisciplina.Text,
                    Creditos = double.Parse(textCreditosDisciplina.Text)
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaForm()
        {
            if (string.IsNullOrEmpty(textNomeDisciplina.Text))
            {
                MessageBox.Show("Insira nome da disciplina", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textCreditosDisciplina.Text) || !double.TryParse(textCreditosDisciplina.Text, out _))
            {
                MessageBox.Show("Insira créditos válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelarDisciplina_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
