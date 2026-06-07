using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Volumerequest
{
    public long Requestnum { get; set; }

    public long? Mpinum { get; set; }

    public long? Mrnum { get; set; }

    public DateTime? Daterequired { get; set; }

    public long? Repositorynum { get; set; }

    public long? Requestingusernum { get; set; }

    public string? Vrrequestorname { get; set; }

    public string? Vrrequestorphone { get; set; }

    public long? Volumereqcodenum { get; set; }

    public DateTime? Requestdate { get; set; }

    public long? Numberofdays { get; set; }

    public long? Unitnum { get; set; }

    public string? Chtdestlocation { get; set; }

    public string? Delivinstructions { get; set; }

    public long? Itemnum { get; set; }

    public long? Printitemnum { get; set; }
}
