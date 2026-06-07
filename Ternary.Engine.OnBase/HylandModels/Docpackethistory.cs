using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Docpackethistory
{
    public long? Docpacketjobnum { get; set; }

    public long? Packetitemnum { get; set; }

    public string? Packetitemname { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Datecompleted { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }

    public string? Statustext { get; set; }
}
