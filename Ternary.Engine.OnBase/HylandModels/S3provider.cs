using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class S3provider
{
    public long S3providernum { get; set; }

    public string? S3providername { get; set; }

    public string? Addressurl { get; set; }

    public string? Accesskey { get; set; }

    public string? Secretkey { get; set; }

    public long? S3providertype { get; set; }

    public long? Cryptotype { get; set; }

    public long? Flags { get; set; }

    public string? Initvectordata { get; set; }

    public long? Allowedclockskew { get; set; }

    public string? S3region { get; set; }

    public string? Arn { get; set; }
}
