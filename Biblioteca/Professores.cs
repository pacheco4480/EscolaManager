namespace Biblioteca
{
    public class Professores
    {
        private int id;
        private string nome;
        private string apelido;
        private string genero;
        private DateOnly dataEntrada;
        private string email;
        private string morada;
        private string telefone;
        private int salarioID;
        private List<Disciplina> disciplinasLecionadas = new List<Disciplina>();
        private string status;

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

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public DateOnly DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
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

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public int SalarioID
        {
            get { return salarioID; }
            set { salarioID = value; }
        }

        public List<Disciplina> DisciplinasLecionadas
        {
            get { return disciplinasLecionadas; }
            set { disciplinasLecionadas = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
