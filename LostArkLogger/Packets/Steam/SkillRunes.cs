using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class SkillRunes
    {
        public void SteamDecode(BitReader reader)
        {
            num = reader.ReadUInt16();
            for(var i = 0; i < num; i++)
            {
                u32list.Add(reader.ReadList<UInt32>());
                u32.Add(reader.ReadUInt32());
            }
        }
    }
}