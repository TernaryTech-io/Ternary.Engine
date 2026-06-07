using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Configlogdetail
{
    public long? Configurationlognum { get; set; }

    public long? Seqnum { get; set; }

    public string? Configfieldname { get; set; }

    public string? Configfieldconstant { get; set; }

    public string? Valuebefore { get; set; }

    public string? Valueafter { get; set; }

    public long? Objectid { get; set; }

    public long? Subtypeid { get; set; }

    public string? Groupnamefieldconstant { get; set; }
}
