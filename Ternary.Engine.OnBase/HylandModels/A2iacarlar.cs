using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class A2iacarlar
{
    public long Carlarnum { get; set; }

    public string? Carlarprocessname { get; set; }

    public string? Parameterfilepath { get; set; }

    public string? Doctablefilepath { get; set; }

    public long? Highwatermark { get; set; }

    public long? Notilistnum { get; set; }

    public long? Notilistnumout { get; set; }

    public long? Optionflags { get; set; }

    public string? Licenseserver { get; set; }
}
