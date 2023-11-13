using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    internal class clsDbManager
    {
        private IDatabase database;
        public clsDbManager() // default constructor
        { 

        } 

        public clsDbManager(IDatabase database) // parametrik constructor...Ben buraya db classının kendisini göndercem
        {
            this.database = database; // O anki gelen db parametresine göre (Oracle,Mongo,Mysql..) içsel database değişgenimi belirliyorum.
        }

        public void loginDB() // db ye giriş
        {
            string userName, password;

            Console.WriteLine("< Veri tabanı bağlantısı >\n\n-> Kullanıcı Adı : "  );
            userName = Console.ReadLine();

            Console.WriteLine("-> Kullanıcı Şifre : ");
            password = Console.ReadLine();

            if (database.login(userName,password) == 1)
            {
                menu();

            }
            else
            {
                Console.WriteLine("Bağlantı bilgilerinde bir terslik var.Kontrol lütfen...."  );
            }

        }

        public void closeDB() 
        { 
        database.close();
        }

        public void addValue(string value) 
        {
            database.addvalue(value);
        }

        public void deleteValue() 
        {
            database.deletevalue();
        }

        public void updateValue(string value) 
        { 
        database.updatevalue(value);
        }

        public void getValue()
        {
            database.getvalue();
        }

        private void menu()
        {
            string value;

            int option; // işlem kodu 

            Console.WriteLine("Veri tabanı işlemleri \n");
            Console.WriteLine("1-Veri ekle\n\n2-Veri Sil\n\n3-Veri getir\n\n4-Bağlantıyı Kes\n\n");

            Console.WriteLine("İşlem kodu ? : ");

            option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    addValue("A");
                    //Console.Clear();
                    menu();  // menuyu tekrar çağırıyor...
                    break;
                case 2:
                    deleteValue();
                    //Console.Clear();
                    menu();
                    break;
                case 3:
                    getValue();
                    //Console.Clear();
                    menu();
                    break;
                case 4:
                    closeDB();
                    //Console.Clear();
                    //menu();
                    break;
                default:
                    break;
            }





        }



    }
}
