using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Xferfiletypemap
{
    public long? Xfersitenum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Remotefiletypenum { get; set; }

    public string? Filetypestr { get; set; }

    public string? Extension { get; set; }

    public string? Mimetype { get; set; }
}
