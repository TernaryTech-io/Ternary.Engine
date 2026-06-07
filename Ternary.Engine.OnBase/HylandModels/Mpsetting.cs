using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpsetting
{
    public long Mpsettingsnum { get; set; }

    public DateTime? Mpsystemsync { get; set; }

    public DateTime? Mpitemsync { get; set; }

    public long? Tokenlifetime { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Maxuploadbitrate { get; set; }

    public long? Captionitemtypenum { get; set; }
}
