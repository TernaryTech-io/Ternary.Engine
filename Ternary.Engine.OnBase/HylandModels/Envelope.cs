using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Envelope
{
    public long Envelopenum { get; set; }

    public string? Envelopename { get; set; }

    public long? Bitmapnum { get; set; }

    public long? Iconnum { get; set; }

    public long? Usernum { get; set; }

    public long? Flags { get; set; }

    public string? Labeltext { get; set; }
}
