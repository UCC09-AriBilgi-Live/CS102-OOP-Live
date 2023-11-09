namespace _06_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Normal Durum

            clsBank bank = new clsBank();

            bank.AccountNumber = 1234567890123;
            bank.Name = "Santander Bank";
            bank.Balance = 500; // elden yatırdım

            bank.getBalance();

            bank.setBalance(1000); // bir yerlerden geldi

            bank.getBalance();

            #endregion


            #region get/set olayı



            #endregion
        }
    }
}