﻿namespace SpellWork.DBC.Structures
{
    public sealed class SpellXSpellVisualEntry
    {
        public int ID;
        public byte DifficultyID;
        public uint SpellVisualID;
        public float Probability;
        public byte Flags;
        public byte Priority;
        public int SpellIconFileID;
        public int ActiveIconFileID;
        public ushort ViewerUnitConditionID;
        public uint ViewerPlayerConditionID;
        public ushort CasterUnitConditionID;
        public uint CasterPlayerConditionID;
        public int SpellID;
    }
}
