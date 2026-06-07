using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Atstephist
{
    public long? Atstepexecnum { get; set; }

    public long? Atprogramexecnum { get; set; }

    public long? Atstepnum { get; set; }

    public long? Atprogramnum { get; set; }

    public long? Atstepgroupnum { get; set; }

    public DateTime? Datecompleted { get; set; }

    public long? Status { get; set; }

    public long? Priority { get; set; }

    public long? Seqnum { get; set; }

    public long? Institution { get; set; }

    public long? Steptype { get; set; }

    public string? Messagetext { get; set; }

    public long? Atgroupexecnum { get; set; }
}
