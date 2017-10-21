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

        public AirMonit_Alarm()
        {
            InitializeComponent();
            this.alarmState = false;
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
