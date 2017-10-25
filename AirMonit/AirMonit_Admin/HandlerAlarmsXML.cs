using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AirMonit_Admin
{
    class HandlerAlarmsXML
    {
       
        public string XmlFilepath { get; set; }
        public string XsdFilepath { get; set; }


        public HandlerAlarmsXML(string xmlFilepath, string xsdFilepath)
        {
            XmlFilepath = xmlFilepath;
            XsdFilepath = xsdFilepath;
        }

        public HandlerAlarmsXML(string xmlFilepath)
        {
            XmlFilepath = xmlFilepath;
        }


        public List<string> GetAlarmIds()
        {
            //lista para guardar os ãlarmID
            List<string> alarmIds = new List<string>();

            XmlDocument alarmsDoc = new XmlDocument();
            alarmsDoc.Load(XmlFilepath);

            //buscar os nos com os alarmId
            XmlNodeList nodeList = alarmsDoc.SelectNodes("/alarms/alarm/alarmId");

            //percorrer a lista de nos 
            foreach(XmlNode item in nodeList)
            {
                alarmIds.Add(item.InnerText);
            }
            
            return alarmIds;
        }
    }
}
