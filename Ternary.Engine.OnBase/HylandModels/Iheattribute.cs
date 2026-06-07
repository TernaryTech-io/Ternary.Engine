using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Iheattribute
{
    public long Iheattributenum { get; set; }

    public string? Iheattributedisplayname { get; set; }

    public string? Iheattributename { get; set; }

    public long? Iheparentattribute { get; set; }

    public long? Ihecontext { get; set; }

    public long? Iheattributetype { get; set; }

    public long? Flags { get; set; }

    public string? Iheattributevalue { get; set; }
}
