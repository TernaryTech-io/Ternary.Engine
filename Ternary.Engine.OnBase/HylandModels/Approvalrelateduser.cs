using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Approvalrelateduser
{
    public long? Usernum { get; set; }

    public long? Approvalprocnum { get; set; }

    public long? Relatedusernum { get; set; }

    public long? Purpose { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public long? Flags { get; set; }
}
