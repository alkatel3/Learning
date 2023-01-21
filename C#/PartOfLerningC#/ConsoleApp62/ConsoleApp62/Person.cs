using System;


namespace ConsoleApp62
{
    class Person
    {
        public event Action GoToSleep;
        public event EventHandler DoWork;
        public string Name { get; set; }
        public void TakeTime (DateTime now)
        {
            if (now.Hour <= 8)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                
                DoWork?.Invoke(this,null);
            }
        }
    }
}
