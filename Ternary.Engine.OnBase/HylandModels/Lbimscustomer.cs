using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbimscustomer
{
    public long Customernum { get; set; }

    public string? Customername { get; set; }

    public long? Usernum { get; set; }

    public long? Maxcustomerusers { get; set; }

    public long? Flags { get; set; }

    public long? Passwordflags { get; set; }

    public long? Minusernamelen { get; set; }

    public long? Minpasswordlen { get; set; }

    public long? Maxpasswordlen { get; set; }

    public long? Passwordexpires { get; set; }

    public long? Maxnologon { get; set; }

    public long? Resultschunk { get; set; }

    public long? Docresultschunk { get; set; }

    public long? Usergroupnum { get; set; }
}
