using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    internal class clsOracleDbManager : IDatabase
    {
        private string value; // sanki vt deki bir değer gibi algılayabiliriz

        private string userName = "oracle";
        private string password = "admin";
        public void addvalue(string value)
        {
            this.value = value;
        }

        public void close()
        {
            Console.WriteLine("OracleDB başarılı şekilde sonlandı");
        }

        public void deletevalue()
        {
            this.value = null;

            Console.WriteLine("OracleDB verisi silindi....");

        }

        public void getvalue()
        {
            if (this.value != null) // demek içinde bir değer vardır
            {
                Console.WriteLine($"OracleDB üzerinden {this.value} bilgisi başarılı şekilde okundu....");

            }
            else
            {
                Console.WriteLine("OracleDB üzerinden herhangi bir veri okuyamadım....");

            }
        }

        public int login(string username, string password)
        {
            if (username == this.userName && password == this.password)
            {
                return 1; // true
            }
            else
            {
                return 0; // false
            }
        }

        public void updatevalue(string value)
        {
            this.value = value;

            Console.WriteLine("OracleDB üzerindeki bilgiler basarıyla güncellendi....");

        }
    }
}
