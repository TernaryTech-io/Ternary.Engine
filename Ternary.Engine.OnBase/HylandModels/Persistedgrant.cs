using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Persistedgrant
{
    public string Reference { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Subjectid { get; set; }

    public string Clientid { get; set; } = null!;

    public DateTime Creationtime { get; set; }

    public DateTime? Expiration { get; set; }

    public string Tokendata { get; set; } = null!;

    public DateTime? ConsumedTime { get; set; }

    public string? Description { get; set; }

    public string? SessionId { get; set; }

    public long Id { get; set; }
}
