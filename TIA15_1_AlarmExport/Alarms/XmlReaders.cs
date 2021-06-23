using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;

namespace TIA15_1_AlarmExport
{
    public static class XmlReaders
    {
        public static string SourceLangAlarmClass;
        public static AlarmClass DefaultAlarmClass;
        public static List<AlarmClass> AlarmClasses = new List<AlarmClass>();

        public static AlarmClass FindAlarmClass(List<LanguageText> langText, List<AlarmClass> AlarmClasses, string SourceLangAlarmClass)
        {
            AlarmClass ret = new AlarmClass();
            try
            {
                LanguageText _lt = langText.Find(lt => lt.Language.Equals(SourceLangAlarmClass));
                if (_lt != null)
                    ret = AlarmClasses.Find(ac =>
                    {
                        if (ac.TextCode == "" || ac.HMIAlarmClass == "")
                            return false;
                        return _lt.Text.Contains(" $" + ac.TextCode);
                    }
                    );

            }
            catch (Exception ex)
            {
                Debug.Print("\n"+ex.Message);
                return new AlarmClass();
            }
            if (ret == null)
                ret = new AlarmClass();
            return ret;
        }
        public static List<LanguageText> DeleteCode(List<LanguageText> langText)
        {
            List<LanguageText> ret = new List<LanguageText>();
            foreach(LanguageText lt in langText)
            {
                string s = lt.Text;
                int startIndex = lt.Text.IndexOf(" $");
                if (startIndex>=0)
                    s=lt.Text.Remove(startIndex);
                ret.Add(new LanguageText(lt.Language, s));
            }
            return ret;
        }
        public static UDTAlarms ReadxmlUDT(string path)
        {
            XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object
            xmlDoc.Load(path); // Load the XML document from the specified file

            // Get elements
            XmlNodeList Member = xmlDoc.GetElementsByTagName("Member");
            XmlNodeList Name = xmlDoc.GetElementsByTagName("Name");

            if (Name == null)
                throw new Exception("Name not defined");
            string name = Name[0].InnerText;
            List<Alarm> a = new List<Alarm>();

            int offset = 0;
            foreach (XmlNode _member in Member)
            {
                string _dataTyp, _name;
                _dataTyp = _member.Attributes.GetNamedItem("Datatype").Value.Replace('\\', ' ').Replace('"', ' ').Replace(" ", string.Empty);
                _name = _member.Attributes.GetNamedItem("Name").Value;
                List<LanguageText> langText = new List<LanguageText>();
                foreach (XmlNode n in _member.ChildNodes)
                {
                    if (n.Name == "Comment")
                    {
                        foreach (XmlNode comment in n)
                        {
                            string lang, text;
                            lang = "[" + comment.Attributes.GetNamedItem("Lang").Value + "]";
                            text = comment.InnerText;
                            langText.Add(new LanguageText(lang, text));
                        }
                    }
                }
                if (langText.Count > 0 && _dataTyp == "Bool")
                {
                    int _offset = offset;
                    switch (_offset % 16)
                    {
                        case int n when (0 <= n && n <= 7):
                            _offset += 8;
                            break;
                        case int n when (8 <= n && n <= 15):
                            _offset += -8;
                            break;
                        default:
                            throw new Exception("Offset error (" + offset.ToString() + ")");
                    }

                    AlarmClass _ac = XmlReaders.FindAlarmClass(langText, AlarmClasses, SourceLangAlarmClass);
                    langText = XmlReaders.DeleteCode(langText);

                    a.Add(new Alarm(langText, _offset, _ac, _name));
                    offset++;
                }
                else
                {
                    throw new Exception("Alarm not definet");
                }

            }
            if (a.Count == 32)
            {
                return new UDTAlarms(name, a.ToArray());
            }
            else
            {
                throw new Exception("Array Count not 32");
            }
        }
        public static List<AlarmTag> ReadxmlDBAlarms(string path, List<UDTAlarms> udtAlarms)
        {
            XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object
            xmlDoc.Load(path); // Load the XML document from the specified file

            // Get elements
            XmlNodeList Interface = xmlDoc.GetElementsByTagName("Interface");
            XmlNodeList Sections = Interface[0].ChildNodes;
            XmlNodeList Section = Sections[0].ChildNodes;
            XmlNodeList Member = Section[0].ChildNodes;
            String _DBname = xmlDoc.GetElementsByTagName("Name")[0].InnerText;

            List<AlarmTag> ret = new List<AlarmTag>();
            int Addres = 0;
            foreach (XmlNode _member in Member)
            {
                String _dataTyp, _name;
                _dataTyp = _member.Attributes.GetNamedItem("Datatype").Value.Replace('\\', ' ').Replace('"', ' ').Replace(" ", string.Empty);
                _name = _member.Attributes.GetNamedItem("Name").Value;
                List<LanguageText> langText = new List<LanguageText>();
                if (_dataTyp != "Bool" && _dataTyp!="DWord")//not bool then must by somthing wiht 4bytes
                {
                    foreach (XmlNode Tag in _member.ChildNodes)
                    {
                        switch (Tag.Name)
                        {
                            #region Read Prefix
                            case "Comment":
                                foreach (XmlNode comment in Tag)
                                {
                                    string lang, text;
                                    lang = "[" + comment.Attributes.GetNamedItem("Lang").Value + "]";
                                    text = comment.InnerText;
                                    langText.Add(new LanguageText(lang, text));
                                }
                                break;
                            #endregion
                            #region Read Alarms
                            case "Sections":
                                int offset = 0;
                                List<Alarm> a = new List<Alarm>();
                                foreach (XmlNode xmlA in Tag.ChildNodes[0])
                                {
                                    AlarmClass _alarmClassA = null;
                                    string _dataTypA, _nameA;
                                    _dataTypA = xmlA.Attributes.GetNamedItem("Datatype").Value;
                                    _nameA = xmlA.Attributes.GetNamedItem("Name").Value;
                                    List<LanguageText> langTextA = new List<LanguageText>();
                                    foreach (XmlNode n in xmlA.ChildNodes)
                                    {
                                        if (n.Name == "Comment")
                                        {
                                            foreach (XmlNode comment in n)
                                            {
                                                string lang, text;
                                                lang = "[" + comment.Attributes.GetNamedItem("Lang").Value + "]";
                                                text = comment.InnerText;
                                                langTextA.Add(new LanguageText(lang, text));

                                                _alarmClassA = FindAlarmClass(langTextA, AlarmClasses, SourceLangAlarmClass);
                                                langTextA = DeleteCode(langTextA);
                                            }
                                        }
                                    }
                                    if (langTextA.Count == 0)//Comment not exist,then take comments from UDT
                                    {
                                        Alarm _a = udtAlarms.Find(x => x.Name.Equals(_dataTyp)).Alarms[offset];
                                        langTextA = _a.Text;
                                        _alarmClassA = _a.AlarmClass;
                                    }
                                    if (_alarmClassA == null)
                                        _alarmClassA = new AlarmClass();
                                    if (langTextA.Count > 0 && _dataTypA == "Bool")
                                    {
                                        int _offset = offset;
                                        switch (_offset % 16)
                                        {
                                            case int n when (0 <= n && n <= 7):
                                                _offset += 8;
                                                break;
                                            case int n when (8 <= n && n <= 15):
                                                _offset += -8;
                                                break;
                                            default:
                                                throw new Exception("Offset error (" + offset.ToString() + ")");
                                        }


                                        a.Add(new Alarm(langTextA, _offset, _alarmClassA, _nameA));
                                        offset++;

                                    }
                                }

                                if (a.Count == 32)
                                {
                                    Alarm[] ar =new Alarm[32];
                                        a.CopyTo(ar);
                                    ret.Add(new AlarmTag(langText,
                                               udtAlarms.Find(x => x.Name.Equals(_dataTyp)),
                                                ar,
                                                _name,
                                                "DB49.DBX"+ Addres.ToString()+".0"
                                                , _DBname)
                                        );
                                }
                                else
                                {
                                    throw new Exception("Array Count not 32");
                                }
                                break;
                            #endregion
                            default:
                                break;
                        }
                    }
                }
                Addres += 4;//every doubleword
            }
            return ret;
        }
    }
}
