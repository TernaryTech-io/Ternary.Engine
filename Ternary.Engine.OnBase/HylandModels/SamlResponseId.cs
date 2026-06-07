using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class SamlResponseId
{
    public string SamlResponseId1 { get; set; } = null!;

    public DateTimeOffset ExpirationTimeStamp { get; set; }
}
