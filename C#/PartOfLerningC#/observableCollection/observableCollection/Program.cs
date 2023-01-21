using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace observableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new ObservableCollection<User>
           {
               new User(){Name="Oleg"},
               new User(){Name="Semen"},
               new User(){Name="Taras"}
           };
            users.CollectionChanged += Users_CollectionChanged;
            users.Add(new User { Name = "Sofiya" });
            users.RemoveAt(1);
            users[0] = new User { Name = "Natasha" };
            foreach(var user in users)
            {
                Console.WriteLine(user.Name);
            }
            Console.ReadKey();
        }
        private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    User newUser= e.NewItems[0] as User;
                    Console.WriteLine("Added new element " + newUser.Name);
                    break;

                case NotifyCollectionChangedAction.Remove:
                    User oldUser = e.OldItems[0] as User;
                    Console.WriteLine("Removed element " + oldUser.Name);
                    break;
                case NotifyCollectionChangedAction.Replace:
                    User replacedUser = e.OldItems[0] as User;
                    User replacindUser = e.NewItems[0] as User;
                    Console.WriteLine(replacedUser.Name + " replace into " + replacindUser.Name); ;
                    break;
              
            }
        }
    }
    class User
    {
        public string Name { get; set; }
    }
}
