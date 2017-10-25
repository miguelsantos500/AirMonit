using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirMonit_Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnFindAlarms_Click(object sender, EventArgs e)
        {
            /****nao deu com caminho completo*/
            string filePathXml = "alarms.xml";
            //buscar a cidade escolhida na combobox
            //buscar data de inicio e data de fim

            //apresentar os resultados a partir do ficheiro xml
            HandlerAlarmsXML handler = new HandlerAlarmsXML(filePathXml);
          
            //preenche a lista com os ids dos alarmes
            listAlarmsInfo.DataSource = handler.GetAlarmIds();

            if (listAlarmsInfo.Items.Count > 0)
            {
                listAlarmsInfo.SelectedIndex = 0;
            }

        }
    }
}
