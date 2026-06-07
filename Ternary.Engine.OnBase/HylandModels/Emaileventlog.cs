using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emaileventlog
{
    public long Emaileventnum { get; set; }

    public string? Emailaction { get; set; }

    public DateTime? Eventdate { get; set; }

    public string? Eventmessage { get; set; }

    public long? Emailcount { get; set; }
}
