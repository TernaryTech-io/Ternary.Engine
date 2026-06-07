using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Xferpackageconfig
{
    public long Xferpackagenum { get; set; }

    public string? Packagename { get; set; }

    public string? Serverpackageid { get; set; }

    public long? Fileidversion { get; set; }

    public long? Browsebyall { get; set; }

    public long? Flags { get; set; }

    public string? Configxml { get; set; }

    public long? Formitemnum { get; set; }

    public string? Autonamestring { get; set; }
}
