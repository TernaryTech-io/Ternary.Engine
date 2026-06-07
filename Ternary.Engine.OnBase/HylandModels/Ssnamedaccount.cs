using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ssnamedaccount
{
    public long Namedaccountnum { get; set; }

    public long? Infosourcenum { get; set; }

    public string? Mailboxname { get; set; }

    public long? Uniditemtypenum { get; set; }

    public long? Namedacctflags { get; set; }
}
