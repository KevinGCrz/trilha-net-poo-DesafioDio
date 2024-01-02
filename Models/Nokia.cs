namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string Modelo, int IMEI, int Memoria) : base(numero, Modelo, IMEI, Memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} para seu Nokia!");
        }
    }
}