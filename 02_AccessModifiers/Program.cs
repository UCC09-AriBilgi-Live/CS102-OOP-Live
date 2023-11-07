namespace _02_AccessModifiers
{
    #region Inline class

    public class User
    {
        protected internal string Name;
        protected internal string Location;
        protected internal int Age;

        public void getUserDetails() 
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Location : {Location}");
            Console.WriteLine($"Age : {Age}");
        }
    }



    #endregion



    internal class Program
    {
        static void Main(string[] args)
        {
            #region public
            // Örneğimizde bir Tutorial bilgilerinin bulunağı bir örnek. ve bunu ayrı bir sınıf dosyası içinde tutacağım.

            //clsTutorial tutorial = new clsTutorial();

            //tutorial.setTutorial(1, "C# Eğitimi");

            //Console.WriteLine(tutorial.getTutorialName()); // set etmiş olduğum değerleri okuyacağım(get)


            #endregion


            #region Private
            // Örneğimizde bir Student bilgilerinin bulunağı bir örnek. ve bunu ayrı bir sınıf dosyası içinde tutacağım.
            //clsStudent student = new clsStudent();

            ////Console.WriteLine("Name : " + student.Name);

            //student.getName();

            #endregion

            #region Inline

            //User user = new User();

            //user.Name = "ÜK";
            //user.Location = "Estonia";
            //user.Age = 58;

            //user.getUserDetails();
            //Console.WriteLine("Lütfen bir tuşa basınız....");
            //#endregion

            //#region protected
            //clsMovies movies = new clsMovies();

            //Console.WriteLine(  "Movie Name : {0}",movies.movieName);

            #endregion

            #region Another sample
            // Bir bookstoreumuz var.burada kitapların nosu, adı, yazarı tutulacaktır. ve ekrandan giriş alınarak sanki bir bookdb oluşturulacaktır. ve istendiği zaman kitap listesi öğrenilebilecektir.
            // Not : 3 kitap için mesela yapılabilir

            // cr(console.readline)(3 satır)--> 1.kitap--> kitap1
            // nesne yaratılacak
            // nesneye ekrandan alınan bilgiler gömülecek

            // cr(console.readline)(3 satır)--> 2.kitap--> kitap2
            // nesne yaratılacak
            // nesneye ekrandan alınan bilgiler gömülecek(set)

            // 5 kitap bittikten sonra get ilede herbir kitabın veri içeriği cw yapılabilir...
            int BID;
            string BName;
            string BAuthor;

            Console.Clear();

            #region Kitap1
            // 1.kitap için...
            Console.Write("Book ID : ");
            BID= Convert.ToInt32(Console.ReadLine());

            Console.Write("Book Name : ");
            BName = Console.ReadLine();

            Console.Write("Book Author : ");
            BAuthor = Console.ReadLine();

            clsBook book1= new clsBook(); // nesne oluşturuldu
            book1.setBook(BID, BName, BAuthor);
            #endregion

            #region Kitap2
            // 2.kitap için...
            Console.Write("Book ID : ");
            BID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Book Name : ");
            BName = Console.ReadLine();

            Console.Write("Book Author : ");
            BAuthor = Console.ReadLine();

            clsBook book2 = new clsBook(); // nesne oluşturuldu
            book2.setBook(BID, BName, BAuthor);
            #endregion

            #region Kitap3
            // 3.kitap için...
            Console.Write("Book ID : ");
            BID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Book Name : ");
            BName = Console.ReadLine();

            Console.Write("Book Author : ");
            BAuthor = Console.ReadLine();

            clsBook book3 = new clsBook(); // nesne oluşturuldu
            book3.setBook(BID, BName, BAuthor);
            #endregion

            // ekrana bastırma kısmı

            Console.WriteLine(book1.getBook() + "\n\n");
            Console.WriteLine(book2.getBook() + "\n\n");
            Console.WriteLine(book3.getBook() + "\n\n");
            #endregion

            Console.ReadKey();
        }
    }
}