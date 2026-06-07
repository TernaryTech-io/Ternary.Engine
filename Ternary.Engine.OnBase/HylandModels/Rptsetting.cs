using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rptsetting
{
    public long? Databasetimeout { get; set; }

    public string? Reportingdatasource { get; set; }

    public long? Overridemaxrowlimit { get; set; }

    public long? Overridecachettl { get; set; }

    public long? Sqlselectlistcachettl { get; set; }

    public long? Maxconcurrentrequests { get; set; }

    public long Settingnum { get; set; }
}
