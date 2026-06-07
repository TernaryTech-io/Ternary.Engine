using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimsusergroup
{
    public long Usergroupnum { get; set; }

    public string? Usergroupname { get; set; }

    public long? Customernum { get; set; }

    public long? Userprivilege0 { get; set; }

    public long? Resultschunk { get; set; }

    public long? Docresultschunk { get; set; }

    public long? Maxresults { get; set; }

    public long? Maxdocresults { get; set; }
}
