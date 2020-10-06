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
            this.AlarmClass = "";
        }

        public Alarm(List<LanguageText> Text, int Offset, String AlarmClass)
        {
            this.Text = Text;
            this.Offset = Offset;
            this.AlarmClass = AlarmClass;
        }
        /// <summary>
        /// Texts in diferent lagunages
        /// </summary>
        public List<LanguageText> Text;
        /// <summary>
        /// Bit offset in DWORD (TAG)
        /// </summary>
        public int Offset;
        public String AlarmClass;
    }

    public class AlarmTag
    {
        public AlarmTag(List<LanguageText> Prefix, UDTAlarms udtAlarms, Alarm[] Alarms, String TagName, String TagAddres)
        {
            this.Prefix = Prefix;
            this.udtAlarms = udtAlarms;
            this.Alarms = Alarms;
            this.TagName = TagName;
            this.TagAddres = TagAddres;
        }
        /// <summary>
        /// Prefix for Alarms.Text
        /// </summary>
        public List<LanguageText> Prefix;
        public UDTAlarms udtAlarms;
        public Alarm[] Alarms;
        public String TagName;
        public String TagAddres;
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
