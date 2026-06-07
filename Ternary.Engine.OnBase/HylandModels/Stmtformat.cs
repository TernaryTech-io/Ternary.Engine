using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Stmtformat
{
    public long Stmtformatnum { get; set; }

    public string? Stmtformatname { get; set; }

    public string? Uncpath { get; set; }

    public string? Uncbackpath { get; set; }

    public long? Flags { get; set; }
}
