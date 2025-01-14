namespace Biblioteca
{
    public class Salarios
    {
        private int id;
        private double valor;
        private string nome;
        private string descricao;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
