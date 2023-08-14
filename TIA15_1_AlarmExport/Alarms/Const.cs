using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIA15_1_AlarmExport
{
    public enum PanelType {WinccAdvance, WinccUnified };
    
    public static class Const
    {
        public static String PanelTypeAlarmTagType(PanelType Type)
        {
            switch (Type)
            {
                case PanelType.WinccAdvance:
                    return "array[0..1] of int";
                case PanelType.WinccUnified:
                    return "Dword";
            }
            return "array[0..1] of int";

        }

    }
}
