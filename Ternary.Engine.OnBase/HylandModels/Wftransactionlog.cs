using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wftransactionlog
{
    public long Wftransactionnum { get; set; }

    public long? Lcnum { get; set; }

    public long? Statenum { get; set; }

    public long? Itemnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Logdate { get; set; }

    public long? Objecttype { get; set; }

    public long? Objectnum { get; set; }

    public long? Param1 { get; set; }

    public long? Param2 { get; set; }

    public long? Flags { get; set; }

    public string? Objectname { get; set; }

    public long? Wfcontenttype { get; set; }

    public long? Contentclassnum { get; set; }
}
