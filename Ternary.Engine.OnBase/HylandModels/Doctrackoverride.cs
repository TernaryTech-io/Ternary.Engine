using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doctrackoverride
{
    public long Foldernum { get; set; }

    public long Itemtypenum { get; set; }

    public long? Numtracked { get; set; }

    public long? Optionaltracking { get; set; }

    public long? Docduedateoverride { get; set; }

    public long? Docexpiredateoverride { get; set; }

    public long? Dueperiod { get; set; }

    public long? Expirationperiod { get; set; }

    public long? Warningperiod { get; set; }

    public long? Expirationcycle { get; set; }

    public DateTime? Expiredate { get; set; }

    public long? Expirationtype { get; set; }

    public long? Flags { get; set; }
}
