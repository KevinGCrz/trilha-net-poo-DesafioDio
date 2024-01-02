namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        protected string Modelo;

        protected int IMEI;

        protected int Memoria;

        public Smartphone(string numero, string Modelo, int IMEI, int Memoria)
        {
            Numero = numero;
            Modelo = Modelo;
            IMEI = IMEI;
            Memoria = Memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        
    }
}