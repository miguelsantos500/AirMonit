using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AirMonit_Alarm
{
    public partial class AirMonit_Alarm : Form
    {
        private bool alarmState;
        private HandlerXML handlerXML;
        private List<AlarmRule> alarmRules;

        public AirMonit_Alarm()
        {
            InitializeComponent();
            this.alarmState = true;
            this.handlerXML = new HandlerXML();
            bool isValid = this.handlerXML.ValidateXml();
            if(!isValid)
            {
                MessageBox.Show(handlerXML.ValidationMessage + " Exiting...");
                //Application.Exit();
                Environment.Exit(1);
            } else
            {
                this.alarmRules = this.handlerXML.GetAlarmRules();
                /*
                string temp = "";
                foreach (var alarmRule in this.alarmRules)
                {
                    temp += alarmRule.Localization + ";" + alarmRule.Element + ";"
                        + alarmRule.ElementValue + ";" + alarmRule.Condition + ";" + "\n";
                }
                MessageBox.Show(temp);
                */
            }
        }

        private void btnToggleAlarm_Click(object sender, EventArgs e)
        {
            this.alarmState = !this.alarmState;

            //MessageBox.Show(lblAlarmState.BackColor.Name);

            if(lblAlarmState.BackColor.Name.Equals("Lime"))
            {
                lblAlarmState.Text = "OFF";
                lblAlarmState.BackColor = Color.Red;

            } else
            {
                lblAlarmState.Text = "ON";
                lblAlarmState.BackColor = Color.Lime;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode papa = doc.CreateNode("element", "AirEntry", "");
            doc.AppendChild(papa);
            XmlNode ceIdValue = doc.CreateNode("element", "CityElementID", "");
            ceIdValue.InnerText = numUpDownCityElement.Value.ToString();
            papa.AppendChild(ceIdValue);
            XmlNode element = doc.CreateNode("element", "Element", "");
            element.InnerText = txtBoxElement.Text;
            papa.AppendChild(element);
            XmlNode elemtValue = doc.CreateNode("element", "ElementValue", "");
            elemtValue.InnerText = txtBoxValue.Text;
            papa.AppendChild(elemtValue);
            XmlNode date = doc.CreateNode("element", "date", "");
            date.InnerText = txtBoxDate.Text;
            papa.AppendChild(date);
            XmlNode city = doc.CreateNode("element", "city", "");
            city.InnerText = txtBoxLocalization.Text;
            papa.AppendChild(city);

            CheckForAlarms(doc);
        }

        private void CheckForAlarms(XmlDocument doc)
        {
            txtBoxAlarmXML.Text = "";
            if (!this.alarmState)
            {
                return;
            }

            XmlNode bookNode = doc.SelectSingleNode("/AirEntry");
            

            string cityElementID = bookNode["CityElementID"].InnerText;
            string element = bookNode["Element"].InnerText;
            int elementValue = int.Parse(bookNode["ElementValue"].InnerText);
            string date = bookNode["date"].InnerText;
            string city = bookNode["city"].InnerText;
            
            foreach (var alarmRule in this.alarmRules)
            {
                if((alarmRule.Localization == "ANY" || alarmRule.Localization == city) &&
                    (alarmRule.Element == "ANY" || alarmRule.Element == element))
                {
                    if(alarmRule.Condition.CompareValues(elementValue, alarmRule.ElementValue))
                    {
                        //ALARM!!!!!!!
                        txtBoxAlarmXML.Text = "Alarm!!!" + Environment.NewLine +
                            "Alarm Info: " + alarmRule.Localization + "\t" +
                            alarmRule.Element + ":" + alarmRule.ElementValue + "\t" +
                            alarmRule.Condition + Environment.NewLine + 
                            "Entry Info: " + city + "\t" + element + ":" + elementValue +
                            "\t" + date;
                    }
                }


            }

        }
    }
}
