namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        
        // Sobrescreve o método "InstalarAplicativo" da classe Smartphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o APP " + nomeApp);
        }
    }
}