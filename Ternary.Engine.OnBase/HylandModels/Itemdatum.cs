using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Itemdatum
{
    public long Itemnum { get; set; }

    public string? Itemname { get; set; }

    public long? Batchnum { get; set; }

    public long? Status { get; set; }

    public long? Itemtypegroupnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itrevnum { get; set; }

    public DateTime? Itemdate { get; set; }

    public DateTime? Datestored { get; set; }

    public long? Usernum { get; set; }

    public long? Deleteusernum { get; set; }

    public long? Securityvalue { get; set; }

    public string? Doctracenumber { get; set; }

    public long? Institution { get; set; }

    public long? Maxdocrev { get; set; }
}
