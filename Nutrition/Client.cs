namespace Nutrition
{
    public class Client
    {
        public Client(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public string Name { get; } = string.Empty;
        public int Age { get; }
        float Weight { get; set; }
        float Height { get; set; }
        float IMC { get; set; }
        string Contact { get; set; } = String.Empty;
    }
}
