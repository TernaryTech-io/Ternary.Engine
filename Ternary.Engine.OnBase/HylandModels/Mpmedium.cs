using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpmedium
{
    public long Mpmedianum { get; set; }

    public string? Mpmediaid { get; set; }

    public long? Status { get; set; }

    public long? Convertstatus { get; set; }

    public long? Overlayitemnum { get; set; }

    public long? Startoffset { get; set; }

    public long? Endoffset { get; set; }

    public DateTime? Createdate { get; set; }

    public long? Flags { get; set; }

    public string? Externalmediaid { get; set; }

    public long? Mediaservertype { get; set; }
}
