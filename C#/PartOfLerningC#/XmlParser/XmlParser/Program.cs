using System.Xml;
using static System.Console;

namespace XmlParser
{
    internal class Program
    {
        static string path = "Cars.xml";
        static void Main(string[] args)
        {
            WriteXmlFile(path);
            ViewAllNodeXmlFile(path);
            CreateNewXmlFileBasedOld(path);
            ReadAllInfoFromXmlFile(path);
            FindAllSetElementWithAttributesInXmlFile("Car", "Image", path);
        }

        static void WriteXmlFile(string path)
        {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(path, System.Text.Encoding.Unicode);
                writer.Formatting = Formatting.Indented;
                //writer.Indentation = 4;
                //writer.IndentChar = '@';
                writer.WriteStartDocument();
                writer.WriteStartElement("Cars");
                writer.WriteStartElement("Car");
                writer.WriteAttributeString("Image", "MyCar.jpeg");
                writer.WriteElementString("Manufactured", "La Hipano Suiza de Automovils");
                writer.WriteElementString("Model", "Alfonso");
                writer.WriteElementString("Year", "1912");
                writer.WriteElementString("Color", "Black");
                writer.WriteElementString("Spead", "130");
                writer.WriteEndElement();
                writer.WriteEndElement();
                WriteLine("The Card.xml file is generated!");
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                writer?.Close();
            }
        }

        static void ViewAllNodeXmlFile(string path)
        {
            try
            {
                XmlDocument doc=new XmlDocument();
                doc.Load(path);
                OutputNode(doc.DocumentElement);
                WriteLine();
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
        static void OutputNode(XmlNode node)
        {
            WriteLine($"Type={node.NodeType}\t" +
                $"Name={node.Name}\t" +
                $"Value={node.Value}");
            if (node.HasChildNodes)
            {
                foreach(XmlNode child in node.ChildNodes)
                {
                    OutputNode(child);
                }
            }
        }

        static void CreateNewXmlFileBasedOld(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                XmlNode root = doc.DocumentElement;
                root.RemoveChild(root.FirstChild);

                XmlNode bike=doc.CreateElement("Motorcycle");

                XmlNode elem1 = doc.CreateElement("Nanufactured");
                XmlNode elem2 = doc.CreateElement("Model");
                XmlNode elem3 = doc.CreateElement("Year");
                XmlNode elem4 = doc.CreateElement("Color");
                XmlNode elem5 = doc.CreateElement("Engine");

                XmlNode text1 = doc.CreateTextNode("Harley-Davidson Moror Co. Inc.");
                XmlNode text2 = doc.CreateTextNode("Harley 20J");
                XmlNode text3 = doc.CreateTextNode("1920");
                XmlNode text4 = doc.CreateTextNode("Olive");
                XmlNode text5 = doc.CreateTextNode("37 HP");

                elem1.AppendChild(text1);
                elem2.AppendChild(text2);
                elem3.AppendChild(text3);
                elem4.AppendChild(text4);
                elem5.AppendChild(text5);

                bike.AppendChild(elem1);
                bike.AppendChild(elem2);
                bike.AppendChild(elem3);
                bike.AppendChild(elem4);
                bike.AppendChild(elem5);

                root.AppendChild(bike);

                doc.Save("Morotcycle.xml");
                WriteLine("The Motorcycle.xml file is generated");
                WriteLine();
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message);
            }
        }

        static void ReadAllInfoFromXmlFile(string path)
        {
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(path);
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read())
                {
                    WriteLine($"Type={reader.NodeType}\t\t" +
                        $"Name={reader.Name}\t\t" +
                        $"Value={reader.Value}");
                    if (reader.AttributeCount > 0)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            WriteLine($"Type={reader.NodeType}\t" +
                                $"Name={reader.Name}\t" +
                                $"Value={reader.Value}");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                reader?.Close();
                WriteLine();
            }
        }

        static void FindAllSetElementWithAttributesInXmlFile(string NameElement, string AttributeName, string path)
        {
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(path);
                reader.WhitespaceHandling= WhitespaceHandling.None;

                while (reader.Read())
                {
                    if(reader.NodeType == XmlNodeType.Element&&
                            reader.Name == NameElement &&
                            reader.AttributeCount > 0)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name == AttributeName)
                                WriteLine(reader.Value);
                                break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                reader?.Close();
            }
        }
    }
}