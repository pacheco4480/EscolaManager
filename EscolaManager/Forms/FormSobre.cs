using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaManager.Forms
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            // Defina as informações estáticas
            lblTitulo.Text = "EscolaManager";
            lblAutor.Text = "David Pacheco";
            lblData.Text = "30 de Junho de 2024"; // Atualize com a data correta
            lblVersao.Text = "Versão: 1.1.0"; // Atualize com a versão correta do seu projeto

            // Texto descritivo sobre o módulo (pode ser adaptado conforme necessário)
            lblDescricao.Text = "Este módulo faz parte do sistema EscolaManager, \n" +
                                "desenvolvido para gerir informações de alunos, \n" +
                                "disciplinas, faltas, parentes, professores, salários, \n" +
                                "turmas e tarifas mensais num estabelecimento de Ensino.\n\n" +
                                "Funcionalidades principais:\n" +
                                "- Gerenciamento de informações de alunos\n" +
                                "- Controlo de disciplinas e turmas\n" +
                                "- Gestão de tarifas mensais\n" +
                                "- Atualizações em tempo real do dashboard\n\n" +
                                "Este projeto foi desenvolvido com o objetivo de fornecer uma solução \n" +
                                "abrangente e intuitiva para a administração escolar, facilitando o \n" +
                                "controlo de dados acadêmicos e financeiros.";

        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
