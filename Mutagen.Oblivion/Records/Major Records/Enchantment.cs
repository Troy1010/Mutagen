﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Oblivion
{
    public partial class Enchantment
    {
        public enum EnchantmentType
        {
            Scroll = 0,
            Staff = 1,
            Weapon = 2,
            Apparel = 4
        }

        [Flags]
        public enum Flag
        {
            ManualEnchantCost = 1
        }
    }
}
