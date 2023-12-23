using DesafioPOO.Models;

Nokia nokia = new Nokia(numero: "11111111111", imei: "22222222", modelo: "Nokia model 1", memoria: 64);
Nokia nokia2 = new Nokia(numero: "22222222", imei: "3333333333", modelo: "Nokia model 2", memoria: 128);

Iphone iphone = new Iphone(numero: "11111122222", imei: "222233333", modelo: "Iphone model 1", memoria: 64, cameraQuality:"32MP");

Iphone iphone2 = new Iphone(numero: "22222111111", imei: "333332222", modelo: "Iphone model 2", memoria: 128, cameraQuality: "48MP");


Console.WriteLine("----------- Nokia -----------");
Console.WriteLine($"Número: {nokia.Numero}");
Console.WriteLine($"Imei: {nokia.Imei}");
Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"Memoria: {nokia.Memoria}");

Console.WriteLine($"Changing nokia number: ");
nokia.Numero = "5555555555";
Console.WriteLine($"Novo número: {nokia.Numero}");

Console.WriteLine("----------- Nokia 2 -----------");
Console.WriteLine($"Número: {nokia2.Numero}");
Console.WriteLine($"Imei: {nokia2.Imei}");
Console.WriteLine($"Modelo: {nokia2.Modelo}");
Console.WriteLine($"Memória: {nokia2.Memoria}");

Console.WriteLine($"Changing nokia number: ");
nokia2.Numero = "666666666";
Console.WriteLine($"Novo número: {nokia2.Numero}");

Console.WriteLine("----------- Iphone -----------");
Console.WriteLine($"Número: {iphone.Numero}");
Console.WriteLine($"Imei: {iphone.Imei}");
Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"Memória: {iphone.Memoria}");
Console.WriteLine($"Qualidade da Camera: {iphone.CameraQuality}");

Console.WriteLine($"Changing nokia number: ");
iphone.Numero = "777777777";
Console.WriteLine($"Novo número: {iphone.Numero}");

Console.WriteLine("----------- Iphone 2-----------");
Console.WriteLine($"Número: {iphone2.Numero}");
Console.WriteLine($"Imei: {iphone2.Imei}");
Console.WriteLine($"Modelo: {iphone2.Modelo}");
Console.WriteLine($"Memória: {iphone2.Memoria}");
Console.WriteLine($"Qualidade da Camera: {iphone2.CameraQuality}");

Console.WriteLine($"Changing nokia number: ");
iphone2.Numero = "88888888888";
Console.WriteLine($"Novo número: {iphone2.Numero}");


iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Lorem Ipsum");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Lorem Ipsum 2");