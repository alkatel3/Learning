using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace UsingInterfaceISerializable
{
    [Serializable]
    public class Person:ISerializable
    {
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public Person() { }

        private Person(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("PersonName").ToUpper();
            DateBirth = info.GetDateTime("DateBirth").ToUniversalTime();
        }
        
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("PersonName", Name.ToLower());
            info.AddValue("DateBirth", DateBirth.ToLocalTime());
        }
        public override string ToString()
        {
            return $"Name: {Name}," +
                $"Date of Birth: {DateBirth}.";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Jack",
                DateBirth = new DateTime(1995, 11, 5)
            };
            XmlSerializer format=new XmlSerializer(typeof(Person));
            try
            {
                using(Stream fstream = File.Create("test.xml"))
                {
                    format.Serialize(fstream, person);
                }
                Console.WriteLine("XmlSerialize OK!");

                Person p = null;
                using(Stream fStream = File.OpenRead("test.xml"))
                {
                    p = (Person)format.Deserialize(fStream);
                }
                Console.WriteLine(p);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}