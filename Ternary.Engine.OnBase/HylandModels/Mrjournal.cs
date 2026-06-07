using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mrjournal
{
    public long Mrjournalnum { get; set; }

    public long? Objectid { get; set; }

    public long? Objecttypeid { get; set; }

    public string? Mrnotetext { get; set; }

    public long? Createusernum { get; set; }

    public DateTime? Datecreated { get; set; }
}
