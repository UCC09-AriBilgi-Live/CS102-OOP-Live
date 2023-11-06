using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes
{
    internal class clsPersonel
    {
        // Öncelikle sınıfımın içinde kullanacağım değişgenleri/fields tanımlamaları

        // Sınıfın kimliğini hazırladık bir anlamda...
        public int PersonelID; // dışa açık personel no
        public string Ad; // dışa açık personelin adı
        public string Soyad; // dışa açık personelin soyadı
        public string Unvan;
        public byte Yas;
        public int Maas;
        public int IzinGunu;

        // Sınıfın kendi içsel metotları olabilir. Dışardan da erişilebilir...eğer hak verilirse.
        
        // bir metot yazılacak bunun da görevi tanımlaması yapılan personelin tüm bilgilerini döken bir metot
        public string getPersonelBilgi()
        {
            if (Unvan != null)
                return $"Personel Oluşturuldu...Bilgileri şunlardır..\n\n-> Personel Ad {Ad}\n-> Personel Soyad {Soyad}\n-> Personel Maaş {Maas} PNG Kina\n->Personel Ünvan {Unvan}\n-> Personel İzin Günü {IzinGunu}\n\n";
            else
                return "Personel Oluşturulamadı...Kontrol ediniz..";

        }
        public void setPersonelBilgi(string pAd,string pSoyad,int pMaas)
        {
            // Adı,soyadı,maas bilgisi verilen personelin ünvan ve izin günü ataması yapan bir metot...



            // öncelikle değerlerim düzgün geliyormu...kontrolu
            // düzgünse eğer
            // Maas bilgisi 10000 PNG Kina dan yüksekse demekki bu kişiye izin günü ve bir ünvan atayacak bu sınıf/metot
            // Kurallar:
            // - Maas 10000-14000(dahil) PNG Kina bu kişi Ünvan:Kıdemli Personel-İzin günü: 20 gün izin günü tanımlansın
            // - Maas 14001-15500(dahil) PNG Kina bu kişi Kıdemli+ Personel-İzin günü 24 gün izin günü tanımlansın
            // - Maas >15500(dahil) PNG Kina bu kişi Uzman Personel-İzin günü 30 gün izin günü tanımlansın
            // eğer hiçbiri uymuyorsa bildiğin Junior...tatil matil yok...
            // eğer maas bilgisi yoksa hata mesajı versin


            // öncelikle ad,soyad gelmişmi kontrolu yaparak işe başlayabiliriz.

            if (pAd.Length >0 && pSoyad.Length >0) // ad ve soyad dolu gelmiştir.
            {
                // maaş bilgisini de kriterlere göre kontrolü.
                if(pMaas >= 10000)
                {
                    // şimdi ilk önce benim sınıfımın alanlarının initial değerlerini belirleyeyim

                    this.Ad = pAd;
                    this.Soyad = pSoyad;
                    this.Maas= pMaas;
                    this.IzinGunu = 14; // default değer verdim daha sonra duruma göre değişebilecek.

                    if (pMaas >=10000 && pMaas <=14000)
                    {
                        this.Unvan = "Kıdemli Personel";
                        this.IzinGunu = 20;
                    }
                    else if (pMaas > 14001 && pMaas <= 15500)
                    {
                        this.Unvan = "Kıdemli+ Personel";
                        this.IzinGunu = 24;
                    }
                    else if (pMaas >15501)
                        {
                        this.Unvan = "Uzman Personel";
                        this.IzinGunu = 30;
                    }
                    else
                    {
                        this.Unvan = "Bildiğin Junior";
                    }

                    }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nPersonel Oluşturulamadı...\n\nİşletmede bir personelin en az 10000 PNG kina alması lazımdır...\n");
                }
                }
            }
        }




}
