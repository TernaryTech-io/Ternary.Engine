using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Advancedstate
{
    public long Statenum { get; set; }

    public long Usernum { get; set; }

    public long? Percentofdocs { get; set; }

    public string Keywordvalue { get; set; } = null!;

    public long? Keyoperator { get; set; }

    public long? Keytypenum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Institution { get; set; }

    public long? Keytypenum2 { get; set; }

    public long? Exceptionstatenum { get; set; }
}
