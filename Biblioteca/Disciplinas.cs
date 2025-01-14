namespace Biblioteca
{
    public class Disciplina
    {
        private int id;
        private string nome;
        private double creditos;

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

        public double Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
    }
}
