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

        public void setBalance(int balance)
        {
            this.Balance = this.Balance + balance;
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


    }
}
