using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rgexam
{
    public long Rgexamnum { get; set; }

    public string? Rgexamname { get; set; }

    public long? Templateitemnum { get; set; }

    public long? Createdby { get; set; }

    public long? Flags { get; set; }
}
