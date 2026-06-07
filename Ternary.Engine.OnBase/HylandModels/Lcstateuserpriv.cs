using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lcstateuserpriv
{
    public long Statenum { get; set; }

    public long Usernum { get; set; }

    public long? Userprivilege0 { get; set; }

    public long? Cqnum { get; set; }

    public long? Flags { get; set; }
}
