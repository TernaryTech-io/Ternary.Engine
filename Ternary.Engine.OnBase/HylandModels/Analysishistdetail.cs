using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Analysishistdetail
{
    public long? Analysishistnum { get; set; }

    public string? Filepath { get; set; }

    public long? Physicalplatternum { get; set; }

    public long? Errortype { get; set; }

    public long? Repaired { get; set; }

    public string? Analysiserror { get; set; }
}
