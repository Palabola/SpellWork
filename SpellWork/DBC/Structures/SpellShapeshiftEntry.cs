using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public class SpellShapeshiftEntry
    {
        public int SpellID;
        public sbyte StanceBarOrder;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] ShapeshiftExclude;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] ShapeshiftMask;
    }
}
