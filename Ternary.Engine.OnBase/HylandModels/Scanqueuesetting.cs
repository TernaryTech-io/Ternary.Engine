using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Scanqueuesetting
{
    public long Queuenum { get; set; }

    public long? Filenamecache { get; set; }

    public long? Jpegquality { get; set; }

    public long? Refreshfailed { get; set; }

    public long? Checkdiskimage { get; set; }

    public long? Sweepfullindex { get; set; }

    public long? Ocrinteract { get; set; }

    public long? Ocrheapsize { get; set; }

    public long? Ocrlanguage { get; set; }

    public long? Ocrpreprocess { get; set; }
}
