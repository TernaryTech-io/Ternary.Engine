using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Claimscache
{
    public string Id { get; set; } = null!;

    public byte[] Value { get; set; } = null!;

    public DateTimeOffset ExpiresAtTime { get; set; }

    public long? SlidingExpirationInSeconds { get; set; }

    public DateTimeOffset? AbsoluteExpiration { get; set; }
}
