using Nutrition;

class Program
{
    public static void Main(string[] args)
    {
        int option;
        List<Client> clients = new List<Client>();
        Client client;

        PrintMenu();
        option = Convert.ToInt32(Console.ReadLine());

        while (option != 0)
        {
            switch (option)
            {
                case 1:
                    client = AddNewClient();
                    clients.Add(client);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    ListClients(clients);
                    break;
            }
            PrintMenu();
            option = Convert.ToInt32(Console.ReadLine());
        }
    }

    public static Client AddNewClient()
    {
        string name = string.Empty;
        int age;
        double weight;
        double height;
        double imc;
        string contact = string.Empty;

        Console.WriteLine("**** Adding new client:");
        Console.Write("Name: ");
        name = Console.ReadLine();

        Console.Write("Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Client client = new Client(name, age);

        Console.Write("Weight: ");
        weight = Convert.ToDouble(Console.ReadLine());
        client.Weight = weight;

        Console.Write("Height: ");
        height = Convert.ToDouble(Console.ReadLine());
        client.Height = height;

        Console.Write("IMC: ");
        imc = Convert.ToDouble(Console.ReadLine());
        client.IMC = imc;

        Console.Write("Contact: ");
        contact = Console.ReadLine();
        client.Contact = contact;

        return client;
    }

    public static void ListClients(List<Client> clients)
    {
        foreach(Client client in clients)
        {
            Console.WriteLine(client.Name);
        }
    }

    public static void PrintMenu()
    {
        Console.WriteLine("----- Nutrition Client -----");
        Console.WriteLine("1 - Add a new Client");
        Console.WriteLine("2 - Edit a Client");
        Console.WriteLine("3 - Remove a Client");
        Console.WriteLine("4 - List Clients");
        Console.WriteLine("0 - Exit the Program");
        Console.Write("Choose a option: ");
    }
}
