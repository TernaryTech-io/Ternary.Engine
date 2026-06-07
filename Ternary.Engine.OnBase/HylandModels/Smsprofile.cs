using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Smsprofile
{
    public long Smsprofilenum { get; set; }

    public string? Profilename { get; set; }

    public long? Smsacctnum { get; set; }

    public string? Fromphonenumber { get; set; }

    public long? Flags { get; set; }

    public string? Tmburl { get; set; }
}
