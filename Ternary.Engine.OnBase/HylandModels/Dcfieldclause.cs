using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcfieldclause
{
    public long? Dctemplatefldnum { get; set; }

    public long? Valfieldnum { get; set; }

    public long? Valtemplatenum { get; set; }

    public string? Conditiontext { get; set; }

    public string? Staticclausetext { get; set; }

    public long? Conditiontype { get; set; }

    public long? Actiontype { get; set; }

    public long? Keytypenum { get; set; }

    public long? Flags { get; set; }

    public long? Truefldclausenum { get; set; }

    public long? Falsefldclausenum { get; set; }

    public long? Dcfieldsourcenum { get; set; }

    public long Dcfieldclausenum { get; set; }
}
