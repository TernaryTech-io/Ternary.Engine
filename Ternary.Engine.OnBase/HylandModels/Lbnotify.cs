using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbnotify
{
    public long Batchnum { get; set; }

    public DateTime? Emailtime { get; set; }

    public long? Notifyinterval { get; set; }

    public string? Email { get; set; }
}
