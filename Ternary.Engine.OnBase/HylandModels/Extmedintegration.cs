using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Extmedintegration
{
    public long Extmednum { get; set; }

    public string? Extmedservicetype { get; set; }

    public string? Connprotocol { get; set; }

    public string? Dbservername { get; set; }

    public string? Connectstring { get; set; }

    public DateTime? Lastpolltime { get; set; }

    public string? Defdirname { get; set; }

    public string? Deffilename { get; set; }

    public long? Processtype { get; set; }

    public long? Extsystemnum { get; set; }
}
