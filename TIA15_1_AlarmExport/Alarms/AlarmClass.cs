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
            this.TextCode = XmlReaders.DefaultAlarmClass.TextCode;
            this.FBname = XmlReaders.DefaultAlarmClass.FBname;
        }
        public AlarmClass(string HMIAlarmClass, string TextCode, string FBname)
        {
            this.HMIAlarmClass = HMIAlarmClass;
            this.TextCode = TextCode;
            this.FBname = FBname;
        }

        public String TextCode;
        public String HMIAlarmClass;
        public String FBname;
    }
}
