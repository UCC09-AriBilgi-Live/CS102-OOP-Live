using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Polymorphism
{
    internal class clsTutorials
    {
        protected int TutorialID;
        protected string TutorialName;
        protected string TutorialDescription;

        public void setTutorial(int pID, string pTutorialName) // 1.form
        {
            TutorialID = pID;
            TutorialName = pTutorialName;
        }

        public void setTutorial(string pTutorialName) // 2.form
        { 
            TutorialName = pTutorialName;
        }

        public void setTutorial(int pID, string pTutorialName,string pDesc) // 3.form
        {
            TutorialID = pID;
            TutorialName = pTutorialName;
            TutorialDescription = pDesc;
        }

        public string getTutorialName()
        {
            return TutorialID + " " + TutorialName;
        }
    }
}
