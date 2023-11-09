using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Abstraction
{
    // işletme içersinde "Beden İşçisi" statusundeki kişiler için  böyle bir sınıf oluşturuyorum ve Base class dan kendime kalıtıyorum..ve bu sınıf için gereken kodları yazıyor.
    internal class clsEmployeeManager : clsEmployeeBaseManager
    {
        // Constructor ...
        public clsEmployeeManager() 
        {
            // bu sınıf "clsEmployeeManager" ilk yaratıldığı anda default bazı tanımlamalar yapabilmek için...
            setTitle("Beden İşçisi");
        
        }
        public override void doRaise() // seyyanen zam
        {
            double salary= getSalary(); // maaşını bilmem lazım ki zam yapabileyim.

            double raise = salary + 500; // burası zamlı maaş olacak

            setSalary(raise);

        }

        public override void doRaise(double prmRaiseRate) // zam + prim
        {
            double salary = getSalary(); // zam öncesi maaş

            double raise = salary + (salary * prmRaiseRate/100);

            setSalary(raise); //  yeni maas set edilecek...

        }
    }
}
