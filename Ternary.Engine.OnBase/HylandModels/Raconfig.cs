using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Raconfig
{
    public long Raconfignum { get; set; }

    public long? Taskreminder { get; set; }

    public long? Claimreminder { get; set; }

    public long? Maxqueryresults { get; set; }

    public string? Raadmgrpemail { get; set; }

    public long? Flags { get; set; }

    public string? Configurl { get; set; }
}
