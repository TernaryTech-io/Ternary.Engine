using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dek
{
    public long Id { get; set; }

    public string Encryptedkey { get; set; } = null!;

    public string Iv { get; set; } = null!;

    public long Algorithm { get; set; }

    public long Kekid { get; set; }

    public DateTimeOffset Lastmodification { get; set; }

    public virtual Kek Kek { get; set; } = null!;

    public virtual S3storagesystem? S3storagesystem { get; set; }
}
