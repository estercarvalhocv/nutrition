namespace Nutrition
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int option;

            Console.WriteLine("----- Nutrition Client -----");
            Console.WriteLine("1 - Add a new Client");
            Console.WriteLine("2 - Edit a Client");
            Console.WriteLine("3 - Remove a Cliente");
            Console.WriteLine("Choose a option: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
    }
}
