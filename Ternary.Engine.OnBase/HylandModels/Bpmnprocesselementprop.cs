using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bpmnprocesselementprop
{
    public long? Processnum { get; set; }

    public long? Versionnum { get; set; }

    public long? Elementnum { get; set; }

    public string? Propertyname { get; set; }

    public string? Propertyvalue { get; set; }

    public long? Flags { get; set; }
}
