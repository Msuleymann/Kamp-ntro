string adi = "Süleyman";
int yas = 15;

Kurs kurs1 = new Kurs() ;
kurs1.kursAdi = "c#";
kurs1.Egitmen = "Süleyman Kahraman";
kurs1.IzlenmeOranı = 25;

Kurs kurs2 = new Kurs();
kurs2.kursAdi = "python";
kurs2.Egitmen = "AngloSakson";
kurs2.IzlenmeOranı = 61;

Kurs kurs3 = new Kurs();
kurs3.kursAdi = "c++";
kurs3.Egitmen = "Peynirekmek";
kurs3.IzlenmeOranı = 27;

Kurs kurs4 = new Kurs();
kurs3.kursAdi = "javascript";
kurs3.Egitmen = "patato";
kurs3.IzlenmeOranı = 21;

Kurs[] kurslar = new Kurs[]
{
    kurs1,kurs2,kurs3,kurs4
};
Kurs[] _ = new Kurs[] { kurs1, kurs2,kurs3,kurs4 };
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.kursAdi + "" , "" + kurs.Egitmen);
}


class Kurs
{
    public string kursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOranı { get; set; }
}