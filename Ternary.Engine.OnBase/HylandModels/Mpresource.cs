using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpresource
{
    public long Mpresourcenum { get; set; }

    public string? Mpresourcename { get; set; }

    public long? Mpresourcegrpnum { get; set; }

    public long? Status { get; set; }

    public long? Vendortype { get; set; }

    public string? Mplocation { get; set; }

    public long? Locationtype { get; set; }

    public long? Rating { get; set; }

    public long? Bandwidth { get; set; }

    public long? Flags { get; set; }

    public long? Obcapability { get; set; }
}
