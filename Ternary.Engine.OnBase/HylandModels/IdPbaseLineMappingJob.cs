using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class IdPbaseLineMappingJob
{
    public string JobId { get; set; } = null!;

    public string ExternalProviderId { get; set; } = null!;

    public string? ResolvedUsers { get; set; }

    public int Status { get; set; }

    public string Progress { get; set; } = null!;

    public string TriggeredBy { get; set; } = null!;

    public DateTimeOffset JobStartTime { get; set; }

    public DateTimeOffset? JobEndTime { get; set; }
}
