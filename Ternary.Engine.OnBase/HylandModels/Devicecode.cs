using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Devicecode
{
    public string Usercode { get; set; } = null!;

    public string Devicecode1 { get; set; } = null!;

    public string? Subjectid { get; set; }

    public string Clientid { get; set; } = null!;

    public DateTime Creationtime { get; set; }

    public DateTime Expiration { get; set; }

    public string Devicecodedata { get; set; } = null!;

    public string? Description { get; set; }

    public string? SessionId { get; set; }
}
