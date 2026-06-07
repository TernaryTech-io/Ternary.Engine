using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Securityquestionset
{
    public long Secquestionsetnum { get; set; }

    public string? Secquestionsetname { get; set; }

    public long? Numconfig { get; set; }

    public long? Numrequired { get; set; }

    public long? Sectype { get; set; }

    public long? Flags { get; set; }

    public long? Numallowedfails { get; set; }
}
