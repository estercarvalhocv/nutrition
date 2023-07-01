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
        public double Weight { get; set; }
        public double Height { get; set; }
        public double IMC { get; set; }
        public string Contact { get; set; } = String.Empty;
    }
}
