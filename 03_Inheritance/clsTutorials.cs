using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Inheritance
{
    internal class clsTutorials
    {
        protected int TutorialID;
        protected string TutorialName;

        public void setTutorial(int pID,string pTutorialName)
        {
            TutorialID = pID;
            TutorialName = pTutorialName;
        }

        public string getTutorialName()
        {
            return TutorialName;
        }

    }
}
