using DesafioPOO.Models;

Dictionary<string, string> Aplicativos = new Dictionary<string, string>();
Aplicativos.Add("Avast", "Android Nokia");
Aplicativos.Add("Calculadora", "Android Iphone Nokia");
Aplicativos.Add("Documentos", "Android Iphone Nokia");
Aplicativos.Add("Lanterna", "Android Iphone");
Aplicativos.Add("Safari", "Iphone");
Aplicativos.Add("Zap Zap", "Android Iphone Nokia");

//CRIANDO AS REDES, DE FORMA QUE O APARELHO DE UMA PLATAFORMA POSSA LIGAR P OUTRA
Dictionary<string, Android> RedeA = new Dictionary<string, Android>();
Dictionary<string, Iphone> RedeI = new Dictionary<string, Iphone>();
Dictionary<string, Nokia> RedeN = new Dictionary<string, Nokia>();
// TODO: Realizar os testes com as classes Nokia e Iphone

RedeA.Add("11935491527", new Android("123456789", 4, "1A", "11935491527"));
RedeI.Add("21966074131", new Iphone("123456789", 4, "1I", "21966074131"));
RedeN.Add("31914506030", new Nokia("123456789", 4, "3N", "31914506030"));
RedeA.Add("11913131313", new Android("123456789", 4, "GS100", "11913131313"));

//PASSANDO AS REDES PARA UM APARELHO ESPECÍFICO. MAS PODE SER FEITA PRA TODOS
RedeA["11935491527"].RedeA = RedeA;
RedeA["11935491527"].RedeI = RedeI;
RedeA["11935491527"].RedeN = RedeN;

RedeA["11935491527"].Ligar("21966074131");
RedeN["31914506030"].InstalarAplicativo("Avast", Aplicativos);


/*
 foreach
 (KeyValuePair<string, Android> kvp in RedeA)
 {
   
    Console.WriteLine($"Android {kvp.Key} => {(kvp.Value.MeuNumero)}");
    kvp.Value.Ligar();
 }

Console.WriteLine();

 foreach
 (KeyValuePair<string, Iphone> kvp in RedeI)
 {
   
    Console.WriteLine($"Iphone {kvp.Key} => {(kvp.Value.MeuNumero)}");
 }

Console.WriteLine();

 foreach
 (KeyValuePair<string, Nokia> kvp in RedeN)
 {
   
    Console.WriteLine($"Nokia {kvp.Key} => {(kvp.Value.MeuNumero)}");
    kvp.Value.ReceberLigacao(RedeA["11971979759"].MeuNumero);
 }
*/