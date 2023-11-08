namespace _03_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsSubTutorials altsinif = new clsSubTutorials();

            altsinif.DersAdiBelirle(".Net Tutorials from Linkedin."); // çağırdığım bu metot alt sınıf içinde...

            Console.WriteLine(altsinif.getTutorialName()); // alt sınıf üzerinden üst sınıfın tanımlanmış bir metodunu kullanabiliyorum.(Kalıtımın nimetleri)

            Console.ReadKey();




        }
    }
}