using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Spsdocument
{
    public long Spsdocnum { get; set; }

    public long? Spsconfignum { get; set; }

    public long? Spslistitemid { get; set; }

    public long? Spsitemrev { get; set; }

    public long? Itemnum { get; set; }

    public string? Filetypeext { get; set; }

    public long? Flags { get; set; }

    public string? Listitemuniqueid { get; set; }
}
