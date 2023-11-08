namespace _05_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programci prg1 = new Programci();
            //Programci prg2 = new Programci(23, "Ziya");
            //Programci prg3 = new Programci(27, "Kamuran", "Kamiloğlu");
            //Programci prg4 = new Programci(30, "Hayrettin", "Kütükçü", "C#");


            //prg1.showOzellikler();
            //prg2.showOzellikler();
            //prg3.showOzellikler();
            //prg4.showOzellikler();

            urun urun = new urun();
            urun.Ad = "Televizyon";
            urun.AlisFiyat = 500;
            urun.Miktar = 5;
            urun.SatisFiyat = urun.AlisFiyat * 2;
            urun.Kar = (urun.SatisFiyat - urun.AlisFiyat) * urun.Miktar;

            Console.WriteLine($"Ürün Adı : {urun.Ad}");
            Console.WriteLine($"Ürün Alış Fiyatı : {urun.AlisFiyat} TL.");
            Console.WriteLine($"Ürün Satış Fiyatı : {urun.SatisFiyat} TL.");
            Console.WriteLine($"Miktar : {urun.Miktar} adet");
            Console.WriteLine($"Karınız : {urun.Kar} TL.dir.Allah bereket versin...");

            Console.ReadKey();
        }
    }

    #region Sample 1
    //class Programci
    //{
    //    int yasi;
    //    string adi;
    //    string soyadi;
    //    string kullandigiDil;

    //    // Hic parametre almayan bir yapılandırıcı..(constructor)
    //    public Programci()
    //    {
    //        this.adi = null;
    //        this.yasi = 0;
    //        this.soyadi = null;
    //        this.kullandigiDil = null;
    //    }

    //    // İsmini ve yasini alan bir yapılandırıcı..
    //    public Programci(int yasi, string adi)
    //    {
    //        this.adi = adi;
    //        this.yasi = yasi;

    //        this.soyadi = null;
    //        this.kullandigiDil = null;
    //    }

    //    // İsmini, soyismini ve yasini alan bir yapılandırıcı..
    //    public Programci(int yasi, string adi, string soyadi)
    //    {
    //        this.adi = adi;
    //        this.yasi = yasi;
    //        this.soyadi = soyadi;
    //        this.kullandigiDil = null;
    //    }

    //    // İsmini, soyismini kullandığı dili ve yasini alan bir yapılandırıcı..
    //    public Programci(int yasi, string adi, string soyadi, string kullandigiDil)
    //    {
    //        this.adi = adi;
    //        this.yasi = yasi;
    //        this.soyadi = soyadi;
    //        this.kullandigiDil = kullandigiDil;
    //    }

    //    public void showOzellikler()
    //    {
    //        if (this.yasi != 0)
    //            Console.WriteLine("Yasi : " + this.yasi);
    //        else Console.WriteLine("Yasi bilgisi elimizde yok şu anda...");

    //        if (this.adi != null)
    //            Console.WriteLine("Adı : " + this.adi);
    //        else Console.WriteLine("Adi bilgisi elimizde yok şu anda...");

    //        if (this.soyadi != null)
    //            Console.WriteLine("Soyadı : " + this.soyadi);
    //        else Console.WriteLine("Soyadı bilgisi elimizde yok şu anda...");

    //        if (this.kullandigiDil != null)
    //            Console.WriteLine("Kullandığı Programlama dili : " + this.kullandigiDil);
    //        else Console.WriteLine("Hangi Dili kullanığını bilmiyoruz be... :-(\n");
    //    }
    //}

    #endregion

    #region Sample 2

    class urun
    {
        string ad;
        public urun()  //Kurucu metot
        {
            ad = "";
            grupNo = 0;
            miktar = 0;
            alisFiyat = 0;
            kar = 0;
        }

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        int grupNo;

        public int GrupNo
        {
            get { return grupNo; }
            set { grupNo = value; }
        }
        
        int miktar;
        public int Miktar
        {
            get { return miktar; }
            set { miktar = value; }
        }

        int alisFiyat;
        public int AlisFiyat
        {
            get { return alisFiyat; }
            set { alisFiyat = value; }
        }

        int satisFiyat;
        public int SatisFiyat
        {
            get { return satisFiyat; }
            set { satisFiyat = value; }
        }

        int kar;
        public int Kar
        {
            get { return kar; }
            set { kar = value; }
        }



    }

    #endregion
}

