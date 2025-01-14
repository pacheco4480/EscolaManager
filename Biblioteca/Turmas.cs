namespace Biblioteca
{
    public class Turma
    {
        #region Atributos
        private int id;
        private string nome;
        private string ano;
        private string periodo;
        private string status;
        private List<int> alunosIDs = new List<int>();
        #endregion

        #region Propriedades
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public List<int> AlunosIDs
        {
            get { return alunosIDs; }
            set { alunosIDs = value; }
        }

        public int QuantidadeAlunosInscritos
        {
            get { return alunosIDs.Count; }
        }
        #endregion
    }
}
