using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Module
{
    public string Moduleid { get; set; } = null!;

    public string? Modulename { get; set; }

    public string? Objectname { get; set; }

    public string? Friendlyname { get; set; }

    public long? Flags { get; set; }

    public string? Apiversion { get; set; }

    public string? Coreapiversion { get; set; }

    public string? Dbversion { get; set; }
}
