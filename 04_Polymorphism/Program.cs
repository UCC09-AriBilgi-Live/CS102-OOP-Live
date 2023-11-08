namespace _04_Polymorphism
{
    // Personel örneği
    internal class Staff
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int WorkDays { get; set; }
        public decimal DailyWage { get; set; }

        public virtual decimal Salary
        {
            get
            {
                return WorkDays * DailyWage;
            }
        }
    }

    internal class Worker : Staff
    {
        public  override decimal Salary
        {
            get
            {
                return DailyWage * WorkDays * 3;
            }
        }
    }

    internal class Manager : Staff
    {
        public override decimal Salary
        {
            get
            {
                return DailyWage * WorkDays * 5;
            }
        }
    }

    internal class Intern : Staff
    {
        public override decimal Salary
        {
            get
            {
                return DailyWage * WorkDays * 2;
            }
        }
    }

    // Animal örneği
    internal class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public int Age { get; set; }
        public virtual string MakeNoise()
        {
            return "Animal";
        }
    }
    internal class Cat : Animal
    {
        public string StayInside()
        {
            return "I'm staying inside. Meoww!";
        }
        public override string MakeNoise()
        {
            return "Meoww!";
        }
    }
    internal class Dog : Animal
    {
        public string GoOutside()
        {
            return "I'm going to outside. Woof!";
        }
        public override string MakeNoise()
        {
            return "Woof!";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //clsTutorials tutorials = new clsTutorials();    // nesne yaratıldı

            //tutorials.setTutorial(1, "C# eğitimi");

            //Console.WriteLine(tutorials.getTutorialName());

            //tutorials.setTutorial("SQL Server eğitimi");
            //Console.WriteLine(tutorials.getTutorialName());

            //tutorials.setTutorial(3, "HTML/CSS/JS eğitimi", "Allahemi cihan eğitimi herbişi var...");
            //Console.WriteLine(tutorials.getTutorialName());

            //Dog dog1 = new Dog();
            //Console.WriteLine(dog1.MakeNoise());

            //Cat cat1 = new Cat();
            //Console.WriteLine(cat1.MakeNoise());

            //Staff staff = new Staff();
            //staff.Name = "Biff";
            //staff.Lastname = "Tannen";
            //staff.DailyWage = 10;
            //staff.WorkDays = 20;

            //Worker worker = new Worker();
            //worker.Name = "Marty";
            //worker.Lastname = "McFly";
            //worker.DailyWage = 10;
            //worker.WorkDays = 20;

            //Manager manager = new Manager();
            //manager.Name = "Emmett";
            //manager.Lastname = "Brown";
            //manager.DailyWage = 10;
            //manager.WorkDays = 20;

            //Intern intern = new Intern();
            //intern.Name = "Lorraine";
            //intern.Lastname = "Baines";
            //intern.DailyWage = 10;
            //intern.WorkDays = 20;

            //Console.WriteLine("Staff: " + staff.Name + " " + staff.Lastname + " Salary: " + staff.Salary);
            //Console.WriteLine("Staff: " + worker.Name + " " + worker.Lastname + " Salary: " + worker.Salary);
            //Console.WriteLine("Staff: " + manager.Name + " " + manager.Lastname + " Salary: " + manager.Salary);
            //Console.WriteLine("Staff: " + intern.Name + " " + intern.Lastname + " Salary " + intern.Salary); 

    // Nightly Workout 01

    // Çember,Kare,Dikdörtgen için bir alan hesaplama programı yazılacaktır
    // Herbir nesne için hesaplamayı yapacak gerekli  bilgiler atandıktan sonra hesaplama işlemleri ayrı ayrı yapılıp ekrana basılacaktır...

            // öncelikle bir taban(base) class yaratarak işe başlanabilir (Hesaplama isminde)

            // işte bu base classdan Cember,Kare,Dikdortgen sub-classları inherit edin(kalıtın..ki ayrı ayrı aynı tanımlanmış metodu kullanabilin.)

            // Bazı kabuller yapın.Yani initial değerler verin. Yani constructor yaratın.

            // alan hesapları yaparken birden fazla nesne olduğu için metodlarınızda override yaparak kullanın


            // Daily Workout 02


                    Console.ReadKey();

        }
    }
}