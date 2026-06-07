using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapcertificate
{
    public long Authnum { get; set; }

    public string? Sapauthid { get; set; }

    public string? Certfile { get; set; }

    public long? Status { get; set; }

    public string? Version { get; set; }

    public long? Repositorynum { get; set; }
}
