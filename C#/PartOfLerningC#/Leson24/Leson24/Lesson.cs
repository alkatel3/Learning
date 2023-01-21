using System;


namespace Leson24
{
    class Lesson
    {
        public string Name { get; set; }
        public DateTime Begin { get; private set; }
        public event EventHandler<DateTime> Started;
        public Lesson(string name)
        {
            Name = name;
        }
        public void Start()
        {
            Begin = DateTime.Now;
            Started?.Invoke(this, Begin);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
