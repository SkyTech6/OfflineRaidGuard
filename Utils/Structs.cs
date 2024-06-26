﻿using System;
using System.Collections.Generic;
using Unity.Entities;

namespace OfflineRaidGuard.Utils;

public struct PlayerGroup
{
    public int AllyCount { get; set; }
    public List<Entity> Allies { get; set; }
    public DateTime TimeStamp { get; set; }

    public PlayerGroup(int allyCount = 0, List<Entity> allies = default, DateTime timeStamp = default)
    {
        AllyCount = allyCount;
        Allies = allies;
        TimeStamp = timeStamp;
    }
}
