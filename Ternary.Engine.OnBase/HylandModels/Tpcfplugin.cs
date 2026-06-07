using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tpcfplugin
{
    public long Tpcfpluginnum { get; set; }

    public long? Diskgroupnum { get; set; }

    public string? Plugin { get; set; }

    public long? Flags { get; set; }

    public string? Pluginversion { get; set; }

    public string? Pluginchecksum { get; set; }

    public long? Filesize { get; set; }

    public long? Plugintype { get; set; }
}
