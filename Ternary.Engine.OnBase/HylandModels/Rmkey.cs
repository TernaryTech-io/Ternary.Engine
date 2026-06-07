using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmkey
{
    public string Keyname { get; set; } = null!;

    public long? Keyvalue { get; set; }
}
