using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Abstraction
{    
    // Abstract yapısını daha doğru bir şekilde kullanmak ve programı daha esnek bir hale getirebilmek için
    // clsCreateEmployeeManager isminde ekleme işlemlerinin yönetileceği genel bir sınıf tanımlaması gerçekleştirelim
    // ve gerekli tanımlamaları oluşturalım…

    // Burası elemanı yoktan varedecek...Personel listesi oluşturma gibi

    internal class clsCreateEmployeeManager
    {
        public clsCreateEmployeeManager employeeBaseManager; // classın değişgen olarak kullanılması
        private string name, surName;
        private double salary;


        public void Create()
        {
            Console.WriteLine("<Ceate Employee Manager>\n\n-> Çalışanın İsmi :");
            name = Console.ReadLine();

            Console.WriteLine("-> Çalışanın Soyismi :");
            surName = Console.ReadLine();

            Console.WriteLine("-> Çalışanın Maaşı : ");
            salary = Convert.ToInt32(Console.ReadLine());

            employeeBaseManager.setInfo(name, surName, salary);
        }

        public void getInfo()
        {
            employeeBaseManager.getInfo();
        }

        public void doRaise()
        {
            employeeBaseManager.doRaise(); // Normal çalışan için zam metodunu çağırıyoruz.

            Console.WriteLine($"<Zam uygulandı>\n\n-> Yeni Maaş : {employeeBaseManager.getSalary()} PNG Kina\n\n");
        }

        public void doRaise(double pRaiseRate)
        {
            employeeBaseManager.doRaise(pRaiseRate);

            Console.WriteLine($"<Primli Zam uygulandı>\n\n-> Yeni Maaş : {employeeBaseManager.getSalary()} PNG Kina\n\n");


        }
    }
}
