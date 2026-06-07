using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpchannel
{
    public long Mpchannelnum { get; set; }

    public string? Mpchannelname { get; set; }

    public long? Mpencodernum { get; set; }

    public long? Mpencodertype { get; set; }

    public string? Mpconfiguration { get; set; }

    public long? Mpactivedevicenum { get; set; }

    public DateTime? Datemodified { get; set; }

    public long? Dvrenabled { get; set; }

    public long? Dvrlength { get; set; }

    public long? Continuousstream { get; set; }

    public long? Overlayitemnum { get; set; }

    public long? Gpuenabled { get; set; }

    public long? Gpuposition { get; set; }

    public long? Gpustreams { get; set; }
}
