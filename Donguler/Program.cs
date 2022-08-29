string kurs1 = "yazılım geliştirici";
string kurs2 = "python ögrenme kursu";
string kurs3 = "java ögrenme kursu ";
string kurs4 = "c#";
Console.WriteLine(kurs1);
Console.WriteLine(kurs2);
Console.WriteLine(kurs3);
Console.WriteLine(kurs4);
//dizi
string[] kurslar = new string [] { "yazılım geliştirici",
    "python ögrenme kursu" ,
    "java ögrenme kursu ",
    "c#"
};

for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("For Bitti He");
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("Sayfa Sonu -Footer");