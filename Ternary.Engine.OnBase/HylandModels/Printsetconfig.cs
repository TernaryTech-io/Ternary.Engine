using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Printsetconfig
{
    public long Printsetnum { get; set; }

    public string? Printsetname { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Customerkey { get; set; }

    public long? Accountnumkey { get; set; }

    public long? Namekey { get; set; }

    public long? Fromdatekey { get; set; }

    public long? Todatekey { get; set; }

    public long? Omrmarkerkey { get; set; }

    public long? Postnetkey { get; set; }

    public long? Institutionkey { get; set; }
}
