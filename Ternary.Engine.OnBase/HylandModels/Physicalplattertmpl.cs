using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Physicalplattertmpl
{
    public long Physicalplatternum { get; set; }

    public long Diskgroupnum { get; set; }

    public string? Physicalplattername { get; set; }

    public long? Plattertype { get; set; }

    public long? Blocksize { get; set; }

    public long? Maxlogicalplatter { get; set; }

    public long? Minlogicalplatter { get; set; }

    public string? Ftpfilepath { get; set; }

    public string? Ftpusername { get; set; }

    public string? Ftppassword { get; set; }

    public long? Plattertype2 { get; set; }

    public long? Storagesystem { get; set; }
}
