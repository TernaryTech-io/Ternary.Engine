using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lockkey
{
    public long Producttype { get; set; }

    public long Registernum { get; set; }

    public long Keynum { get; set; }

    public long Keykeytype { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Locktime { get; set; }

    public long? Sessionid { get; set; }
}
