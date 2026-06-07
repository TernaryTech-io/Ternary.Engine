using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Kekeksalt
{
    public long Id { get; set; }

    public long Kekektype { get; set; }

    public string Kekekid { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public int Rounds { get; set; }

    public int Saltscheme { get; set; }
}
