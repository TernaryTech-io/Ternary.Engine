using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ocrlog
{
    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Itempagenum { get; set; }

    public long? Context { get; set; }

    public long? Ocrlogcode { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Ocrloginfo { get; set; }

    public long? Ocrformatid { get; set; }

    public long? Flags { get; set; }
}
