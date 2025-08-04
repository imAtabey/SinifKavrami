using System;
#region Sinif Kavrami
//-> Söz Dizimi
// [Erişim Belirleyici] class [Sınıf Adı]
// {
//    public [Sınıf Adı]
//    {
//      Constructor Komutları
//    }
//    [Erişim Belirleyici] [Veri Tipi] [Özellik Adı]
//    [Erişim Belirleyici] [Geri Dönüş Tipi] [Metotadı](Parametre Listesi)
//    {
//      Metot Komutları
//    }
// }

// Erişim Belirleyici
// Public -> Her yerden erişilebilir
// Private -> Tanımlandığı sınıf içerinde erişilebilir
// internal -> Kendi proje içerisinde erişilebilir
// Protected -> Tanımlandığı sınıf veya o sınıftan kalıtım alan sınıflarda

#endregion
#region Erisim Belirleyici ve Constructor
// Bir sınıfın nesnesi oluşturulunca arka planda çalışan metotlardır
// Mutlaka public olmalılar
// Geri dönüş tipleri yazılmaz
// Mutlaka ilgili sınıfla aynı isimde olmalıdır.
// Overload edilebilir.
#endregion

Console.WriteLine("*** Constructor'a parametre verilerek nesne oluşturma ***");
Calisan c1 = new Calisan("Ayşe","Kara",23415634,"İnsan Kaynakları");
c1.CalisanBilgileri();

Console.WriteLine("*** Parametresiz Constructor ile oluşturulan Nesne ***");
Calisan c2 = new Calisan();

c2.Ad = "Deniz";
c2.Soyad = "Arda";
c2.No = 25646789;
c2.Departman = "Satın Alma";
c2.CalisanBilgileri();

Console.WriteLine("*** Sadece Ad ve Soyad Parametresi olan Constructor ile Nesne Tanımlama");
Calisan c3 = new Calisan("Hüseyin", "ÜTEBAY");
c3.CalisanBilgileri();


class Calisan
{
    public string? Ad;
    public string? Soyad;
    public int No;
    public string? Departman;
    public Calisan()
    {

    }
    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }
    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı :{0}", Ad);
        Console.WriteLine("Çalışan Soyad :{0}", Soyad);
        Console.WriteLine("Çalışan No :{0}", No);
        Console.WriteLine("Çalışan Departman :{0}", Departman);
    }

}

