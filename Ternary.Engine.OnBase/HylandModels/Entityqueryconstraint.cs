using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entityqueryconstraint
{
    public long Entityquerycstnum { get; set; }

    public long? Entityquerynum { get; set; }

    public string? Etfieldaddress { get; set; }

    public long? Etoperator { get; set; }

    public long? Etconnector { get; set; }

    public long? Etleftparen { get; set; }

    public long? Etrightparen { get; set; }

    public long? Seqnum { get; set; }

    public string? Etvalue { get; set; }

    public long? Flags { get; set; }

    public long? Etminschemaver { get; set; }

    public long? Etmaxschemaver { get; set; }

    public long? Etpatchverdelta { get; set; }
}
