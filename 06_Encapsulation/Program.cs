namespace _06_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Normal Durum

            //clsBank bank = new clsBank();

            //bank.AccountNumber = 1234567890123;
            //bank.Name = "Santander Bank";
            //bank.Balance = 500; // elden yatırdım

            //bank.getBalance();

            //bank.setBalance(1000); // bir yerlerden geldi

            //bank.getBalance();

            #endregion


            #region get/set olayı

            //clsBank bankgs = new clsBank();

            //bankgs.setBalanceCaps(500); // set ediyorum.

            //Console.WriteLine($"Hesabınızdaki miktar : {bankgs.getBalanceCaps()} EURO dur..."); // get ediyorum.


            #endregion

            #region Eğer sınıfımızı tasarlarken Kapsülleme(encapsulation) prensibine uymazsak ne olur?
            // açıklamalar gelecek

            //clsBank bank2= new clsBank();

            //bank2.Balance = 1000;

            //Console.WriteLine($"Bankadaki miktarınız {bank2.Balance} PNG Kina'dır...\n\n"  );

            //bank2.Balance = -5000;

            //Console.WriteLine($"Bankadaki miktarınız {bank2.Balance} PNG Kina'dır...\n\n");

            // Yukardaki kısım pek istenen bir durum değil.çünküm miktara negatif bir değer girebliyorum...Hata...

            //try
            //{
            //    int deger;

            //    clsBank bank3 = new clsBank();

            //    Console.WriteLine("Lütfen miktarı giriniz : ");
            //    deger=Convert.ToInt32(Console.ReadLine());

            //    bank3.SetAmount(deger);

            //    Console.WriteLine($"\n\n Düzgün durum\n\nBankanızdaki miktar : {bank3.GetAmount()} PNG Kinadır\n\n");

            //    Console.WriteLine("Lütfen yeni miktarı giriniz : ");
            //    deger = Convert.ToInt32(Console.ReadLine());


            //    bank3.SetAmount(deger); // eğer negatif bir sayı girersem set edemeycek geriye hata gelecek ve dolayısıyla catch e düşecek

            //    Console.WriteLine($"\n\nBankanızdaki miktar : {bank3.GetAmount()} PNG Kinadır\n\n");

            //}
            //catch (Exception hata)
            //{

            //    Console.WriteLine(hata.Message);
            //}


            #endregion

            #region get/set olayı değişgenler/property lere de uygulunabilir ...işte bu durumda get/set keywordlerini kullabilirim

            //try
            //{
            //    clsBank bank4 = new clsBank();

            //    bank4.Amount1 = 1000; // hemen geri planda otomatikman set metodunu çalıştırır

            //    Console.WriteLine("Miktar : {0}\n\n",bank4.Amount1  ); // get metodu devreye girecek

            //    bank4.Amount1 = -5000;
            //    Console.WriteLine("Miktar : {0}\n\n", bank4.Amount1); // get metodu devreye girecek


            //}
            //catch (Exception hata)
            //{
            //    Console.WriteLine(  hata.Message);

            //}

            try
            {
                clsBank bank5 = new clsBank();

                bank5._Amount2 = 1000;

                Console.WriteLine($"Miktar : {bank5._Amount2}\n\n"); // direkt olarak değişgenik kendisine ulasabiliyorum.

                bank5._Amount2 = -1000;

                Console.WriteLine($"Miktar : {bank5._Amount2}\n\n"); // direkt olarak değişgenik kendisine ulasabiliyorum.
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen pozitif sayı girin dedik lo...");
            }


            #endregion

        }
    }
}