namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Dictionary<string, Android> RedeA = new Dictionary<string, Android>();
        public Dictionary<string, Iphone> RedeI = new Dictionary<string, Iphone>();
        public Dictionary<string, Nokia> RedeN = new Dictionary<string, Nokia>();
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Imei { get; set; }
        protected int Memoria { get; set; }
        protected string Modelo { get; set; }

        public Smartphone(string imei, int memoria, string modelo, string numero)
        {
            Imei = imei;
            Memoria = memoria;
            Numero = numero;
            Modelo = modelo;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar(string destino)
        {
            if
            (destino != Numero)
            {
                Console.WriteLine($"Ligando para {destino}");
                if
                (RedeA.ContainsKey(destino))
                {
                    RedeA[destino].ReceberLigacao(Numero);
                }
                else if
                (RedeI.ContainsKey(destino))
                {
                    RedeI[destino].ReceberLigacao(Numero);
                }
                else if
                (RedeN.ContainsKey(destino))
                {
                    RedeN[destino].ReceberLigacao(Numero);
                }
                else
                {
                    Console.WriteLine($"Não foi possível efetuar a ligação para {destino}");
                    Console.WriteLine("Tente mais tarde!...");
                }
            }
            else
            {
                Console.WriteLine("Não é possível ligar para seu próprio número");
            }
        }

        public void ReceberLigacao(string chamador)
        {
            Console.WriteLine($"Recebendo ligação de {chamador}...");
        }

        public abstract void InstalarAplicativo(string nomeApp, Dictionary<string, string> apps);
    }
}