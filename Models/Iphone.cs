namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone:Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public Iphone(string numero, string modelo, string imei,int memoria) : base(numero, modelo, imei, memoria)
        {

        }
       
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Iniciando a Instalação do aplicativo {nomeApp} no seu Iphone");
        }
    }
}