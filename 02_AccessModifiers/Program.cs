namespace _02_AccessModifiers
{
    #region Inline class

    public class User
    {
        protected internal string Name;
        protected internal string Location;
        protected internal int Age;

        void getUserDetails() 
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

            User user = new User();

            user.Name = "ÜK";
            user.Location = "Estonia";
            user.Age = 58;

            user.getUserDetails();
            Console.WriteLine("Lütfen bir tuşa basınız....");
            #endregion

            Console.ReadKey();
        }
    }
}