using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Commtable
{
    public long Commnum { get; set; }

    public string? Commname { get; set; }

    public long? Autoconnect { get; set; }

    public long? Baud { get; set; }

    public long? Commlink { get; set; }

    public long? Commport { get; set; }

    public long? Datalength { get; set; }

    public string? Defaultphone { get; set; }

    public long? Emultype { get; set; }

    public long? Fontnum { get; set; }

    public long? Handshake { get; set; }

    public string? Iccpath { get; set; }

    public string? Modeminit { get; set; }

    public long? Parity { get; set; }

    public long? Stopbits { get; set; }

    public string? Telnethost { get; set; }

    public long? Telnetport { get; set; }

    public long? Transfertype { get; set; }

    public string? Keymappath { get; set; }

    public string? Rumbaname { get; set; }
}
