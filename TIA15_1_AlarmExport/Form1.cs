using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Siemens.Engineering;
using Siemens.Engineering.HW;
using Siemens.Engineering.SW;
using Siemens.Engineering.Hmi;
using Siemens.Engineering.SW.Types;
using Siemens.Engineering.SW.Blocks;
using Siemens.Engineering.HW.Features;
using Spire.Xls;


namespace TIA15_1_AlarmExport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _udtAlarms = new List<UDTAlarms>();
            _tagAlarms = new List<AlarmTag>();
            StartID = 4000;
            CompatibleProjektVersion = new List<string>();
            CompatibleProjektVersion.Add("15.1.0.0");

            Debug.Print("Program start:\n");
            string[] args = Environment.GetCommandLineArgs();

            foreach (string s in args)
            {
                Debug.Print(s);
            }

            string ProjectVersion = "0";
            Projectpath = "0";
            if (args.Length > 1)
            {
                string[] st = args[1].Split(';');

                if (st.Length != 2)
                {
                    Debug.Print("Program with fault args[]\nLenght:" + args.Length);
                    return;
                }

                ProjectVersion = st[0];
                Debug.Print("Project version: " + ProjectVersion + "\n");
                bool VersinOK = false;
                foreach (string s in CompatibleProjektVersion)
                {
                    if (string.Equals(s, ProjectVersion))
                    {
                        VersinOK = true;
                        Debug.Print("TIA Portal Project Version Compatible\n");
                        break;
                    }
                }
                Projectpath = st[1];
                Debug.Print("Project path: " + Projectpath + "\n");
            }
            else
            {
                Debug.Print("Opened without direct project\n");
            }
        }

        List<string> CompatibleProjektVersion;
        PlcSoftware userSW;
        HmiTarget userHMI;
        int StartID;
        public String Projectpath { get; set; }
        public String ProjectName { get; set; }
        public String ProjectpathOnly { get; set; }
        /// <summary>The tia portal</summary>
        /// TODO Edit XML Comment Template for tiaPortal
        private TiaPortal _tiaPortal;
        /// <summary>The tia portal project</summary>
        /// TODO Edit XML Comment Template for tiaPortalProject
        private Project _tiaPortalProject;
        /// <summary>The tia portal projects</summary>
        /// TODO Edit XML Comment Template for tiaPortalProjects
        private ProjectComposition _tiaPortalProjects;

        private List<UDTAlarms> _udtAlarms;
        private List<AlarmTag> _tagAlarms;

        private void button_SearchProject_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Project.ShowDialog() == DialogResult.OK)
            {
                textBox_ProjectPath.Text = Projectpath = openFileDialog_Project.FileName;
                int index = Projectpath.LastIndexOf("\\");
                string[] s = Projectpath.Split('\\');
                ProjectName = s[s.Length - 1];
                ProjectpathOnly = Projectpath.Substring(0, Projectpath.Length - ProjectName.Length);
            }
        }

        private void button_ExportAlarms_Click(object sender, EventArgs e)
        {
            List<string> Lanuguages = new List<string>();
            foreach (object i in checkedListBox_Lang.CheckedItems)
            {
                Lanuguages.Add(i as string);
            }
            #region Find project
            Debug.Print("\nSearching...");
            Process[] _proces = Process.GetProcessesByName("Siemens.Automation.Portal");

            if (_proces.Length == 0)
            {
                Debug.Print("Tia Portal  not opened");
                return;
            }
            List<TiaPortal> _tia = new List<TiaPortal>();
            foreach (Process _pri in _proces)
            {
                try
                {
                    Debug.Print("Proces ID found: " + _pri.Id);
                    TiaPortalProcess _p = TiaPortal.GetProcess(_pri.Id);
                    if (_p != null)
                    {
                        Debug.Print("Proces ID found: " + _pri.Id + " - GetProcess");
                        TiaPortal _tia1;//= new TiaPortal();
                        _tia1 = _p.Attach();
                        Debug.Print("Proces ID found: " + _pri.Id + " - Attach");
                        _tia.Add(_tia1);
                        Debug.Print("Proces ID found: " + _pri.Id + " - Add");
                    }
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.Message);
                }
            }

            bool Found = false;
            foreach (TiaPortal _tia1 in _tia)
            {
                _tiaPortal = _tia1;
                _tiaPortalProjects = _tiaPortal.Projects;
                foreach (Project _pro in _tiaPortalProjects)
                {
                    Debug.Print("Searching For Project Path: " + Projectpath + "- end");
                    Debug.Print("              Project Path: " + _pro.Path + "- end");
                    if (_pro.Path.ToString().Equals(Projectpath))
                    {
                        Debug.Print("Founded!!!");
                        Found = true;
                        _tiaPortalProject = _pro;
                        break;
                    }
                }
                if (Found) { break; }
            }
            Debug.Print("Program started-END\n");
            #endregion
            #region Find PLC Softwer

            if (_tiaPortalProject == null)
            {
                Debug.Print("Project not founded\n");
                return;
            }
            Debug.Print("Searhing: Devices/...");

            foreach (DeviceUserGroup g1 in _tiaPortalProject.DeviceGroups)
                foreach (Device d in g1.Devices)
                {
                    //if (userHMI == null)
                    //    userHMI = GetHmiTarget(d);

                    if (userSW == null)
                        userSW = GetPlcSoftware(d);
                }

            if (userSW == null)
            {
                Debug.Print("No SW founded!!!" + "\n");
                return;
            }
            #endregion
            #region Export/Read Alarms from SW

            UDT_Alarms = new List<PlcType>();
            PlcTypeSystemGroup s = userSW.TypeGroup;
            UDT_Alarms.AddRange(ReadTypeWithName("UDT_Alarms_", s.Groups));
            //listView_UDT_Alarms = new ListView();
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(ProjectpathOnly + "Export\\");
            if (di.Exists)
                di.Delete(true);//Delete folder, and creat new...
            foreach (var v in UDT_Alarms)
            {
                try
                {
                    string _file = ProjectpathOnly + "Export\\" + v.Name + ".xml";
                    if (!System.IO.File.Exists(_file))
                    {
                        v.Export(new System.IO.FileInfo(_file), Siemens.Engineering.ExportOptions.WithDefaults);
                        _udtAlarms.Add(XmlReaders.ReadxmlUDT(_file));
                    }

                }
                catch (Exception ex)
                {
                    Debug.Print(ex.Message + "\n");
                }
            }
            PlcBlockSystemGroup b = userSW.BlockGroup;
            DB_Alarms = new List<PlcBlock>();
            DB_Alarms.AddRange(ReadPLCblocks("DB_Alarms", b.Blocks));
            DB_Alarms.AddRange(ReadPLCblocks("DB_Alarms", b.Groups));
            //listView_DB_Alarms = new ListView();
            foreach (var v in DB_Alarms)
            {
                if (v.ProgrammingLanguage == ProgrammingLanguage.DB)
                {
                    try
                    {
                        DB_Alarm = v as DataBlock;
                        string _file = ProjectpathOnly + "Export\\" + DB_Alarm.Name + ".xml";
                        if (!System.IO.File.Exists(_file))
                        {
                            DB_Alarm.Export(new System.IO.FileInfo(_file), Siemens.Engineering.ExportOptions.WithDefaults);
                            _tagAlarms.AddRange(XmlReaders.ReadxmlDBAlarms(_file, _udtAlarms));
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.Print(ex.Message + "\n");
                    }
                }
            }
            #endregion
            #region FILL OUT HMI ALARMS
            //Initialize a new Workboook object
            Workbook workbook = new Workbook();
            //Get the first worksheet
            Worksheet OUTsheet = workbook.Worksheets[0];
            //Write string values in a cell

            try
            {
                foreach (string lang in Lanuguages)
                {
                                                            //Header
                    OUTsheet.Name = "DiscreteAlarms";
                    OUTsheet.SetCellValue(1,1,"ID");
                    OUTsheet.SetCellValue(1, 2, "Name");
                    OUTsheet.SetCellValue(1, 3, "Alarm text " + lang + ", Alarm text");
                    OUTsheet.SetCellValue(1, 4, "FieldInfo [Alarm text]");
                    OUTsheet.SetCellValue(1, 5, "Class");
                    OUTsheet.SetCellValue(1, 6, "Trigger tag");
                    OUTsheet.SetCellValue(1, 7, "Trigger bit");
                    OUTsheet.SetCellValue(1, 8, "Acknowledgement tag");
                    OUTsheet.SetCellValue(1, 9, "Acknowledgement bit");
                    OUTsheet.SetCellValue(1, 10, "PLC acknowledgement tag");
                    OUTsheet.SetCellValue(1, 11, "PLC acknowledgement bit");
                    OUTsheet.SetCellValue(1, 12, "Group");
                    OUTsheet.SetCellValue(1, 13, "Report");
                    OUTsheet.SetCellValue(1, 14, "Info text " + lang + ", Info text");

                    int index = 2;
                    int ID = StartID;
                    foreach (AlarmTag alarmT in _tagAlarms)
                    {
                        string _prefix = alarmT.Prefix.Exists(element => element.Language == lang) ?
                                alarmT.Prefix.FindLast(element => element.Language == lang).Text :
                                "";
                        foreach (Alarm alarm in alarmT.Alarms)
                        {
                            OUTsheet.SetCellValue(index, 1, ID.ToString());
                            OUTsheet.SetCellValue(index, 2,alarmT.TagName + "_"+ID.ToString());
                            string  _alarm;                             
                            _alarm = alarm.Text.Exists(element => element.Language == lang) ? 
                                alarm.Text.FindLast(element => element.Language == lang).Text.Replace(@"\p{C}+", String.Empty) : 
                                "";
                            OUTsheet.SetCellValue(index, 3, _prefix +" "+ _alarm);
                            OUTsheet.SetCellValue(index, 4, "");
                            OUTsheet.SetCellValue(index, 5,alarm.AlarmClass);
                            OUTsheet.SetCellValue(index, 6,alarmT.TagName);
                            OUTsheet.SetCellValue(index, 7,alarm.Offset.ToString());
                            OUTsheet.SetCellValue(index, 8, "<No value>");
                            OUTsheet.SetCellValue(index, 9, "0");
                            OUTsheet.SetCellValue(index, 10, "<No value>");
                            OUTsheet.SetCellValue(index, 11, "0");
                            OUTsheet.SetCellValue(index, 12, "<No value>");
                            OUTsheet.SetCellValue(index, 13, "False");
                            OUTsheet.SetCellValue(index, 14, "<No value>");

                            ID++;
                            index++;
                        }
                    }
                    string path = ProjectpathOnly + "Export\\" + ProjectName.Remove(ProjectName.IndexOf(".ap15_1"), 7);
                    string name = lang.Remove(lang.IndexOf("]"), 1);
                    name = name.Remove(name.IndexOf("["), 1);
                    workbook.SaveToFile(path + "_" + name + ".xlsx", FileFormat.Version2016);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region FILL OUT HMI ALARM TAGS

            // declare the application object
            //Initialize a new Workboook object
            workbook = new Workbook();
            //Get the first worksheet
            OUTsheet = workbook.Worksheets[0];
            try
            {
                                                        //Header
                OUTsheet.Name = "Hmi Tags";
                OUTsheet.SetCellValue(1, 1, "Name");
                OUTsheet.SetCellValue(1, 2, "Path");
                OUTsheet.SetCellValue(1, 3, "Connection");
                OUTsheet.SetCellValue(1, 4, "PLC tag");
                OUTsheet.SetCellValue(1, 5, "DataType");
                OUTsheet.SetCellValue(1, 6, "Length");
                OUTsheet.SetCellValue(1, 7, "Coding");
                OUTsheet.SetCellValue(1, 8, "Access Method");
                OUTsheet.SetCellValue(1, 9, "Address");
                OUTsheet.SetCellValue(1, 10, "Indirect addressing");
                OUTsheet.SetCellValue(1, 11, "Index tag");
                OUTsheet.SetCellValue(1, 12, "Start value");
                OUTsheet.SetCellValue(1, 13, "ID tag");
                OUTsheet.SetCellValue(1, 14, "Display name [en-US]");
                OUTsheet.SetCellValue(1, 15, "Comment [en-US]");
                OUTsheet.SetCellValue(1, 16, "Acquisition mode");
                OUTsheet.SetCellValue(1, 17, "Acquisition cycle");
                OUTsheet.SetCellValue(1, 18, "Limit Upper 2 Type");
                OUTsheet.SetCellValue(1, 19, "Limit Upper 2");
                OUTsheet.SetCellValue(1, 20, "Limit Upper 1 Type");
                OUTsheet.SetCellValue(1, 21, "Limit Upper 1");
                OUTsheet.SetCellValue(1, 22, "Limit Lower 1 Type");
                OUTsheet.SetCellValue(1, 23, "Limit Lower 1");
                OUTsheet.SetCellValue(1, 24, "Limit Lower 2 Type");
                OUTsheet.SetCellValue(1, 25, "Limit Lower 2");
                OUTsheet.SetCellValue(1, 26, "Linear scaling");
                OUTsheet.SetCellValue(1, 27, "End value PLC");
                OUTsheet.SetCellValue(1, 28, "Start value PLC");
                OUTsheet.SetCellValue(1, 29, "End value HMI");
                OUTsheet.SetCellValue(1, 30, "Start value HMI");
                OUTsheet.SetCellValue(1, 31, "Gmp relevant");
                OUTsheet.SetCellValue(1, 32, "Confirmation Type");
                OUTsheet.SetCellValue(1, 33, "Mandatory Commenting");

                int index = 2;
                foreach (AlarmTag alarmT in _tagAlarms)
                {

                    OUTsheet.SetCellValue(index, 1, alarmT.TagName);
                    OUTsheet.SetCellValue(index, 2, "Alarms\\Alarms");
                    OUTsheet.SetCellValue(index, 3, "D1040A1_RM1.3-40PLC0");
                    OUTsheet.SetCellValue(index, 4, "<No Value>");
                    OUTsheet.SetCellValue(index, 5, "Array [0..1] of Int");
                    OUTsheet.SetCellValue(index, 6, "4");
                    OUTsheet.SetCellValue(index, 7, "Binary");
                    OUTsheet.SetCellValue(index, 8, "Absolute access");
                    OUTsheet.SetCellValue(index, 9, "%"+alarmT.TagAddres);// "%DB49.DBX364.0");
                    OUTsheet.SetCellValue(index, 10, "False");
                    OUTsheet.SetCellValue(index, 11, "<No Value>");
                    OUTsheet.SetCellValue(index, 12, "<No Value>");
                    OUTsheet.SetCellValue(index, 13, "0");
                    OUTsheet.SetCellValue(index, 14, "<No Value>");
                    OUTsheet.SetCellValue(index, 15, "<No Value>");
                    OUTsheet.SetCellValue(index, 16, "Continuous");
                    OUTsheet.SetCellValue(index, 17, "500 ms");
                    OUTsheet.SetCellValue(index, 18, "None");
                    OUTsheet.SetCellValue(index, 19, "<No Value>");
                    OUTsheet.SetCellValue(index, 20, "None");
                    OUTsheet.SetCellValue(index, 21, "<No Value>");
                    OUTsheet.SetCellValue(index, 22, "None");
                    OUTsheet.SetCellValue(index, 23, "<No Value>");
                    OUTsheet.SetCellValue(index, 24, "None");
                    OUTsheet.SetCellValue(index, 25, "<No Value>");
                    OUTsheet.SetCellValue(index, 26, "False");
                    OUTsheet.SetCellValue(index, 27, "10");
                    OUTsheet.SetCellValue(index, 28, "0");
                    OUTsheet.SetCellValue(index, 29, "100");
                    OUTsheet.SetCellValue(index, 30, "0");
                    OUTsheet.SetCellValue(index, 31, "False");
                    OUTsheet.SetCellValue(index, 32, "None");
                    OUTsheet.SetCellValue(index, 33, "False");
                    index++;
                }

                string path = ProjectpathOnly + "Export\\" + ProjectName.Remove(ProjectName.IndexOf(".ap15_1"), 7);
                string name = "DBAlarms";
                workbook.SaveToFile(path + "_" + name + ".xlsx", FileFormat.Version2016);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }
    }
}
