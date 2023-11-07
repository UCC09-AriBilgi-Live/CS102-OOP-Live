using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AccessModifiers
{
    internal class clsBook
    {
        int BookID;
        string BookName;
        string Author;

        public void setBook(int prmBookID, string prmBookName,string prmAuthor)
        {
            BookID = prmBookID;
            BookName = prmBookName;
            Author = prmAuthor;

        }

        public string getBook()
        {
            string BookDefinition;

            BookDefinition= string.Empty;

            BookDefinition= "Book No : " + BookID.ToString() + " BookName : " + BookName + " Author : "+ Author;

            return BookDefinition;
        }

    }
}
