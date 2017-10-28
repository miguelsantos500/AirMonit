using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Security.Cryptography.X509Certificates;
using System.Resources;
namespace AirMonit_DU
{
    class Program_DU
    {
        static MqttClient m_cClient = new MqttClient("18.216.17.64");

        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) +
            " on topic " + e.Topic);
        }

        static void Main(string[] args)
        {

           
            string[] m_strTopicsInfo = { "data", "alarms" };

            byte code = m_cClient.Connect(Guid.NewGuid().ToString(),"isipl","isipl");
            if (!m_cClient.IsConnected)
            {
                Console.WriteLine("Error connecting to message broker...");
                return;
            }




            AirSensorNodeDll.AirSensorNodeDll  dll= new AirSensorNodeDll.AirSensorNodeDll();
            dll.Initialize(Anymethod, 2000);
            //m_cClient.Disconnect();
            Console.WriteLine("Hello");
            
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
            
            String pub = "CityElementID:  " + words[0] + "\t Element:  " + words[1] + "\t ElementValue:  " + words[2] +
              "\t date:  " + words[3] + "\t city:  " + words[4]+"\n";
            m_cClient.Publish("data", Encoding.UTF8.GetBytes(pub));
          
        }
    }
}
