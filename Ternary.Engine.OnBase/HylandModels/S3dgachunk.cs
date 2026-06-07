using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class S3dgachunk
{
    public long S3dgachunknum { get; set; }

    public long? S3dgajobnum { get; set; }

    public long? Chunkstatus { get; set; }

    public DateTime? Startcriteria { get; set; }

    public DateTime? Endcriteria { get; set; }

    public long? Filesprocessed { get; set; }

    public long? Badfilesfound { get; set; }

    public long? Kbytesdownloaded { get; set; }

    public long? Missingchecksums { get; set; }
}
