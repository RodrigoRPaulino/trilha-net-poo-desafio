
using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Iphone");
Iphone iphone = new Iphone(numero:"2",modelo:"A",imei:"1",memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");


Console.WriteLine("________________________________________________________________________________________________________________________");

Console.WriteLine("Nokia");
Nokia nokia = new Nokia(numero:"2",modelo:"B",imei:"2",memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
