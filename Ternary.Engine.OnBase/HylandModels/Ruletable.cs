using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ruletable
{
    public long Rulenum { get; set; }

    public string? Rulename { get; set; }

    public long? Affirmbutton { get; set; }

    public long? Answerkeytype { get; set; }

    public long? Keyoperator { get; set; }

    public string? Button1text { get; set; }

    public string? Button2text { get; set; }

    public string? Button3text { get; set; }

    public long? Defaultbutton { get; set; }

    public long? Failactionlistnum { get; set; }

    public long? Succactionlistnum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Notetypenum { get; set; }

    public long? Overridekeytype { get; set; }

    public long? Overrideusergroup { get; set; }

    public string? Questiontext { get; set; }

    public string? Ruledesc { get; set; }

    public string? Rulehelp { get; set; }

    public long? Ruletype { get; set; }

    public long? Statenum { get; set; }

    public long? Scope { get; set; }

    public long? Flags { get; set; }

    public string? Dllname { get; set; }

    public string? Functionname { get; set; }

    public string? Addintypeid { get; set; }

    public long? Wfcontenttype { get; set; }

    public long? Configversion { get; set; }

    public long? Subscope { get; set; }
}
