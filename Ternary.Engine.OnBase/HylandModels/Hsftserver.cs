using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hsftserver
{
    public long? Ftserverid { get; set; }

    public string? Ftserveraddress { get; set; }

    public string? Serverfriendlyname { get; set; }

    public long? Handlertype { get; set; }

    public string? Path { get; set; }

    public string? Uncpath { get; set; }

    public long? Maxresults { get; set; }

    public long? Minscore { get; set; }

    public long? Flags1 { get; set; }

    public long? Flags2 { get; set; }

    public long? Flags3 { get; set; }

    public long Ftservernum { get; set; }

    public long? Flags { get; set; }

    public DateTime? Ftserverheartbeat { get; set; }
}
