using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplanhistory
{
    public long Ephistorynum { get; set; }

    public long? Epprojectnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Datecreated { get; set; }

    public long? Epeventid { get; set; }

    public string? Epeventdetails { get; set; }

    public long? Flags { get; set; }
}
