using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ufthemepart
{
    public long Ufthemenum { get; set; }

    public string Ufthemepartname { get; set; } = null!;

    public string? Ufthemepartvalue { get; set; }
}
