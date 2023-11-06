namespace _01_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sınıflar nerelerde oluşturulabilir?

            // - namespace içinde
            // - namespace dışında
            // - ayrı bir class dosyası içinde (*)


            #endregion

            #region Personel Örneği
            // Personel kayıt sistemi
            // Yapı olarak sınıf oluşturuyoruz. Ve ayrı bir dosyada olacak şekilde.. "clsPersonel" sınıfımızın ismi olacak.
            
            // Nesne tanımlama yapıyorum

            clsPersonel nur = new clsPersonel();
            clsPersonel ahmet= new clsPersonel();
            clsPersonel cekdar= new clsPersonel();
            clsPersonel oyku = new clsPersonel();
            clsPersonel tarik = new clsPersonel();
            clsPersonel umut= new clsPersonel();
            clsPersonel ayca= new clsPersonel();
            clsPersonel hazal = new clsPersonel();
            clsPersonel yusuf= new clsPersonel();
            clsPersonel eyup= new clsPersonel();
            clsPersonel umit = new clsPersonel();

            // dummy pers bilgiler

            int maasilk = 1000;
            int maasson = 20000;

            nur.setPersonelBilgi("Nur Sena", "ÖZTÜRK", new Random().Next(maasilk, maasson));
            ahmet.setPersonelBilgi("Ahmet", "GÖKÇAY", new Random().Next(maasilk, maasson));
            oyku.setPersonelBilgi("Nisa Öykü", "YURDAGÜL", new Random().Next(maasilk, maasson));
            tarik.setPersonelBilgi("Tarık Ziya", "KOCABOY", new Random().Next(maasilk, maasson));
            umut.setPersonelBilgi("Umut", "KUTLU", new Random().Next(maasilk, maasson));
            ayca.setPersonelBilgi("Emine Ayça", "BAŞARAN", new Random().Next(maasilk, maasson));
            hazal.setPersonelBilgi("Hazal", "ATIŞ", new Random().Next(maasilk, maasson));
            yusuf.setPersonelBilgi("M.Yusuf", "KÜSER", new Random().Next(maasilk, maasson));
            eyup.setPersonelBilgi("Eyüp Yasin", "İPEK", new Random().Next(maasilk, maasson));
            umit.setPersonelBilgi("Ümit", "KARAÇİVİ", new Random().Next(maasilk, maasson));

            Console.WriteLine(nur.getPersonelBilgi());
            Console.WriteLine(ahmet.getPersonelBilgi());
            Console.WriteLine(oyku.getPersonelBilgi());
            Console.WriteLine(tarik.getPersonelBilgi());
            Console.WriteLine(umut.getPersonelBilgi());
            Console.WriteLine(ayca.getPersonelBilgi());
            Console.WriteLine(hazal.getPersonelBilgi());
            Console.WriteLine(yusuf.getPersonelBilgi());
            Console.WriteLine(eyup.getPersonelBilgi());
            Console.WriteLine(umit.getPersonelBilgi());

            #endregion

            #region Öğrenci-Sınıf-Not-GeçtiKaldı
            // yani bir classım olacak
            // öğrenci tanımlanabilecek-ad-soyad-sınıf-not1-not2
            //(ekrandan 5 öğrencinin gerekli bilgeleri ekrandan alınabiir. tekbir öğrencinin bilgileri girildikten sonra hesaplama-mesaj verme halledilir 2. öğrenciye geçilebilir.Not hesaplama bilgileri doldurma class tarafında halledilebir get/set metotları gibi..
            // öğrencinin GK durumu cw yapılacak %60(2.sınav) %40(1.sınav) kuralı uygulanabilir...geçme notu 65 olsun
            // Daily WO (InClass)
            #endregion

            Console.ReadKey();


        }
    }
}