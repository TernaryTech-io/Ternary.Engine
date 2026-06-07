using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tsquestion
{
    public long Tsquestionnum { get; set; }

    public long? Tsqcategorynum { get; set; }

    public string? Tsquestiontext { get; set; }

    public long? Tsquestiontype { get; set; }

    public long? Itemnum { get; set; }

    public long? Tsquestionauthornum { get; set; }

    public string? Tsquestionurl { get; set; }

    public long? Randomize { get; set; }

    public long? Finalnotrandom { get; set; }

    public string? Tags { get; set; }
}
