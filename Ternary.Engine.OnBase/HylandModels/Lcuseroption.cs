using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lcuseroption
{
    public long Usernum { get; set; }

    public long Statenum { get; set; }

    public long? Flags { get; set; }

    public long? Cqnum { get; set; }
}
