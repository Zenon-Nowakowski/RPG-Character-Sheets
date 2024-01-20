public class Character
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public Character(string name, string level)
        {
            Name = name;
            Level = level; 
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Level: {Level}");
        }
    }