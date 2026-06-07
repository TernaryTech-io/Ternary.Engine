using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mfpdevice
{
    public long Mfpdevicenum { get; set; }

    public string? Mfpdeviceserial { get; set; }

    public long? Flags { get; set; }

    public string? Mfpdevicehost { get; set; }

    public string? Mfpdevicename { get; set; }
}
