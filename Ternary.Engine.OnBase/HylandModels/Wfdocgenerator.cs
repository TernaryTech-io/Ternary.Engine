using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfdocgenerator
{
    public long Wfitemgennum { get; set; }

    public string? Docgeneratorname { get; set; }

    public long? Flags { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Statenum { get; set; }

    public long? Generatecount { get; set; }

    public string? Generatecontent { get; set; }
}
