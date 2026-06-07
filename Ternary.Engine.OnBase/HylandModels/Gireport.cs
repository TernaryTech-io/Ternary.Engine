using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gireport
{
    public long Gireportnum { get; set; }

    public long? Giprocedurenum { get; set; }

    public long? Rptrevnum { get; set; }

    public long? Gidetailprocnum { get; set; }

    public long? Giasaclassnum { get; set; }

    public long? Giprepqualitynum { get; set; }

    public long? Status { get; set; }

    public long? Flags { get; set; }

    public DateTime? Finalizeddate { get; set; }

    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public string? Gireportname { get; set; }
}
