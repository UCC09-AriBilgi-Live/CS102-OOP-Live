using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Encapsulation
{
    internal class clsBank
    {
        #region Normal durum

        public long AccountNumber; // hesap no
        public string Name;
        public int Balance; // Miktar

        public void getBalance() // Miktarı öğrenmek
        {
            Console.WriteLine("Hesaptaki miktar : {0} EURO dur",this.Balance);
        }

        public int getAmount() // Miktarı öğrenmek
        {
            return this.Balance;
        }
        public void setBalance(int balance)
        {
            this.Balance = this.Balance + balance;
        }

        public void setAmount(int balance)
        {
            this.Balance =  balance;
        }





        #endregion

        #region getterınız/setterınız
        private double balance; // Yani dışarıya normalde kapalı bir değişgen tanımı yapılmış

        // setter - getter metotlarının tanımlanması

        // public bir şekilde tanımlanan getter(get) metodu.
        // bu metod aslında balance değişgeninde tutulan değeri öğrenmek için
        public double getBalanceCaps()
        {
            // .. diyelim burada bir kodlar var...

            return balance;
        }

        // public bir şekilde tanımlanan getter(get) metodu.
        // bu metod aslında balance değişgeninin içeriğini güncelleme için
        public void setBalanceCaps(double balance)
        {
            // .. diyelim burada bir kodlar var...

            this.balance = balance; // o an oluşan balance değerini bu sınıf içersindeki değişgene yerleştir (this keyword ile)

        }

        #endregion

        #region Kurallara uymazsak

        public int Amount;

        public int GetAmount()
        {
            return Amount;
        }

        public void SetAmount(int Amount) // kendi set metodum.
        {
            if (Amount > 0)
            {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("Lütfen pozitif bir sayı girmelisiniz....");
            }


        }


        #endregion

        #region get/set olayı değişgenler/property lere de uygulunabilir ...işte bu durumda get/set keywordlerini kullabilirim

        private int _Amount1;

        // get/set keyword kullanımının eski yöntemi

        public int Amount1
        {
            get // içindeki değeri almak istersem _Amount1 in 
            {
                return _Amount1;
            }
            
            set  // içini doldurmak için de set
            { 
                if (value < 0)
                {
                    throw new Exception("Lütfen girdiğiniz miktara dikkat ediniz....Pozitif giriniz...");
                }
                else
                {
                    _Amount1 = value; // value olarak ne idüğü belirsiz o an
                }

            }
        }

        public int _Amount2 { get;  set; } // daha kısa bir yöntem



        #endregion




    }
}
