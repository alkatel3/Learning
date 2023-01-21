using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace UsingSerialize
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; } = "Jack";
        public int Age { get; set; }
        int _identNumber;
        public DateTime DateBirth { get; set; }

        public Person(string name, DateTime dateBirth)
        {
            Name = name;
            DateBirth = dateBirth;
        }

        [NonSerialized]
        const string Planet = "Earth";

        public Person()
        {
        }

        public Person(int identNumber,string name, int age, DateTime dateBirth )
        {
            DateBirth = dateBirth;
            Name = name;
            Age = age;
            _identNumber = identNumber;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Date of Birth: {DateBirth} Age:c{Age}, Identification number: {_identNumber}, Planet: {Planet}.";
        }
        [OnSerializing]
        private void OnSerializing(StreamContent content)
        {
            Name = Name.ToUpper();
            DateBirth = DateBirth.ToUniversalTime();
        }
        [OnDeserialized]
        private void OnDeserialized(StreamContent content)
        {
            Name = Name.ToLower();
            DateBirth = DateBirth.ToLocalTime();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path1 = "test.bin";
            string path2 = "test.xml";
            //BinarySerialize(path1);
            XMLSerialize(path2);
            XMLSerializeList(path2);
            ShowUsingMethodWithAtrebuns(path2);

        }


        //This method doesn't work with last two methods of class Person!!! Why???

        //public static void BinarySerialize(string path)
        //{
        //    Person person = new(346875, "Jack", 34, new(1995,5,11));
        //    BinaryFormatter binFormat=new BinaryFormatter();
        //    try
        //    {
        //        using (Stream fStream = File.Create(path))
        //        {
        //            binFormat.Serialize(fStream, person);
        //        }
        //        Console.WriteLine("BinarySerialize OK!");

        //        Person? p = null;
        //        using (Stream fStream = File.OpenRead(path)) {
        //            p = (Person)binFormat.Deserialize(fStream);
        //        }
        //        Console.WriteLine(p+"\n");
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}       

        public static void XMLSerialize(string path)
        {
            Person person = new(346875, "Jack", 34,new(1995,5,11));
            XmlSerializer xmlSerializer= new XmlSerializer(typeof(Person));
            try
            {
                using(Stream fStream = File.Create(path))
                {
                    xmlSerializer.Serialize(fStream, person);
                }
                Console.WriteLine("XmlSerialise OK!");

                Person? p = null;
                using(Stream fStream = File.OpenRead(path))
                {
                    p = (Person?)xmlSerializer.Deserialize(fStream);
                }
                Console.WriteLine(p+"\n");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void XMLSerializeList(string path)
        {
            List<Person> Persons = new List<Person>()
            {
                new Person(346875, "Jack", 34, new(1995, 5, 11)),
                new Person(975648, "Bob", 37,new(1990,8,2)),
                new Person(870312, "John", 23,new(2002,09,08))
            };
            XmlSerializer xmlSerializer=new(typeof(List<Person>));
            try
            {
                using(Stream fstream = File.Create(path))
                {
                    xmlSerializer.Serialize(fstream, Persons);
                }
                Console.WriteLine("XMLSerialize OK!");

                List<Person>? list = null;
                using(Stream stream = File.OpenRead(path))
                {
                    list =(List<Person>?) xmlSerializer.Deserialize(stream);
                }
                foreach(Person p in list)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void ShowUsingMethodWithAtrebuns(string path)
        {
            Person person = new("Jack", new DateTime(1995, 11, 5));
            XmlSerializer XmlFormat = new(typeof(Person));

            try
            {
                using(Stream ftream= File.Create(path))
                {
                    XmlFormat.Serialize(ftream, person);
                }
                Console.WriteLine("XmlSerialize OK");

                Person? p = null;

                using (Stream fstrem = File.OpenRead(path))
                {
                    p = (Person?) XmlFormat.Deserialize(fstrem);
                }
                Console.WriteLine(p+"\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
    }

}