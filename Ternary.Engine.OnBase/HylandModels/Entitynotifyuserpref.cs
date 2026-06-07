using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entitynotifyuserpref
{
    public long Etnotifyprefnum { get; set; }

    public long? Etnotificationnum { get; set; }

    public long? Usernum { get; set; }

    public string? Emailaddress { get; set; }

    public long? Etoptin { get; set; }

    public long? Flags { get; set; }

    public string? Etnotifytestsource { get; set; }

    public long? Etnotifytestoperator { get; set; }

    public string? Etnotifytestvalue { get; set; }

    public string? Etnotifytestfromvalue { get; set; }

    public long? Etnotifyfromtestop { get; set; }

    public long? Etitemid { get; set; }
}
