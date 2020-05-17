using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            String filename = @"c:\test\persons.xml"; //plik
            String content = File.ReadAllText(filename); //zawartość

            XmlDocument document = new XmlDocument();
            document.LoadXml(content);

            //jak dostać się do węzła
            XmlElement persons = document["persons"];
            //Console.WriteLine("Liczba elementów w persons: " + persons.ChildNodes.Count);

            foreach (XmlElement item in persons.ChildNodes) //var najlepiej zastąpić typem danych
            {
                //pobranie danych z pliku
                String fname = item.GetAttribute("name");
                String lname = item.GetAttribute("lname");
                String phone = item.GetAttribute("phone");
                Console.WriteLine("{0}\t{1}\t{2}\t", fname, lname, phone);
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
