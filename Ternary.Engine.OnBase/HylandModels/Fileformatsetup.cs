using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fileformatsetup
{
    public long Fileformatnum { get; set; }

    public long? Fffileformat { get; set; }

    public long? Filecompression { get; set; }

    public long? Filelinesperstrip { get; set; }

    public long? FfOptions { get; set; }
}
