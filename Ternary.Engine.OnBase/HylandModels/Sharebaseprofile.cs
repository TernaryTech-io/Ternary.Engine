using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sharebaseprofile
{
    public long Sbprofilenum { get; set; }

    public string? Profilename { get; set; }

    public string? Authtoken { get; set; }

    public long? Defaultlibraryid { get; set; }

    public string? Sharebaseurl { get; set; }

    public long? Flags { get; set; }

    public string? Webhookurl { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
