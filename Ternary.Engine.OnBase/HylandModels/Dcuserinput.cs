using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dcuserinput
{
    public long Dcuserinputnum { get; set; }

    public long? Dctemplatenum { get; set; }

    public long? Userinputtype { get; set; }

    public string? Inputname { get; set; }

    public string? Prompttext { get; set; }

    public long? Itemnum { get; set; }
}
