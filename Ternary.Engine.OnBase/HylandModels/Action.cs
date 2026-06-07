using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Action
{
    public long Actionnum { get; set; }

    public string? Actionname { get; set; }

    public string? Actiondesc { get; set; }

    public string? Actionhelp { get; set; }

    public long? Actiontype { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Keytypenum { get; set; }

    public long? Keyoperator { get; set; }

    public string? Keyvaluechar { get; set; }

    public long? Keywordnum { get; set; }

    public long? Lcnum { get; set; }

    public long? Notetypenum { get; set; }

    public long? Notilistnum { get; set; }

    public long? Statenumfrom { get; set; }

    public long? Statenumto { get; set; }

    public long? Rulenum { get; set; }

    public long? Scope { get; set; }

    public long? Flags { get; set; }

    public long? Formnum { get; set; }

    public string? Dllname { get; set; }

    public string? Functionname { get; set; }

    public long? Keytypenum2 { get; set; }

    public long? Pqueuenum { get; set; }

    public long? Flags2 { get; set; }

    public string? Addintypeid { get; set; }

    public long? Wfcontenttype { get; set; }

    public long? Configversion { get; set; }

    public long? Subscope { get; set; }
}
