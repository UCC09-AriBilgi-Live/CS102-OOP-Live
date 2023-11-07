using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AccessModifiers
{
    internal class clsIslem
    {
        public double sayi1, sayi2, sonuc;

        public char islem;

        public void setSonuc()
        {
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;

                case '-':
                    sonuc = sayi1 - sayi2;
                    break;

                case '*':
                    sonuc = sayi1 * sayi2;
                    break;

                case '/':

                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz işlem...Verileri kontrol ediniz..."  );
                        sonuc = 0;
                    }

                    break;
                default:
                    break;
            }
        }

        public double getSonuc()
        {
            return sonuc; 
        }


    }
}
