using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Obimportlog
{
    public long Obimportnum { get; set; }

    public DateTime? Dateimported { get; set; }

    public long? Usernum { get; set; }

    public long? Flags { get; set; }

    public long? Obpurged { get; set; }

    public long? Importcontext { get; set; }
}
