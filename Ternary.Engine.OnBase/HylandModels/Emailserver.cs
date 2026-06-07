using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emailserver
{
    public string Emailservername { get; set; } = null!;

    public DateTime? Laststarttime { get; set; }

    public DateTime? Lastshutdown { get; set; }

    public string? Profileusername { get; set; }

    public string? Profilepassword { get; set; }
}
