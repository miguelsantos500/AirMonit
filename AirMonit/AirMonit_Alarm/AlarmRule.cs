using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirMonit_Alarm
{
    class AlarmRule
    {
        public string Element { get; set; }
        public string Localization { get; set; }
        public int ElementValue { get; set; }
        public Condition Condition { get; set; }

        public AlarmRule(string element, string localization, int elementValue, string condition)
        {
            this.Element = element;
            this.Localization = localization;
            this.ElementValue = elementValue;
            this.Condition = (Condition)Enum.Parse(typeof(Condition), condition);
            ;
        }
    }
}
