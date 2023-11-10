using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Abstraction
{
    // İşletme içerisinde beden işçisi statüsünde çalışan kişiler için EmployeManager isminde bir sınıf
    // oluşturarak bu sınıfı kalıtım yolu ile üst sınıfını clsEmployeeBaseManager seçerek gerekli kodları yazalım…

    internal class clsEmployeeManager : clsEmployeeBaseManager
    {
        // Constructor ...
        public clsEmployeeManager() 
        {
            // bu class/nesne ilk oluştuğunda default en taban Title tanımını oluşturmak için

            setTitle("Beden İşçisi");
        
        }
        public override void doRaise() // seyyanen zam
        {
            double salary= getSalary(); // maaşını bilmem lazım ki zam yapabileyim.

            double raise = salary + 500; // burası zamlı maaş olacak

            setSalary(raise); // Çalışanın yeni zamlı maaşı işlendi.

        }

        public override void doRaise(double prmRaiseRate) // zam + prim
        {
            double salary = getSalary(); // zam öncesi maaş

            double raise = salary + (salary * prmRaiseRate/100);

            setSalary(raise); //  // Yeni güncellenmiş maaş...

        }
    }
}
