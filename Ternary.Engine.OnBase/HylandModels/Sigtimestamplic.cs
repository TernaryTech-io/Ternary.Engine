using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sigtimestamplic
{
    public long Sigtslicensenum { get; set; }

    public string? Sigtsusername { get; set; }

    public string? Sigtspassword { get; set; }

    public long? Expired { get; set; }

    public long? Flags { get; set; }

    public long? Sigcount { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
