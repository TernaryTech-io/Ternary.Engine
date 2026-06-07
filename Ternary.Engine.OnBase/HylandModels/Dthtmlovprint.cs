using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Dthtmlovprint
{
    public long Itemtypenum { get; set; }

    public long Itrevnum { get; set; }

    public long? Htmloverlaynum { get; set; }

    public string Htmltagname { get; set; } = null!;

    public long? Htmlleftinches { get; set; }

    public long? Htmltopinches { get; set; }

    public long? Htmlrightinches { get; set; }

    public long? Htmlbottominches { get; set; }

    public long? Fontnum { get; set; }
}
