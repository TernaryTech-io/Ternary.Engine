using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Srvcfeedbackdatum
{
    public string? Srvcrequest { get; set; }

    public long? Srvccount { get; set; }

    public DateTime? Lastcalled { get; set; }

    public string? Srvcrequesthash { get; set; }
}
