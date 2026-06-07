using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entitynotification
{
    public long Etnotificationnum { get; set; }

    public long? Etnotificationmethod { get; set; }

    public string? Etnotificationname { get; set; }

    public string? Etdescription { get; set; }

    public long? Etownertype { get; set; }

    public long? Etownerid { get; set; }

    public long? Etnotifytesttype { get; set; }

    public string? Etnotifytestsource { get; set; }

    public long? Etnotifytestoperator { get; set; }

    public string? Etnotifytestvalue { get; set; }

    public long? Etiterationflags { get; set; }

    public string? Etrecipients { get; set; }

    public long? Etdeliveryflags { get; set; }

    public long? Flags { get; set; }

    public long? Etresourcenum { get; set; }

    public string? Etnotifytestfromvalue { get; set; }

    public long? Etnotifyfromtestop { get; set; }

    public string? Entitytext { get; set; }

    public long? Etminschemaver { get; set; }

    public long? Etmaxschemaver { get; set; }

    public long? Etpatchverdelta { get; set; }
}
