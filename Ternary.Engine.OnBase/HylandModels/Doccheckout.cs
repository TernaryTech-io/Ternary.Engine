using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doccheckout
{
    public long Docrevnum { get; set; }

    public long Itemnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Checkouttime { get; set; }

    public long? Sessionid { get; set; }
}
