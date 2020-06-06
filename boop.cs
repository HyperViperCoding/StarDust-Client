﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarDust_Sharp.Memory.FlameSDK
{
    public class PlayerEntity : Mob
    {
        public PlayerEntity(UInt64 addr) : base(addr)
        {
        }

        public string PlayerEntity.username
        {
            get
            {
                return MCM.readString(addr+ 0xA18, 20);
            }
        }
    }
}
