using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance
{
    internal class clsSubTutorials : clsTutorials
    {
        // Alt sınıf durumunda olan clsSubTutorials da olmayan bir metodu-daha önceden yazılmış ama farklı bir sınıfın içinde bulunan- kullanabilmek için.
        // : li bir gösterimle bu sınıfıma clsTutorials sınıfımı klonladım.

        public void DersAdiBelirle(string pNewName)
        {
            TutorialName = pNewName;
        }


    }
}
