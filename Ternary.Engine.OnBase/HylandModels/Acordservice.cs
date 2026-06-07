using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Acordservice
{
    public long Acordservicenum { get; set; }

    public string? Acordservicename { get; set; }

    public long? Acordvendornum { get; set; }

    public long? Reqtmplitemnum { get; set; }

    public long? Resptmplitemnum { get; set; }

    public long? Reqitemtypenum { get; set; }

    public long? Respitemtypenum { get; set; }

    public long? Embeditemtypenum { get; set; }

    public string? Version { get; set; }

    public string? Primaryurl { get; set; }

    public string? Secondaryurl { get; set; }

    public long? Flags { get; set; }

    public string? Reqmethod { get; set; }

    public string? Respmethod { get; set; }

    public string? Wsdlurl { get; set; }

    public string? Respurl { get; set; }

    public long? Streqtmpitemnum { get; set; }

    public long? Strsptmpitemnum { get; set; }
}
