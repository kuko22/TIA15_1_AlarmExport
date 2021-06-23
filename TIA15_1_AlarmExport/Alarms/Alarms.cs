using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace TIA15_1_AlarmExport
{
    public class LanguageText
    {
        public LanguageText()
        {
            this.Language = "";
            this.Text = "";
        }
        public LanguageText(String Language, String Text)
        {
            this.Language = Language;
            this.Text = Text;
        }
        /// <summary>
        /// Language of Text
        /// </summary>
        public String Language;
        /// <summary>
        /// Text
        /// </summary>
        public String Text;
    }
    public class Alarm
    {
        public Alarm()
        {
            this.Text = new List<LanguageText>();
            this.Offset = 0;
            this.AlarmClass = new AlarmClass("ABORT","A", "FB_Alarm_Abort");
            this.AlarmName = "";
        }

        public Alarm(List<LanguageText> Text, int Offset, AlarmClass AlarmClass, String AlarmName)
        {
            this.Text = Text;
            this.Offset = Offset;
            this.AlarmClass = AlarmClass;
            this.AlarmName= AlarmName;
        }
        /// <summary>
        /// Texts in diferent lagunages
        /// </summary>
        public List<LanguageText> Text;
        /// <summary>
        /// Bit offset in DWORD (TAG)
        /// </summary>
        public int Offset;
        /// <summary>
        /// Alarm clast, Alarm code in Alarm Text and Alarm Class Name in HMI
        /// </summary>
        public AlarmClass AlarmClass;
        /// <summary>
        /// Alarm Tag name
        /// </summary>
        public String AlarmName;
    }

    public class AlarmTag
    {
        public AlarmTag(List<LanguageText> Prefix, UDTAlarms udtAlarms, Alarm[] Alarms, String TagName, String TagAddres, String DBname)
        {
            this.Prefix = Prefix;
            this.udtAlarms = udtAlarms;
            this.Alarms = Alarms;
            this.TagName = TagName;
            this.TagAddres = TagAddres;
            this.DBname = DBname;
        }
        /// <summary>
        /// Prefix for Alarms.Text
        /// </summary>
        public List<LanguageText> Prefix;
        public UDTAlarms udtAlarms;
        public Alarm[] Alarms;
        public String TagName;
        public String TagAddres;
        public String DBname;
    }
    public class UDTAlarms
    {
        public UDTAlarms(String Name, Alarm[] Alarms)
        {
            if (Alarms.Length != 32)
            {
                throw new Exception("Name: " + Name + ": The Alarm field must be 32");
            }
            this.Name = Name;
            this.Alarms = Alarms;
        }
        /// <summary>
        /// UDT Name
        /// </summary>
        public String Name;
        /// <summary>
        /// Alarms in UDT
        /// </summary>
        public Alarm[] Alarms;
    }

}
