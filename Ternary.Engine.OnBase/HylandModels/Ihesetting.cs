using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ihesetting
{
    public long Ihesettingnum { get; set; }

    public long? Ihecommunitynum { get; set; }

    public long? Settingnum { get; set; }

    public string? Settingvalue { get; set; }

    public long? Flags { get; set; }
}
