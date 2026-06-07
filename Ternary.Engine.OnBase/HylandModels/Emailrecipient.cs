using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emailrecipient
{
    public long Emailrecipnum { get; set; }

    public string? Localpart { get; set; }

    public string? Domain { get; set; }

    public string? Emaildisplayname { get; set; }

    public long? Usernum { get; set; }
}
