using System;


namespace Serialization
{
    [Serializable]
    class Group
    {
        [NonSerialized]
        private readonly Random rnd = new Random(DateTime.Now.Millisecond);

        public int Number { get; set; }

        public string Name { get; set; }

        public Group()
        {
            Number = rnd.Next(1, 10);
            Name = "Группа " + rnd;
        }

        public Group(int number, string name)

        {
            // Проверка вводных данных 

            Number = number;
            Name = name;


        }

        public override string ToString()
        {
            return Name;
        }
          
    }
}
