using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class M2wparameterconfig
{
    public long Mwparameternum { get; set; }

    public string? Mwparametername { get; set; }

    public long? Satisfyfromcode { get; set; }

    public string? Parainputsource { get; set; }

    public string? Parameterdefault { get; set; }

    public long? Parametertypecode { get; set; }

    public long? Userpromptnum { get; set; }

    public string? Contextsource { get; set; }

    public long? Fromtypecode { get; set; }

    public long? Totypecode { get; set; }

    public string? Paramformat { get; set; }

    public long? Flags { get; set; }
}
