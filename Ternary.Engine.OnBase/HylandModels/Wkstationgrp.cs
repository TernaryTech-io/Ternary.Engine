using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wkstationgrp
{
    public long Wkstationgrpnum { get; set; }

    public string? Wkstationgrpname { get; set; }

    public string? Wkstationgrpdesc { get; set; }

    public long? Wkstationflags { get; set; }

    public long? Cachenum { get; set; }

    public long? Exeupdate { get; set; }

    public string? Exeupdatepath { get; set; }

    public long? Exeupdateflags { get; set; }
}
