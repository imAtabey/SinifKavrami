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
#region Static Class ve Uyeler
// statik sınıfların nesnesi oluşturulamaz
// statik bir üyeye erişmek için direk sınıf adı ile erişilir.
// Bir Sınıf statik yapılırsa bütün elemanları statik yapılmalı
// Statik Sınıflar'a kalıtım uygulanamaz
// normal metotlar o sınıftan oluşturulan nesneler ile çalışırken statik metotlar heryerden erişilebilir.
// Erişim belirleyicileri yoktur.
// Static Constructor o sınıfa ilk erişildiğinde bir kere çalışır daha sonra hiç çalışmaz!
// Örnek olarak Calisanlar ve Islemler sınıfı kullanılmıştır.

#endregion
#region Struct(Yapı)
//Yapısı ile sınıflara benzerler.
// Tanımlama şekilleri aynıdır.
// Sınıflar referans türdür ama Structlar değer türlüdür. Stack'de tutulur
// Struct'lar nesne oluşturmadan da kullanılabilir.
// Class Dikdortgen ve struct Dikdortgen_Struct yapıları kullanıldı


#endregion


#region Constructor Örnekler
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

#endregion
#region Encapsulation Örnekleri
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

#endregion
#region Statik Sinif ve Uyeler Örnekleri
Console.WriteLine("Çalışan Sayısı :{0}", Calisanlar.CalisanSayisi); //static cons tetiklendi.

Calisanlar calisan1 = new Calisanlar("Ayşe", "Yılmaz", "İk Departmanı");
Console.WriteLine("Çalışan Sayısı :{0}", Calisanlar.CalisanSayisi);
Calisanlar calisan2 = new Calisanlar("Deniz", "Arda", "İk Departmanı");
Calisanlar calisan3 = new Calisanlar("Hüseyin", "ÜTEBAY", "İk Departmanı");

Console.WriteLine("Çalışan Sayısı :{0}", Calisanlar.CalisanSayisi);

// Islemler i1 = new Islemler(); bu islem hata verir sınıf static. isim ile erişilir
Console.WriteLine("Toplama İşlemi Sonucu :{0}", Islemler.Topla(100, 200));
Console.WriteLine("Çıkarma İşlemi Sonucu :{0}", Islemler.Cikar(400, 50));

#endregion
#region Struct Örnekleri
Dikdortgen d1 = new Dikdortgen();
d1.KisaKenar = 3;
d1.UzunKenar = 4;
Console.WriteLine("Class Alan Hesabı :{0}", d1.AlanHesapla());

Dikdortgen_Struct ds1; //new (nesne oluşturmadan) yapmadan ilgili elemanlara erişilebilir.
ds1.KisaKenar = 3;
ds1.UzunKenar = 4;
Console.WriteLine("Struct Alan Hesabı :{0}", ds1.AlanHesapla());
#endregion



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
class Calisanlar
{
    private static int _calisanSayisi;

    public static int CalisanSayisi { get => _calisanSayisi; }

    private string _isim;
    private string _soyisim;
    private string _departman;
    static Calisanlar()
    {
        _calisanSayisi = 0;
    }
    public Calisanlar(string isim, string soyisim, string departman)
    {
        this._isim = isim;
        this._soyisim = soyisim;
        this._departman = departman;
        _calisanSayisi++;
    }

}
static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static long Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}

class Dikdortgen
{
    public int KisaKenar;
    public int UzunKenar;
    public long AlanHesapla()
    {
        return KisaKenar * UzunKenar;
    }
}

struct Dikdortgen_Struct
{
    public int KisaKenar;
    public int UzunKenar;

    public long AlanHesapla()
    {
        return KisaKenar * UzunKenar;
    }
}
