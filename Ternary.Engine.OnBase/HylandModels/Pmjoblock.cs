using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Pmjoblock
{
    public long? Pmlocktype { get; set; }

    public long? Keypart1 { get; set; }

    public long? Keypart2 { get; set; }

    public long? Keypart3 { get; set; }

    public DateTime? Acquiretime { get; set; }

    public DateTime? Lastheartbeat { get; set; }

    public long? Updateseq { get; set; }

    public long? Registernum { get; set; }

    public long? Usernum { get; set; }

    public long? Sessionid { get; set; }
}
