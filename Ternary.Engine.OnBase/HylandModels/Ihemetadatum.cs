using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ihemetadatum
{
    public long? Itemnum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Docrevnum { get; set; }

    public string? Ihedocuuid { get; set; }

    public long? Mimetypecodenum { get; set; }

    public long? Ihecommunitynum { get; set; }

    public long? Flags { get; set; }

    public string? Ihehashvalue { get; set; }

    public long? Ihefilesize { get; set; }

    public string? Ihedocuniqueid { get; set; }
}
