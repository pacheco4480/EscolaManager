namespace Biblioteca
{
    public class Faltas
    {
        #region Atributos
        private int id;
        private int alunoID;
        private int disciplinaID;
        private DateTime dataFalta;
        private string motivo;
        private string alunoNome;
        private string disciplinaNome;
        #endregion

        #region Propriedades
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int AlunoID
        {
            get { return alunoID; }
            set { alunoID = value; }
        }

        public int DisciplinaID
        {
            get { return disciplinaID; }
            set { disciplinaID = value; }
        }

        public DateTime DataFalta
        {
            get { return dataFalta; }
            set { dataFalta = value; }
        }

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        public string AlunoNome
        {
            get { return alunoNome; }
            set { alunoNome = value; }
        }

        public string DisciplinaNome
        {
            get { return disciplinaNome; }
            set { disciplinaNome = value; }
        }

        #endregion
    }
}
