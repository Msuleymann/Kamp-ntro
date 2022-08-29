using Metotlar;

string urunAdi = "Elma";
double fiyati = 15;
string aciklama = "Amasya Elması";

string[] meyveler = new string[] { "Elma","karpuz" };

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbekir karpuzu";

Urun[] urunler = new Urun[] { urun1, urun2 };

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("--------------------");
    
}
Console.WriteLine("---------Metotlar--------");

//İnstance - Örnek
SepetManager sepetManager = new SepetManager();
sepetManager.ekle(urun1);
sepetManager.ekle(urun2);


sepetManager.Ekle2("Elma","Yeşil Armut",21,8);
sepetManager.Ekle2("karpuz", "Diyarbakır Karpuzu", 32,2);
sepetManager.Ekle2("kaysı", "Malatya kayısı", 12,5);