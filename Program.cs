using trilha_net_poo_desafio.Models;

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("123", "1198797979", "Modelo 1", 32);
nokia.InstalarAplicativo("Whatassp");
nokia.Ligar();


Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone("123", "198799444", "Modelo 2", 16);
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();
