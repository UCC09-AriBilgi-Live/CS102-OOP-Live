using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    internal class clsMongoDbManager : IDatabase
    {
        private string value; // sanki vt deki bir değer gibi algılayabiliriz

        private string userName = "mongo";
        private string password = "admin";
        public void addvalue(string value)
        {
            this.value = value;
            Console.WriteLine("MongoDB verisi eklendi....");
        }

        public void close()
        {
            Console.WriteLine("MongoDB başarılı şekilde sonlandı");
        }

        public void deletevalue()
        {
            this.value = null;

            Console.WriteLine("MongoDB verisi silindi....");

        }

        public void getvalue()
        {
            if (this.value != null) // demek içinde bir değer vardır
            {
                Console.WriteLine($"MongoDB üzerinden {this.value} bilgisi başarılı şekilde okundu....");

            }
            else
            {
                Console.WriteLine("MongoDB üzerinden herhangi bir veri okuyamadım....");

            }
        }

        public int login(string username, string password)
        {
            if (username == this.userName && password==this.password)
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

            Console.WriteLine("MongoDB üzerindeki bilgiler basarıyla güncellendi....");

        }
    }
}
