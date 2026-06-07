using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Xferpackageinfo
{
    public long Xferpackagenum { get; set; }

    public string? Packagename { get; set; }

    public string? Serverpackageid { get; set; }

    public long? Xferreceivernum { get; set; }

    public long? Cqnum { get; set; }

    public long? Eformitemtypenum { get; set; }

    public long? Envelopenum { get; set; }

    public string? Recipaddress { get; set; }

    public string? Emailaddress { get; set; }

    public string? Configxml { get; set; }

    public long? Fileidversion { get; set; }

    public long? Flags { get; set; }

    public string? Autonamestring { get; set; }

    public long? Maxpackagesize { get; set; }
}
