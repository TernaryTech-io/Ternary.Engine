using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Trashcan
{
    public long Itemnum { get; set; }

    public string? Itemname { get; set; }

    public long? Usernum { get; set; }

    public string? Username { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Itemtypename { get; set; }

    public DateTime? Datedeleted { get; set; }

    public long? Batchnum { get; set; }
}
