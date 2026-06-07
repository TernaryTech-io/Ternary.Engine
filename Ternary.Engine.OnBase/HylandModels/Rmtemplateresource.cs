using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmtemplateresource
{
    public long Templateresnum { get; set; }

    public string? Resourcedata { get; set; }

    public string? Resourcefilename { get; set; }

    public long? Templatetype { get; set; }

    public long? Flags { get; set; }

    public DateTime? Lastmodified { get; set; }
}
