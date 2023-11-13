namespace _07_Abstraction
{
    internal class Program
    {   
        // Basit bir örnek üzerinde işleyecek olursak; bir işletmemiz ve bu işletmeye bağlı çalışanlarımızın
        // bilgilerinin yer alacağı, çeşitli işlemlere imkan verecek bir sınıfımız ve bu sınıfa özelliklerin atanmasını
        // sağlayacağımız bir abstract class oluşturarak gerekli bilgilerini çıktısını kullanıcıya iletmek isteyelim.
        //
        // Bu örnek için uygulanacak aşamalar;

        // 1. Çalışan bilgilerinin tutulacağı base konumunda bir abstract class oluşturmak gerektiğinden dolayı
        // clsEmployeeBaseManager isminde bir abstract sınıf oluşturalım. ok
        //
        // 2. Çalışanların bilgilerinin saklanacağı çeşitli değişkenler ve bu bilgilere göre çeşitli işlemler
        // yapılmasının sağlanacağı bazı metot tanımlamaları gerçekleştirelim.
        //
        // 3. Her çalışan kişinin zam oranı, yıllık izni gibi kavramlar çalışanın statüsüne, deneyimine bağlı
        // değişeceği için abstract metot olarak bazı metotların da tanımlanması gerekmektedir.
        // Tanımlamalar gerçekleştirdikten sonra clsEmployeeBaseManager sınıfının içeriğini inceleyelim:

        static void Main(string[] args)
        {
            // Öncelikle bir Beden İşçisi oluşturalım

            clsCreateEmployeeManager bodyworker = new clsCreateEmployeeManager(); // nesneyi yarattım.

            //bodyworker.employeeBaseManager= new clsEmployeeManager();

            bodyworker.Create();

            bodyworker.getInfo();


            // bir mühendis için

            clsCreateEmployeeManager engineer = new clsCreateEmployeeManager();

            engineer.employeeBaseManager = new clsEngineerManager(); // Mühendisler için

            engineer.Create();

            engineer.getInfo();

            Console.ReadKey();

        }
    }
}