using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Searchspacehist
{
    public long? Searchspacenum { get; set; }

    public string? Emailsubject { get; set; }

    public DateTime? Datemodified { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public long? Flags { get; set; }

    public string? Reciplist { get; set; }
}
