using System;
using System.Threading;
using System.IO;


namespace PracticeThread_
{
    public class Bank
    {
        private int money { get; set; }
        private string name { get; set; }
        private int percent { get; set; }

        public Bank(int money, string name, int percent)
        {
            Money = money;
            Name = name;
            Percent = percent;
        }

        public int Money 
        { 
            get => money; 
            set 
            {
                money = value;
                ThreadStart threadStart = new ThreadStart(WriteToFile);
                Thread thread = new Thread(threadStart);
                thread.Start();
            }
        }
        public string Name
        {
            get 
            {
                return name;
            }
            set
            {
                name = value;
                ThreadStart threadStart = new ThreadStart(WriteToFile);
                Thread thread = new Thread(threadStart);
                thread.Start();
            }
        }
        public int Percent
        {
            get
            {
                return Percent;
            }
            set
            {
                percent = value;
                ThreadStart threadStart = new ThreadStart(WriteToFile);
                Thread thread = new Thread(threadStart);
                thread.Start();
            }
        }
        private void WriteToFile()
        {
            using (FileStream stream = new FileStream("C:/Users/Dell/OneDrive/Рабочий стол/Info.txt", FileMode.Append,FileAccess.Write,FileShare.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(this);
                }
            }
        }
        
        public override string ToString()
        {
            return $"Money = {money}\tName = {name}\tPercent = {percent}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(100000, "PryvatBank", 3);
            for (int i = 100001; i <= 100010; i++)
            {
                bank.Money = i;
                bank.Percent = i - 100000;
            }
        }
        
    }
}
