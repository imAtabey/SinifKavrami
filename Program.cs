using System;
#region Sınıf Kavramı
// Söz Dizimi
// [Erişim Belirleyici] class [Sınıf Adı]
// {
//    [Erişim Belirleyici] [Veri Tipi] [Özellik Adı]
//    [Erişim Belirleyici] [Geri Dönüş Tipi] [Metotadı](Parametre Listesi)
//    {
//Metot Komutları
//    }
// }

// Erişim Belirleyici
// Public -> Her yerden erişilebilir
// Private -> Tanımlandığı sınıf içerinde erişilebilir
// internal -> Kendi proje içerisinde erişilebilir
// Protected -> Tanımlandığı sınıf veya o sınıftan kalıtım alan sınıflarda

Calisan c1 = new Calisan();
c1.Ad = "Ayşe";
c1.Soyad = "Kara";
c1.No = 23415634;
c1.Departman = "İnsan Kaynakları";
c1.CalisanBilgileri();

Calisan c2 = new Calisan();

c2.Ad = "Deniz";
c2.Soyad = "Arda";
c2.No = 25646789;
c2.Departman = "Satın Alma";

c2.CalisanBilgileri();



class Calisan
{
    public string? Ad;
    public string? Soyad;
    public int No;
    public string? Departman;
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı :{0}", Ad);
        Console.WriteLine("Çalışan Soyad :{0}", Soyad);
        Console.WriteLine("Çalışan No :{0}", No);
        Console.WriteLine("Çalışan Departman :{0}", Departman);
    }

}

#endregion
