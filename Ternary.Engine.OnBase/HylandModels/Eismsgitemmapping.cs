using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eismsgitemmapping
{
    public long Eismsgitemmapnum { get; set; }

    public long? Eismsgitemtypenum { get; set; }

    public string? Mappingname { get; set; }

    public long? Mapdatablobnum { get; set; }

    public long? Flags { get; set; }
}
