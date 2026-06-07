using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ihemimetype
{
    public long Ihemimetypenum { get; set; }

    public long? Ihecommunitynum { get; set; }

    public long? Filetypenum { get; set; }

    public string? Mimetype { get; set; }

    public long? Flags { get; set; }
}
