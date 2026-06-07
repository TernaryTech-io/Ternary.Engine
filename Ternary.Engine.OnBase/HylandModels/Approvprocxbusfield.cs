using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Approvprocxbusfield
{
    public long Approvalprocnum { get; set; }

    public long Businessfieldnum { get; set; }

    public long Businessfieldtype { get; set; }

    public string? Businessfieldname { get; set; }

    public long? Flags { get; set; }
}
