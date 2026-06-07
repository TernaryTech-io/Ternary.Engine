using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class S3storagesystem
{
    public long Storagesystemid { get; set; }

    public string Url { get; set; } = null!;

    public string Bucket { get; set; } = null!;

    public string Accesskey { get; set; } = null!;

    public string Secretkey { get; set; } = null!;

    public long Flags { get; set; }

    public int Encryption { get; set; }

    public string Region { get; set; } = null!;

    public long? Dekid { get; set; }

    public int Ivscheme { get; set; }

    public string? Ivseeddata { get; set; }

    public virtual Dek? Dek { get; set; }

    public virtual Storagesystem Storagesystem { get; set; } = null!;
}
