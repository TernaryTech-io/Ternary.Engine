using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Cryptoconfig
{
    public long? Versioncompat { get; set; }

    public long? Encryptionsuite { get; set; }

    public long? Enforcementlevel { get; set; }

    public long? Flags { get; set; }
}
