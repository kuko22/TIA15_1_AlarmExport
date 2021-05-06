using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIA15_1_AlarmExport
{
    public class AlarmClass
    {
        public AlarmClass()
        {
            this.HMIAlarmClass = XmlReaders.DefaultAlarmClass.HMIAlarmClass;
            this.TextCode = XmlReaders.DefaultAlarmClass.HMIAlarmClass;
        }
        public AlarmClass(string HMIAlarmClass, string TextCode)
        {
            this.HMIAlarmClass = HMIAlarmClass;
            this.TextCode = TextCode;
        }

        public String TextCode;
        public String HMIAlarmClass;
    }
}
