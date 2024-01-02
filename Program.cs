using DesafioPOO.Models;

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"123123", Modelo:"NokiaG11", IMEI:011011, Memoria:32);

nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone (numero:"789789", Modelo:"iPhone12", IMEI:121212, Memoria:64);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Amazon Store");

Console.WriteLine("--------------------------------------------------");