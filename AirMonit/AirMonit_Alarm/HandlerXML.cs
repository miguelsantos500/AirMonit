using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace AirMonit_Alarm
{
    class HandlerXML
    {

        string ALARM_RULES_XML = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"..\..\App_Data\alarm_rules.xml";
        string ALARM_RULES_XSD = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"..\..\App_Data\alarm_rules.xsd";


        public HandlerXML()
        {
            XmlFilepath = ALARM_RULES_XML;
            XsdFilepath = ALARM_RULES_XSD;
        }
        
        public string XmlFilepath { get; set; }
        public string XsdFilepath { get; set; }

        public string ValidationMessage { get; set; }
        
        private bool isValid;

        public bool ValidateXml()
        {
            isValid = true;
            ValidationMessage = null;


            XmlDocument doc = new XmlDocument();

            try
            {
                ValidationEventHandler myEventHandler = new ValidationEventHandler(trataEvento);
                doc.Load(XmlFilepath);
                doc.Schemas.Add(null, XsdFilepath);
                doc.Validate(myEventHandler);
            }
            catch (Exception ex)
            {
                isValid = false;
                ValidationMessage = "[Documento invalido]" + ex.Message;
            }

            return isValid;
        }

        private void trataEvento(object sender, ValidationEventArgs e)
        {
            isValid = false;
            switch (e.Severity)
            {
                case XmlSeverityType.Error:

                    ValidationMessage = "[Documento é inválido] :  ERROR" + e.Message;
                    break;
                case XmlSeverityType.Warning:

                    ValidationMessage = "[Documento é inválido] : WARNING" + e.Message;
                    break;
                default:
                    break;
            }

            ValidationMessage = "[Documento é inválido] : ";
        }

        
        public List<AlarmRule> GetAlarmRules()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlFilepath);
            XmlNodeList alarmRules = doc.SelectNodes("/alarm_rules/alarm_rule");

            List<AlarmRule> list = ExtractAlarmRules(alarmRules);

            return list;
        }

        private static List<AlarmRule> ExtractAlarmRules(XmlNodeList alarmRules)
        {
            List<AlarmRule> list = new List<AlarmRule>();
            foreach (XmlNode item in alarmRules)
            {
                string e = item.Attributes["element"].InnerText;
                string l = item["localization"].InnerText;
                int v = int.Parse(item["element_value"].InnerText);
                string c = item["condition"].InnerText;
                AlarmRule b = new AlarmRule(e, l, v, c);

                list.Add(b);
            }
            return list;
        }

    }
}
