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
#region Encapsulation ve Property Kavrami
// Nesnenin bazı özellik veya işlevlerini diğer class ve nesnelerden korumak için erişim belirleyiciler kullanılır
// Private belirlenmiş bir değere dışarıdan ulaşmak ve ilgili property ve field'a müdahale ederken private yapıyı bozmadan oluşturulan yöntemdir.
// Ogrenci sınıfı ile örneklendirildi.

#endregion

// -> Constructor Örneği [Parametreli]
Console.WriteLine("*** Constructor'a parametre verilerek nesne oluşturma ***");
Calisan c1 = new Calisan("Ayşe","Kara",23415634,"İnsan Kaynakları");
c1.CalisanBilgileri();
// -> Constructor Örneği 
Console.WriteLine("*** Parametresiz Constructor ile oluşturulan Nesne ***");
Calisan c2 = new Calisan();
c2.Ad = "Deniz";
c2.Soyad = "Arda";
c2.No = 25646789;
c2.Departman = "Satın Alma";
c2.CalisanBilgileri();
// -> Constructor Örneği [string ad,string soyad] parametreleri ile 
Console.WriteLine("*** Sadece Ad ve Soyad Parametresi olan Constructor ile Nesne Tanımlama");
Calisan c3 = new Calisan("Hüseyin", "ÜTEBAY");
c3.CalisanBilgileri();


//-> Encapsulation Örneği
Console.WriteLine("*** Encapsulation Örneği ***");
Ogrenci o1 = new Ogrenci();
o1.Isim = "Ayşe";
o1.Soyisim = "Yılmaz";
o1.OgrenciNo = 293;
o1.Sinif = 3;
o1.SinifAtlat();
o1.OgrenciBilgileriGetir();

Ogrenci o2 = new("Deniz", "Arda", 256, 1);
o2.SinifDusur();
o2.SinifDusur();
o2.OgrenciBilgileriGetir();


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
class Ogrenci
{
    private string _isim;
    private string _soyisim;
    private int _ogrenciNo;
    private int _sinif;

    public string Isim { get => _isim; set => _isim = value; }
    public string Soyisim { get => _soyisim; set => _soyisim = value; }
    public int OgrenciNo { get => _ogrenciNo; set => _ogrenciNo = value; }
    public int Sinif
    {
        get => _sinif;
        set
        {
            if (value <= 1)
            {
                Console.WriteLine("Sınıf en az bir olabilir");
                Sinif = 1;
            }
            else
                _sinif = value;
        }
    }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci()
    {

    }
    public void OgrenciBilgileriGetir()
    {
        Console.WriteLine("*** Öğrenci Bilgileri ***");
        Console.WriteLine("Öğrenci Adı :{0}", this.Isim);
        Console.WriteLine("Öğrenci Adı :{0}", this.Soyisim);
        Console.WriteLine("Öğrenci Adı :{0}", this.OgrenciNo);
        Console.WriteLine("Öğrenci Adı :{0}", this.Sinif);
    }
    public void SinifAtlat()
    {
        this.Sinif = this.Sinif +1;
    }
    public void SinifDusur()
    {
        this.Sinif = this.Sinif -1;
    }

}
