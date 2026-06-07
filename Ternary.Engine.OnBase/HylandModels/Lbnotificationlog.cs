using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbnotificationlog
{
    public long? Lockboxnum { get; set; }

    public long? Lbeventnum { get; set; }

    public DateTime? Notificationdate { get; set; }

    public long? Flags { get; set; }
}
