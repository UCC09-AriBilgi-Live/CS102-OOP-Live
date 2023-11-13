using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Abstraction
{
    internal abstract class clsEmployeeBaseManager
    {
        // Çalışanlar için temel bilgilerin tutulacağı değişgen tanımlamalar

        private string Name, surName, title; // Özlük bilgileri
        private double salary; // maaş bilgisi
        private int annualLeave; // Yıllık izin

        // Çalışan kişilerin bilgilerini yazdıracağımız metotlar

        public void getInfo()
        {
            if (annualLeave > 0) 
            {
                // eğer çalışan herhangi bir şekilde oluşturulmadıysa bir uyarı verelim
                Console.WriteLine($"Abstract Company Employee\n\nİsim : {Name}\nSoyisim : {surName}\nÜnvan : {title}\nMaaşı : {salary} PNG Kina\nYıllık izin : {annualLeave}\n\n ");

            }
            else
            {
                Console.WriteLine("Çalışan kaydı bulunamadı...");
            }
        }

        // Çalışan kişilerin bilgilerini set edeceğimiz metot

        public void setInfo(string pName,string pSurName,double pSalary)
        {
            if (pName.Length >= 3 && pSurName.Length >=2) // isim boyut kontro
            {
                if (pSalary >= 8500)
                {
                    this.Name = pName;
                    this.surName= pSurName;
                    this.salary = pSalary;

                    if (pSalary >=8500 && pSalary <=12000)
                    {
                        this.title = "Deneyimli " + title;
                        this.annualLeave = 20;
                    }
                    else if (pSalary > 12001 && pSalary <= 15000)
                    {
                        this.title = "Kıdemli " + title;
                        this.annualLeave = 24;
                    }
                    else if (pSalary >15001)
                    {
                        this.title = "Uzman " + title;
                        this.annualLeave = 30;
                    }
                    else
                    {
                        this.annualLeave = 14;
                    }

                }
                else
                {
                    Console.WriteLine("ERROR : çalışanınızın maaşını kontrol ediniz..En az 8500 Kina almalıdır. O yüzden çalışan kaydı oluşturulamamıştır....");
                }
            }
            else
            {
                Console.WriteLine("ERROR : çalışanınızın isim/soyisim uzunluğu gerekli kriterleri sağlamıyor...Kontrol ediniz..");

            }
        }

        // Maaş bilgilerine erişim sağlacak Getter/Setter metotları

        public double getSalary()
        {
            return salary;
        }

        public void setSalary(double pSalary)
        {
            this.salary= pSalary;
        }

        // Ünvan bilgilerine erişimi sağlayacak olan getter/setter metotları
        public void setTitle(string pTitle)
        {
            this.title = pTitle;
        }

        // Her nesne için Özel Zam seçenekleri olabileceği için Abstract Metotlar tanımlanıyor + polymorphism tekniği uygulanıyor.

        public abstract void doRaise(); // düz zam metotu
        public abstract void doRaise(double prmRaiseRate); // zam + prim
    }
}
