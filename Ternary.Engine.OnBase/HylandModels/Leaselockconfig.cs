using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Leaselockconfig
{
    public long Locktype { get; set; }

    public long? Leasetimeseconds { get; set; }

    public long? Leaseheartbeatseconds { get; set; }
}
