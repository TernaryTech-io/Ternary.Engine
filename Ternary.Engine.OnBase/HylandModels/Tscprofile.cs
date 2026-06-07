using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tscprofile
{
    public long Profilenum { get; set; }

    public string? Profilename { get; set; }

    public string? Sourcedatasource { get; set; }

    public string? Destinationdatasource { get; set; }

    public string? Diskgrouppath { get; set; }

    public string? Installid { get; set; }

    public long? Flags { get; set; }

    public long? Maxresults { get; set; }

    public long? Evmsetnum { get; set; }
}
