using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    internal interface IDatabase
    {
        // Bu Interface de sadece yol gösterici metot yapılarını içinde kod yazmadan tanımlıyoruz. Yani şablon/template oluşturmuş oluyoruz..

        int login(string username, string password); // db tarafına giriş yapan metot olacak

        void close(); // db bağlantısını kapatır.

        void addvalue(string value); // vt ye bir değer ekler

        void deletevalue(); // vt den bir değer siler

        void updatevalue(string value); // vt yi günceler

        void getvalue(); // vt yi okur





    }
}
