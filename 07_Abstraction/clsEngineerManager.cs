using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Abstraction
{
    internal class clsEngineerManager : clsEmployeeBaseManager
    {

        public clsEngineerManager() 
        {
            setTitle("Müyendis");
        }
        public override void doRaise()
        {
            double salary = getSalary(); // maaşını bilmem lazım ki zam yapabileyim.

            double raise = salary + 2500; // burası zamlı maaş olacak

            setSalary(raise);
        }

        public override void doRaise(double prmRaiseRate)
        {
            double salary = getSalary(); // zam öncesi maaş

            double raise = salary + (salary * prmRaiseRate / 100) + (salary * 2);

            setSalary(raise); //  yeni maas set edilecek...
        }
    }
}
