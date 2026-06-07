using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Sapkey
{
    public string Keyname { get; set; } = null!;

    public long? Keyvalue { get; set; }
}
