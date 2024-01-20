class Character
    {
        string Name { get; set; }
        int Level { get; set; }
        public Character(string name, int level)
        {
            Name = name;
            Level = level; 
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Level: {Level}");
        }
    }