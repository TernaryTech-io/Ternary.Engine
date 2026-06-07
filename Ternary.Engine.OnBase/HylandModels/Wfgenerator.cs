using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfgenerator
{
    public long Wfgeneratornum { get; set; }

    public string? Generatorname { get; set; }

    public string? Generatordesc { get; set; }

    public long? Generatortype { get; set; }

    public long? Lcnum { get; set; }

    public long? Statenum { get; set; }

    public long? Generatorcount { get; set; }

    public DateTime? Entrytoqueuedate { get; set; }

    public long? Flags { get; set; }

    public DateTime? Entrytoqueuedate2 { get; set; }
}
