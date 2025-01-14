namespace Biblioteca
{
    public class Pais
    {
        private int id;
        private string nome;
        private string apelido;
        private string genero;
        private string telemovel;
        private string email;
        private string morada;
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

        public string Telemovel
        {
            get { return telemovel; }
            set { telemovel = value; }
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

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        // Propriedade para obter o nome completo (Nome + Apelido)
        public string NomeCompleto => $"{Nome} {Apelido}";

        // Propriedade para obter o ID e o nome completo (ID + Nome + Apelido)
        public string IDNome => $"{ID} - {Nome} {Apelido}";

    }
}
