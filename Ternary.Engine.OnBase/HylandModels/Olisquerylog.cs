using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Olisquerylog
{
    public long? Olissessionnum { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Ptfullname { get; set; }

    public string? Olispatientid { get; set; }

    public string? Practitionerfullname { get; set; }

    public string? Practitionerid { get; set; }

    public string? Overridecomment { get; set; }

    public long? Overridereason { get; set; }
}
