using System;

namespace Biblioteca
{
    public class InformacoesEscola
    {
        private string nome;
        private string morada;
        private int codigoAgrupamento;
        private int telemovel;
        private int telefone;
        private string website;
        private string email;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        public int CodigoAgrupamento
        {
            get { return codigoAgrupamento; }
            set { codigoAgrupamento = value; }
        }

        public int Telemovel
        {
            get { return telemovel; }
            set { telemovel = value; }
        }

        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Website
        {
            get { return website; }
            set { website = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
