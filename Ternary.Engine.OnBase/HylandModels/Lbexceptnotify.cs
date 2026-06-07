using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbexceptnotify
{
    public long Exceptnotifynum { get; set; }

    public long? Decisionduration { get; set; }

    public long? Notifyinterval { get; set; }

    public long? Leadtime { get; set; }

    public long? Lockboxnum { get; set; }

    public string? Exceptemail { get; set; }

    public string? Escalateemail { get; set; }

    public long? Exnotifyflag { get; set; }

    public DateTime? Emailtime { get; set; }

    public long? Flags { get; set; }
}
