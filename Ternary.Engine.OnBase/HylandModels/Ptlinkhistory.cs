using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ptlinkhistory
{
    public long? Mpinum { get; set; }

    public long? Mrnum { get; set; }

    public string? Delmpinumber { get; set; }

    public string? Delmedrecnumber { get; set; }

    public string? Delptfirstname { get; set; }

    public string? Delptlastname { get; set; }

    public DateTime? Delptdob { get; set; }

    public string? Delptssn { get; set; }

    public long? Delptsex { get; set; }

    public DateTime? Changedate { get; set; }

    public long? Changeusernum { get; set; }
}
