using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Barcodeformat
{
    public long Barformatnum { get; set; }

    public string? Barformatname { get; set; }

    public long? Barcodetype { get; set; }

    public long? Flags { get; set; }
}
