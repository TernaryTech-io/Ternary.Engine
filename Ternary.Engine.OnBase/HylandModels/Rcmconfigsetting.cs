using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmconfigsetting
{
    public string? Rcmusername { get; set; }

    public string? Rcmpassword { get; set; }

    public string? Rcmdatasource { get; set; }

    public long? Rcmgroupnum { get; set; }

    public long? Encryptiontype { get; set; }

    public string? Gcsprefix { get; set; }
}
