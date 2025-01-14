using Biblioteca;
using EscolaManager.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscolaManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarLabels();
            AbrirFormularioDashboard();
        }

        #region Menu - sidebar

        bool menuExpand = false;
        bool menuExpand2 = false;
        bool menuExpand3 = false;
        bool menuExpand4 = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 135)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 45)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }


        private void menuTransition2_Tick(object sender, EventArgs e)
        {
            if (!menuExpand2)
            {
                menuContainer2.Height += 10;
                if (menuContainer2.Height >= 135)
                {
                    menuTransition2.Stop();
                    menuExpand2 = true;
                }
            }
            else
            {
                menuContainer2.Height -= 10;
                if (menuContainer2.Height <= 45)
                {
                    menuTransition2.Stop();
                    menuExpand2 = false;
                }
            }
        }

        private void menuTransition3_Tick(object sender, EventArgs e)
        {
            if (!menuExpand3)
            {
                menuContainer3.Height += 10;
                if (menuContainer3.Height >= 180)
                {
                    menuTransition3.Stop();
                    menuExpand3 = true;
                }
            }
            else
            {
                menuContainer3.Height -= 10;
                if (menuContainer3.Height <= 45)
                {
                    menuTransition3.Stop();
                    menuExpand3 = false;
                }
            }
        }

        private void menuTransition4_Tick(object sender, EventArgs e)
        {
            if (!menuExpand4)
            {
                menuContainer4.Height += 10;
                if (menuContainer4.Height >= 90)
                {
                    menuTransition4.Stop();
                    menuExpand4 = true;
                }
            }
            else
            {
                menuContainer4.Height -= 10;
                if (menuContainer4.Height <= 45)
                {
                    menuTransition4.Stop();
                    menuExpand4 = false;
                }
            }
        }

        private void CloseAllMenusExcept(int menuNumber)
        {
            if (menuNumber != 1 && menuExpand)
            {
                menuExpand = false;
                menuContainer.Height = 45;
            }
            if (menuNumber != 2 && menuExpand2)
            {
                menuExpand2 = false;
                menuContainer2.Height = 45;
            }
            if (menuNumber != 3 && menuExpand3)
            {
                menuExpand3 = false;
                menuContainer3.Height = 45;
            }
            if (menuNumber != 4 && menuExpand4)
            {
                menuExpand4 = false;
                menuContainer4.Height = 45;
            }
        }

        #endregion

        public void AbrirFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(formulario);
            this.panelPrincipal.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
            lblTitulo.Text = (formulario as dynamic).Titulo;
        }

        #region Métodos de Abertura de Formulários


        public void AbrirFormularioAlunos()
        {
            AbrirFormulario(new FormAlunos());
        }

        public void AbrirFormularioProfessores()
        {
            AbrirFormulario(new FormProfessores());
        }

        public void AbrirFormularioPais()
        {
            AbrirFormulario(new FormPais());
        }

        public void AbrirFormularioDisciplinas()
        {
            AbrirFormulario(new FormDisciplinas());
        }

        public void AbrirFormularioTurmas()
        {
            AbrirFormulario(new FormTurmas());
        }

        public void AbrirFormularioSalarios()
        {
            AbrirFormulario(new FormSalarios());
        }

        public void AbrirFormularioFaltas()
        {
            AbrirFormulario(new FormFaltas());
        }

        public void AbrirFormularioInformacoesEscola()
        {
            AbrirFormulario(new FormInformacoesEscola());
        }

        public void AbrirFormularioTarifasMensais()
        {
            AbrirFormulario(new FormTarifasMensais());
        }

        public void AbrirFormularioDashboard()
        {
            AbrirFormulario(new Dashboard());
        }

        #endregion

        private void btnStaff_Click(object sender, EventArgs e)
        {
            CloseAllMenusExcept(1);
            menuTransition.Start();
        }

        private void btnMenuAlunos_Click(object sender, EventArgs e)
        {
            CloseAllMenusExcept(2);
            menuTransition2.Start();
        }

        private void btnMenuTurmas_Click(object sender, EventArgs e)
        {
            CloseAllMenusExcept(3);
            menuTransition3.Start();
        }

        private void btnDefinicoes_Click(object sender, EventArgs e)
        {
            CloseAllMenusExcept(4);
            menuTransition4.Start();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            AbrirFormularioAlunos();
            AtualizarLabels();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormularioDashboard();
            AtualizarLabels();
        }

        private void btnProfessores_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioProfessores();
            AtualizarLabels();
        }

        private void btnPais_Click(object sender, EventArgs e)
        {
            AbrirFormularioPais();
            AtualizarLabels();
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            AbrirFormularioDisciplinas();
            AtualizarLabels();
        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            AbrirFormularioTurmas();
            AtualizarLabels();
        }

        private void btnSalarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioSalarios();
            AtualizarLabels();
        }

        private void btnFaltas_Click(object sender, EventArgs e)
        {
            AbrirFormularioFaltas();
            AtualizarLabels();
        }

        private void btnInfoEscola_Click(object sender, EventArgs e)
        {
            AbrirFormularioInformacoesEscola();
            AtualizarLabels();
        }

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            AbrirFormularioTarifasMensais();
            AtualizarLabels();
        }

        private void AtualizarLabels()
        {
            // Carregar as informações da escola do arquivo JSON
            var informacoesEscola = GestorArquivos.CarregarDados<InformacoesEscola>("informacoesEscola.json") ?? new InformacoesEscola();

            // Atualizar o rótulo com o nome da escola
            lblNomeEscola.Text = informacoesEscola.Nome;
        }
    }
}
