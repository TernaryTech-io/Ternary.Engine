using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mbofflineobject
{
    public long Offlineobjectnum { get; set; }

    public long? Hylandobjectnum { get; set; }

    public long? Mobiledevicenum { get; set; }

    public long? Objectstatus { get; set; }

    public long? Transferstatus { get; set; }

    public long? Lastupdatedate { get; set; }

    public long? Flags { get; set; }
}
