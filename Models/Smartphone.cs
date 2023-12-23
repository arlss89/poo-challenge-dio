using pooChallengeDioMain.Interfaces;

namespace DesafioPOO.Models
{
    public abstract class Smartphone : BaseEntity
    {
        public string Numero { get; set; }
        public string Modelo {get;private set;}
        public string Imei{get; private set;}
        public int Memoria {get;private set;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                throw new ArgumentException("Número do smartphone não pode ser nulo ou vazio.");
            }

            if (string.IsNullOrWhiteSpace(modelo))
            {
                throw new ArgumentException("Modelo do smartphone não pode ser nulo ou vazio.");
            }

            if (string.IsNullOrWhiteSpace(imei))
            {
                throw new ArgumentException("IMEI do smartphone não pode ser nulo ou vazio.");
            }

            if (memoria <= 0)
            {
                throw new ArgumentException("A memória do smartphone deve ser maior que zero.");
            }


            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
           _logger.WriteLine(this.getClassName() + ": " + "Ligando...");
        }

        public void ReceberLigacao()
        {
            _logger.WriteLine(this.getClassName() + ": " + "Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}