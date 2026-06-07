using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Racomtracking
{
    public long Racomtrackingnum { get; set; }

    public long? Racclaimnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Racontactnum { get; set; }

    public string? Raccommsubject { get; set; }

    public string? Raccommtext { get; set; }

    public long? Ractype { get; set; }

    public long? Flags { get; set; }

    public long? Seqnum { get; set; }
}
