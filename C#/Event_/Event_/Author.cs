using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Event_
{
    class Author : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string firstName;
        private string lastName;
        private int experienceYear;

        public Author(string firstName, string lastName, int experienceYear)
        {
            FirstName = firstName;
            LastName = lastName;
            ExperienceYear = experienceYear;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public int ExperienceYear
        {
            get
            {
                return experienceYear;
            }
            set
            {
                experienceYear = value;
                OnPropertyChanged("Experience");
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
