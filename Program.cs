using DesafioPOO.Models;

Iphone iphone = new Iphone("+55(11)99999-9999", "Iphone 15", "000000-00-000000-0", 512);
Nokia nokia = new Nokia("+55(11)99898-9898", "Nokia C100", "111111-11-111111-1", 32);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Apple Maps");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Google Maps");