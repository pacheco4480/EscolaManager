namespace Biblioteca
{
    public class Alunos
    {
        #region Atributos
        private int id;
        private string nome;
        private string apelido;
        private string nomePai;
        private string apelidoPai;
        private string telemovel;
        private string genero;
        private DateOnly dataMatricula;
        private int paiID;
        private string email;
        private string morada;
        private int turmaID;
        private string escolaAnterior;
        private int mensalidadeID;
        private List<Disciplina> disciplinasInscritas = new List<Disciplina>();
        private string status;
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

        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }


        public string NomePai
        {
            get { return nomePai; }
            set { nomePai = value; }
        }

        public string ApelidoPai
        {
            get { return apelidoPai; }
            set { apelidoPai = value; }
        }

        public string Telemovel
        {
            get { return telemovel; }
            set { telemovel = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public DateOnly DataMatricula
        {
            get { return dataMatricula; }
            set { dataMatricula = value; }
        }

        public int PaiID
        {
            get { return paiID; }
            set { paiID = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        public int TurmaID
        {
            get { return turmaID; }
            set { turmaID = value; }
        }

        public string EscolaAnterior
        {
            get { return escolaAnterior; }
            set { escolaAnterior = value; }
        }

        public int MensalidadeID
        {
            get { return mensalidadeID; }
            set { mensalidadeID = value; }
        }

        public List<Disciplina> DisciplinasInscritas
        {
            get { return disciplinasInscritas; }
            set { disciplinasInscritas = value; }
        }


        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string NomeCompleto => $"{Nome} {Apelido}";


        #endregion
    }
}
