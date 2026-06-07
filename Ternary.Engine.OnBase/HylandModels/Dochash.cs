using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dochash
{
    public long Itemnum { get; set; }

    public long Docrevnum { get; set; }

    public long Filetypenum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Hashdate { get; set; }

    public string? Hashdata { get; set; }
}
