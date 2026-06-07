using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bpmnprocesspartnerlink
{
    public long? Processnum { get; set; }

    public long? Versionnum { get; set; }

    public long? Partnerlinknum { get; set; }

    public long? Webservicenum { get; set; }

    public string? Partnerlinkname { get; set; }

    public string? Partnerlinktype { get; set; }

    public string? Myrole { get; set; }

    public string? Partnerrole { get; set; }

    public long? Flags { get; set; }
}
