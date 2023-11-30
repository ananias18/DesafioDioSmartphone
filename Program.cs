using DesafioPOO.Models;



// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3210", imei: "123456789012345", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "123456", modelo: "iPhone 3210", imei: "123456789012345", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

