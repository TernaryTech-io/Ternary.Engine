using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class S3bucket
{
    public long S3bucketnum { get; set; }

    public string? S3bucketname { get; set; }

    public long? S3providernum { get; set; }

    public long? Flags { get; set; }
}
