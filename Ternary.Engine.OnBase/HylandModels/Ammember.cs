using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ammember
{
    public long Ammembernum { get; set; }

    public long? Primarycontact { get; set; }

    public long? Usernum { get; set; }

    public long? Flags { get; set; }

    public string? Membertitle { get; set; }

    public string? Memberprefix { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Middlename { get; set; }
}
