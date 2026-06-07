using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doctypexmlstyle
{
    public long Xmlstylenum { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Itrevnum { get; set; }

    public long? Institution { get; set; }

    public long? Seqnum { get; set; }

    public string? Stylename { get; set; }

    public string? Stylepath { get; set; }

    public string? Backupstylepath { get; set; }

    public long? Flags { get; set; }

    public string? Printstylepath { get; set; }

    public string? Printbkstylepath { get; set; }
}
