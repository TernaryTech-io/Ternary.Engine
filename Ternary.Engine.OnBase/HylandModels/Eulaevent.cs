using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eulaevent
{
    public long? Action { get; set; }

    public DateTime? Eventdate { get; set; }

    public string? Appversion { get; set; }

    public long? Majorversion { get; set; }

    public string? Username { get; set; }
}
