using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AccessModifiers
{
    internal class clsTutorial
    {
        // bu sınıfta bir eğitim seti var...Bu eğitimin bir kodu var bir de tanımı var

        int TutorialID;
        string TutorialName;

        // bu değerleri güncelleyecek bir metot yazmak istiyorum
        public void setTutorial(int prmTutorialID, string prmTutorialName)
        {
            TutorialID = prmTutorialID;
            TutorialName = prmTutorialName;
        }

        public string getTutorialName()
        {
            User user = new User();

            
            

            return TutorialName;
        }


    }
}
