using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Viewtemplate
{
    public long Viewtemplatenum { get; set; }

    public string? Description { get; set; }

    public long? Vendornarchivenum { get; set; }

    public long? Notviewable { get; set; }

    public long? Flags { get; set; }
}
