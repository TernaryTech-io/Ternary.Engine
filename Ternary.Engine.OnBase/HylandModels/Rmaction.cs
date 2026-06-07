using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmaction
{
    public long Actionid { get; set; }

    public string? Rmactionname { get; set; }

    public long? Actiontype { get; set; }

    public long? Bsharable { get; set; }

    public string? Cmdtext { get; set; }

    public string? Rmdescription { get; set; }

    public long? Largeimagenum { get; set; }

    public long? Smallimagenum { get; set; }

    public string? Uieffect { get; set; }

    public long? Flags { get; set; }
}
