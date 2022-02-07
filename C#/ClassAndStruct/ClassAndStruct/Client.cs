using System;
using System.Threading;
namespace Learning
{
    /*Описать структуру Client содержащую поля: код
      клиента; ФИО; адрес; телефон; количество заказов 
      осуществленных клиентом; общая сумма заказов 
      клиента*/
    /*Описать перечисление ClientType определяющее 
      важность клиента, и добавить соответствующее поле 
      в структуру Client из задания №2.*/
    enum ClientType
    {
        AboveNormal,
        BelowNormal,
        Highest,
        Lowest,
        Normal
    };
    

    struct Client
    {
        static int Number = -1;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        string MiddleName;
        string Country;
        string City;
        string Street;
        string NumberOfHouse;
        string NumberOfPhone;
        int СountOrders;
        double GlobalSumOfOrders;
        ClientType clientType;
        

        public Client(string firstName, string lastName, string middleName,ClientType clientType)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Country = "";
            City = "";
            Street = "";
            NumberOfHouse = "";
            NumberOfPhone = "";
            СountOrders = 0;
            GlobalSumOfOrders = 0;
            Number++;
            this.clientType = clientType;
        }

        public Client(string firstName, string lastName, string middleName, 
            string country, string city, string sreet, string numberOfHouse, ClientType clientType) : this(firstName, lastName, middleName, clientType)
        {
            Country = country;
            City = city;
            Street = sreet;
            NumberOfHouse = numberOfHouse;
            
        }

        public Client(string firstName, string lastName, string middleName,
            string country, string city, string sreet,string numberOfHouse,
            string numberOfPhone, ClientType clientType) : this(firstName,  lastName, middleName,
            country,  city, sreet, numberOfHouse, clientType)
        {
            NumberOfPhone = numberOfPhone;
        }

        public void Rename(string newFirstName, string newLastName, string newMiddleName)
        {
            Console.WriteLine($"Rename {this}\n" +
                $"Last full name:\t{LastName} {FirstName} {MiddleName}\n" +
                $"New full name:\t{newFirstName} {newLastName} {newMiddleName}");
            FirstName = newFirstName;
            LastName = newLastName;
            MiddleName = newMiddleName;
        }
        public void SetAdress(string newCountry, string newCity, string newStreet, string newNumberOfHouse)
        {
            Console.WriteLine($"Change adress {this}\n" +
                $"Last full adress:\t{Country}, {City}, {Street}, {NumberOfHouse}\n" +
                $"New full adress:\t{newCountry}, {newCity}, {newStreet}, {newNumberOfHouse}");
            Country = newCountry;
            City = newCity;
            Street = newStreet;
            NumberOfHouse = newNumberOfHouse;
        }
        public void SetNumberOfPhone(string newNumberOfPhone)
        {
            Console.WriteLine($"Change number of phone {this}\n" +
                $"Last number: \t{NumberOfPhone}\n" +
                $"New number: \t{newNumberOfPhone}\n");
            NumberOfPhone = newNumberOfPhone;
        }
        public void BuySomeProduct(double Sum)
        {
            СountOrders++;
            GlobalSumOfOrders += Sum;
        }
        public void GetInformation()
        {
            Console.WriteLine($"Client:\t {this}\n" +
                $"{Number}. {LastName} {FirstName} {MiddleName}\n" +
                $"Adress:\t{Country}, {City}, {Street}, {NumberOfHouse}" +
                $"Phone:\t{NumberOfPhone}" +
                $"Count of Order:\t{СountOrders}" +
                $"Global sum of orders:\t{GlobalSumOfOrders}");
        }
    }
}
