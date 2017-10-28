using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace AirMonit_DU
{
    class Program_DU
    {
        static void Main(string[] args)
        {
            AirSensorNodeDll.AirSensorNodeDll  dll= new AirSensorNodeDll.AirSensorNodeDll();
            dll.Initialize(Anymethod, 2000);

        }

        private static void Anymethod(string message)
        {
            XmlDocument doc = new XmlDocument();
            string[] words = message.Split(';');
            XmlNode papa = doc.CreateNode("element", "AirEntry", "");
            doc.AppendChild(papa);
            XmlNode ceIdValue = doc.CreateNode("element", "CityElementID","");
            ceIdValue.InnerText = words[0];
            papa.AppendChild(ceIdValue);
            XmlNode element = doc.CreateNode("element", "Element", "");
            element.InnerText = words[1];
            papa.AppendChild(element);
            XmlNode elemtValue = doc.CreateNode("element", "ElementValue", "");
            elemtValue.InnerText = words[2];
            papa.AppendChild(elemtValue);
            XmlNode date = doc.CreateNode("element", "date", "");
            date.InnerText = words[3];
            papa.AppendChild(date);
            XmlNode city = doc.CreateNode("element", "city", "");
            city.InnerText = words[4];
            papa.AppendChild(city);
            doc.Save(AppDomain.CurrentDomain.BaseDirectory+"teste.xml");
            Console.WriteLine("Received Entry:");
            Console.Write("CityElementID:  " + words[0] + "\t Element:  " + words[1] + "\t ElementValue:  " + words[2] +
                "\t date:  " + words[3] + "\t city:  " + words[4]+"\n");
            {

            }
        }
    }
}
