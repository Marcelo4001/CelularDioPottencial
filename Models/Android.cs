namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Android : Smartphone
    {
       public string Sistema = "Android";
       public string MeuNumero { get; set;}
       //public string Sistema { get; set;}
        public Android(string imei, int memoria, string modelo, string numero) : base(imei, memoria, modelo, numero)
        {
            MeuNumero = numero;
            //Sistema = sistema;
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