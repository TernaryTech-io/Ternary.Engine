using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Codingnotetempl
{
    public long Cdgnotetemplnum { get; set; }

    public string? Cdgnotetemplname { get; set; }

    public string? Codingnotetitle { get; set; }

    public string? Entrytext { get; set; }

    public long? Userprivilege { get; set; }

    public long? Flags { get; set; }
}
