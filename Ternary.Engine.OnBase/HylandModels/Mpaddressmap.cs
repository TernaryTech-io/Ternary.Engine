using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Mpaddressmap
{
    public long Mpaddressmapnum { get; set; }

    public string? Mpaddressmapname { get; set; }

    public long? Addresstype { get; set; }

    public string? Mpnetworkaddress { get; set; }

    public string? Mpnetworkaddressmask { get; set; }

    public string? Mpdistaddress { get; set; }

    public long? Flags { get; set; }
}
