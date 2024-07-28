using DesafioPOO.Models;

Iphone iphone= new Iphone("61998165983", "Iphone 15", "1234567891012", 128);
Console.WriteLine("iPHONE");
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Nokia nokia= new Nokia("61998165983", "Nokia 2", "1234567891013", 128);
Console.WriteLine("NOKIA");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Duolingo");
