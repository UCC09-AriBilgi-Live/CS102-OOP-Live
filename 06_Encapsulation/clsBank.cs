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


    }
}
