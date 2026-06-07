using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class S3dgabadfile
{
    public long Filenum { get; set; }

    public long? S3dgajobnum { get; set; }

    public DateTime? Datefound { get; set; }

    public long? Errortype { get; set; }

    public string? Lasterror { get; set; }
}
