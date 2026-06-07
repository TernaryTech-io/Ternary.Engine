using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapbarcodeint
{
    public string? SapdocumentType { get; set; }

    public string? ObjectKey { get; set; }

    public string? SapobjectType { get; set; }

    public string Barcode { get; set; } = null!;

    public long? Processoptions { get; set; }

    public long? Itemtypenum { get; set; }

    public string? Errordesc { get; set; }

    public long? Notified { get; set; }
}
