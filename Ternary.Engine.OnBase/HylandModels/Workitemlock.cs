using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Workitemlock
{
    public long Contentnum { get; set; }

    public long Contentclassnum { get; set; }

    public long Wfcontenttype { get; set; }

    public long Statenum { get; set; }

    public long? Locktype { get; set; }

    public long? Usernum { get; set; }

    public long? Sessionid { get; set; }

    public DateTime? Locktime { get; set; }

    public long? Flags { get; set; }

    public long? Registernum { get; set; }
}
