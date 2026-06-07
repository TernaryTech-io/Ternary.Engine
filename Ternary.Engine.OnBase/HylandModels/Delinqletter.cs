using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Delinqletter
{
    public long? Facilitynum { get; set; }

    public long? Daysdelinquent { get; set; }

    public string? Dellettername { get; set; }

    public string? Fullfilepath { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Keytypenum { get; set; }

    public long? Titlefontnum { get; set; }

    public long? Bodyfontnum { get; set; }

    public long? Addressfontnum { get; set; }

    public long? Addresslocation { get; set; }

    public long Delinqletternum { get; set; }

    public long? Delinqlevel { get; set; }

    public long? Delinqgrouping { get; set; }
}
