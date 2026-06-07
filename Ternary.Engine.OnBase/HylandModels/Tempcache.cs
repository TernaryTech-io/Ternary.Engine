using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Tempcache
{
    public long Tempcachenum { get; set; }

    public string? Cachename { get; set; }

    public string? Cachedir { get; set; }

    public long? Institution { get; set; }

    public long? Cachetype { get; set; }

    public long? Subfoldernum { get; set; }

    public long? Retentionpolicy { get; set; }

    public long? Flags { get; set; }

    public long? Keyidentifier { get; set; }
}
