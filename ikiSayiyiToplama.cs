using System;
class HelloWorld {
  static void Main() {
    Console.Write("Birinci Sayıyı Giriniz: ");
    int sayi1 = int.Parse(Console.ReadLine());
    
    Console.Write("İkinci Sayıyı Giriniz: ");
    int sayi2 = int.Parse(Console.ReadLine());
    
    int sonuc = sayi1 + sayi2;
    Console.WriteLine($"İki Sayının Toplamı: {sonuc}");
  }
}
