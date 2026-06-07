using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Emailarchive
{
    public long Emailarchivenum { get; set; }

    public string? Dblogicalname { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Dbservername { get; set; }

    public string? Connectstring { get; set; }

    public string? Dbversion { get; set; }

    public long? Dbonline { get; set; }

    public long? Standardlogin { get; set; }
}
