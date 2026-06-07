using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Unityassemblydatum
{
    public long Unityassemblynum { get; set; }

    public long Seqnum { get; set; }

    public long Datatype { get; set; }

    public long? Datalength { get; set; }

    public string? Assemblydata { get; set; }
}
