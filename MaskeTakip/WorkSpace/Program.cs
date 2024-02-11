// See https://aka.ms/new-console-template for more information






using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");
Console.ReadLine(); // hello world yazıldıktan sonra bir tuşa basmanızı bekler.
Console.WriteLine();

Citizen citizen1 = new Citizen(); // 1.vatandaşı oluşturmak ve classı kullanmak için bunu çağırmak gerekir.
citizen1.Name = "Fatih";
citizen1.SurName = "Bilgin";
citizen1.BirthYear = 1995;
citizen1.TcNO = 22233344405;

Person person1 = new Person();

pttManager pttmanager = new pttManager(new PersonManager());
pttmanager.GiveMask(person1);
// Diziler / Arrays
string[] ogrenciler = new string[2];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Fatih";
ogrenciler = new string[4];
ogrenciler[3] = "ilker";

for( int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i] );  
}

foreach (string ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}

List<string> yeniOgrenciler = new List<string> { "ahmet", "fatih", "kemal" };
// bu yeni array oluşturma şekli
yeniOgrenciler.Add("mahmut");
foreach (var ogrenci in yeniOgrenciler)
{
    Console.WriteLine(ogrenci);
}

SelamVer("Engin");
SelamVer("Fatih");
SelamVer();
int sonuç = Topla(3,5);
static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba" + isim);
}
static int Topla(int sayi1=0, int sayi2 = 0)
{
    int sonuç = sayi1 + sayi2;
    Console.WriteLine("Toplam"+sonuç);
    return sonuç;
}
public class Citizen
{
  
    public string Name { get; set; }   
    public string SurName { get; set; }
    public int BirthYear { get; set; }
    public long TcNO { get; set; }
}

