using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class S3dgcschunk
{
    public long S3dgcschunknum { get; set; }

    public long? S3dgcsjobnum { get; set; }

    public long? Chunkstatus { get; set; }

    public DateTime? Startcriteria { get; set; }

    public DateTime? Endcriteria { get; set; }
}
