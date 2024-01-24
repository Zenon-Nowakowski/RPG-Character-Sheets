public class Character
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Char_Class { get; set; }
        public Character(string name, string level, string char_class)
        {
            Name = name;
            Level = level;
            Char_Class = char_class;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Level: {Level}, Class: {Char_Class}");
        }
    }