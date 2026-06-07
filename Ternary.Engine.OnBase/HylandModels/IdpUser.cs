using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class IdpUser
{
    public string IdpUserId { get; set; } = null!;

    public string ExternalProviderId { get; set; } = null!;

    public string ExternalUserId { get; set; } = null!;

    public string? ScimUserId { get; set; }

    public DateTimeOffset LastUpdatedDatetime { get; set; }
}
