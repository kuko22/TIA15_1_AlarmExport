using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siemens.Engineering;
using Siemens.Engineering.HW;
using Siemens.Engineering.SW;
using Siemens.Engineering.SW.Types;
using Siemens.Engineering.SW.Blocks;
using Siemens.Engineering.Hmi;
using Siemens.Engineering.HW.Features;


namespace TIA15_1_AlarmExport
{
    public partial class Form1
    {
        List<PlcType> UDT_Alarms;
        List<PlcBlock> DB_Alarms;
        DataBlock DB_Alarm;

        private List<PlcType> ReadTypeWithName(string name, PlcTypeUserGroupComposition Groups)
        {
            List<PlcType> _listPLCtype = new List<PlcType>();
            foreach (PlcTypeUserGroup userGroup in Groups)
            {
                foreach (PlcType type in userGroup.Types)
                {
                    if (type.Name.Contains(name))
                    {
                        _listPLCtype.Add(type);
                    }
                }
                _listPLCtype.AddRange(ReadTypeWithName("UDT_Alarms_", userGroup));
            }
            return _listPLCtype;
        }
        private List<PlcType> ReadTypeWithName(string name, PlcTypeUserGroup Groups)
        {
            List<PlcType> _listPLCtype = new List<PlcType>();
            foreach (PlcType type in Groups.Types)
            {
                if (type.Name.Contains(name))
                {
                    _listPLCtype.Add(type);
                }
            }
            _listPLCtype.AddRange(ReadTypeWithName("UDT_Alarms_", Groups.Groups));
            return _listPLCtype;
        }


        private List<PlcBlock> ReadPLCblocks(string name, PlcBlockUserGroupComposition group)
        {
            List<PlcBlock> data = new List<PlcBlock>();

            foreach (PlcBlockUserGroup v in group)
            {
                data.AddRange(ReadPLCblocks(name, v.Blocks));
                data.AddRange(ReadPLCblocks(name, v.Groups));
            }
            return data;
        }
        private List<PlcBlock> ReadPLCblocks(string name, PlcBlockComposition group)
        {
            List<PlcBlock> data = new List<PlcBlock>();
            foreach (PlcBlock v in group)
            {
                if (v.ProgrammingLanguage == ProgrammingLanguage.DB && v.Name.Contains(name))
                    data.Add(v);
            }
            return data;

        }

        private string CheckName(string s)
        {
            string ns = "_" + s.ToUpper().Replace('-', '_').Replace('.', '_').Replace('#', '_').Replace(' ', '_').Replace('+', '_').Replace('=', '_').Replace('/', '_').Replace('\\', '_').Replace('*', '_');
            return ns;
        }
        public static PlcSoftware GetPlcSoftware(Device device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device), "Parameter is null");
            //if (device.Subtype.ToLower().Contains("sinamics"))
            //    return null;

            var itemStack = new Stack<DeviceItem>();
            foreach (var item in device.DeviceItems)
            {
                itemStack.Push(item);
            }

            while (itemStack.Any())
            {
                var item = itemStack.Pop();

                var target = item.GetService<SoftwareContainer>();
                if (target != null && target.Software is PlcSoftware)
                {
                    return (PlcSoftware)target.Software;
                }

                foreach (var subItem in item.DeviceItems)
                {
                    itemStack.Push(subItem);
                }
            }

            return null;
        }

        public static HmiTarget GetHmiTarget(Device device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device), "Parameter is null");
            //if (device.Subtype.ToLower().Contains("sinamics"))
            //    return null;

            var itemStack = new Stack<DeviceItem>();
            foreach (var item in device.DeviceItems)
            {
                itemStack.Push(item);
            }

            while (itemStack.Any())
            {
                var item = itemStack.Pop();

                var target = item.GetService<SoftwareContainer>();
                if (target != null && target.Software is HmiTarget)
                {
                    return (HmiTarget)target.Software;
                }

                foreach (var subItem in item.DeviceItems)
                {
                    itemStack.Push(subItem);
                }
            }

            return null;
        }
    }
}
