using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Userfolderxitem
{
    public long Userfoldernum { get; set; }

    public long Itemnum { get; set; }

    public long Docrevnum { get; set; }

    public long Filetypenum { get; set; }

    public long? Flags { get; set; }

    public long? Seqnum { get; set; }
}
