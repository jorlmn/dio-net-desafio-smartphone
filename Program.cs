using DesafioPOO.Models;

// Teste com Nokia
Smartphone nokiaCell = new Nokia(numero: "123456", modelo: "nokiaA1", imei: "11111111", memoria: 64);
Console.WriteLine($"{nokiaCell.Modelo} {nokiaCell.Numero} {nokiaCell.IMEI} {nokiaCell.Memoria}");
nokiaCell.Ligar();
nokiaCell.InstalarAplicativo("Spotify");

Console.WriteLine("");

// Teste com Iphone
Smartphone iphoneCell = new Iphone(numero: "654321", modelo: "iphoneA1", imei: "222222", memoria: 64);
Console.WriteLine($"{iphoneCell.Modelo} {iphoneCell.Numero} {iphoneCell.IMEI} {iphoneCell.Memoria}");
iphoneCell.ReceberLigacao();
iphoneCell.InstalarAplicativo("Youtube");


