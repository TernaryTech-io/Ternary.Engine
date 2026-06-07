using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Contentcomposerprofile
{
    public long Ccprofilenum { get; set; }

    public string? Profilename { get; set; }

    public string? Mwsprocessendpoint { get; set; }

    public long? Flags { get; set; }

    public string? Authtoken { get; set; }
}
