using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sequencexitem
{
    public long? Sequencenum { get; set; }

    public string? Filepath { get; set; }

    public long? Itemnum { get; set; }

    public long? Userbatchnum { get; set; }

    public long? Flags { get; set; }

    public string? Endorserstate { get; set; }

    public string? Endorserjuldate { get; set; }

    public string? Endorsercentury { get; set; }

    public long? Endorserenv { get; set; }

    public long? Endorserdoc { get; set; }
}
