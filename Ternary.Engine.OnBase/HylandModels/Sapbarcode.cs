using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapbarcode
{
    public long Itemnum { get; set; }

    public string? Barcode { get; set; }

    public long? Batchnum { get; set; }

    public long? Status { get; set; }

    public long? Errorstatus { get; set; }

    public string? Errordesc { get; set; }

    public long? Notified { get; set; }
}
