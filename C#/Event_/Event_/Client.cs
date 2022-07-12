using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Event_
{
    class Client : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string phone;
        public event PropertyChangedEventHandler PropertyChanged;

        public Client(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public string Phone
        {
            get => phone;
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}:\t{LastName} {FirstName}";
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }


    }
}
