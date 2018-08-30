using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public sealed class ScreenEffectEntry
    {
        public string Name;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] Param;
        public sbyte Effect;
        public uint FullScreenEffectID;
        public ushort LightParamsID;
        public ushort LightParamsFadeIn;
        public ushort LightParamsFadeOut;
        public uint SoundAmbienceID;
        public uint ZoneMusicID;
        public short TimeOfDayOverride;
        public sbyte EffectMask;
        public byte LightFlags;
    }
}
