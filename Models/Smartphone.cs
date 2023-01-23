namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        protected string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria  { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        
        public Smartphone(string numero,string modelo, string imei)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }
        public Smartphone(int memoria)
        {
            Memoria = memoria;
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