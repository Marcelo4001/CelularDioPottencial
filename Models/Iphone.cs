namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public string Sistema = "Iphone";
        public string MeuNumero { get; set;}
        public Iphone(string imei, int memoria, string modelo, string numero) : base(imei, memoria, modelo, numero)
        {
            MeuNumero = numero;
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp, Dictionary<string, string> apps)
        {
            if
            (apps.ContainsKey(nomeApp))
            {
                Console.WriteLine($"Instalando o aplicativo {nomeApp}");
            }
            else
            {

                Console.WriteLine($"APLICATIVOS DISPONÍVEIS PARA {Sistema.ToUpper()}");

                foreach
                (KeyValuePair<string, string> kvp in apps)
                {
                    List<string> plataformas = new List<string>(kvp.Value.Split(" "));
                    if
                    (plataformas.Contains(Sistema))
                    {
                        Console.WriteLine(kvp.Key);
                    }
                }
            }
        }
    }
}