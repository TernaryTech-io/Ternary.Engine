using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cache
{
    public long Cachenum { get; set; }

    public string? Cachename { get; set; }

    public string? Cachedirpath { get; set; }

    public long? Cachethreshold { get; set; }

    public long? Cachedkbytes { get; set; }

    public long? Cachehiwater { get; set; }

    public long? Cachelowater { get; set; }

    public DateTime? Cachepurgedate { get; set; }
}
