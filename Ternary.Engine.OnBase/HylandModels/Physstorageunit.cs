using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Physstorageunit
{
    public long? Storagenum { get; set; }

    public long? Copynumber { get; set; }

    public string? Basepath { get; set; }

    public string? Extservertype { get; set; }

    public string? Extserveraddr { get; set; }

    public long? Extserverport { get; set; }

    public string? Extserverusername { get; set; }

    public string? Extserveruserpwd { get; set; }

    public long? Storagetype { get; set; }
}
