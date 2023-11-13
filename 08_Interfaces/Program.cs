namespace _08_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            clsDbManager database; // int a neyse tanım olarak clsDbManager tipinde database isimli değişgen

            Console.WriteLine("1-Oracle bağlantısı kur");
            Console.WriteLine("2-MySQL bağlantısı kur");
            Console.WriteLine("3-MongoDB bağlantısı kur");
            Console.WriteLine("Seçiminiz : ");
            option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    database = new clsDbManager(new clsOracleDbManager());
                    database.loginDB();
                    break;
                case 2 :
                    database = new clsDbManager(new clsMySQLDbManager());
                    database.loginDB();
                    break;
                case 3:
                    database = new clsDbManager(new clsMongoDbManager());
                    database.loginDB();
                    break;
                default:
                    break;
            }





        }
    }
}