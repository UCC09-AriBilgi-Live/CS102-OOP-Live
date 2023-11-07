namespace _02_AccessModifiers
{
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
            clsStudent student = new clsStudent();

            //Console.WriteLine("Name : " + student.Name);

            student.getName();



            #endregion

            Console.ReadKey();
        }
    }
}