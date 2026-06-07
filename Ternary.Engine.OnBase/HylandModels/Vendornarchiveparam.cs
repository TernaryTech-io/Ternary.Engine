using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Vendornarchiveparam
{
    public long Vendornarchivenum { get; set; }

    public string Settingname { get; set; } = null!;

    public string? Settingvalue { get; set; }

    public long? Flags { get; set; }

    public long? Vendornarchparamtype { get; set; }
}
