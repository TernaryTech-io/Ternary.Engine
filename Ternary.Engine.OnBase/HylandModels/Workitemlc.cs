using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Workitemlc
{
    public long Lcnum { get; set; }

    public long Statenum { get; set; }

    public long Contentnum { get; set; }

    public long Wfcontenttype { get; set; }

    public DateTime? Transdate { get; set; }

    public long? Priority { get; set; }

    public long? Versionid { get; set; }

    public long? Ownernum { get; set; }

    public long? Ownedstatus { get; set; }

    public DateTime? Ownedsince { get; set; }

    public DateTime? Lastupdated { get; set; }

    public long? Flags { get; set; }

    public long? Contentclassnum { get; set; }
}
