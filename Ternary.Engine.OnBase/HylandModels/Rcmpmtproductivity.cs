using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rcmpmtproductivity
{
    public long? Batchnum { get; set; }

    public long? Usernum { get; set; }

    public long? Beginningqueue { get; set; }

    public DateTime? Datetimein { get; set; }

    public DateTime? Datetimeout { get; set; }

    public long? Destinationqueue { get; set; }

    public long? Numberclaimscreated { get; set; }

    public long? Numberclaimsedited { get; set; }

    public long? Numberclaimsdeleted { get; set; }

    public long? Numberdetailscreated { get; set; }

    public long? Numberdetailsedited { get; set; }

    public long? Numberdetailsdeleted { get; set; }
}
