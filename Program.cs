using DesafioPOO.Models;

Nokia nokia = new Nokia("123456", "Nokia 3310", "111111111111111", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine();

Iphone iphone = new Iphone("654321", "iPhone 14", "222222222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");