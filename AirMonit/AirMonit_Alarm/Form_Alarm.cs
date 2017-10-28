using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.alarmState = false;
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
    }
}
