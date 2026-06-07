using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Formregionprop
{
    public long Formregionpropnum { get; set; }

    public long? Formregionnum { get; set; }

    public long? Proptype { get; set; }

    public string? Propvalue { get; set; }

    public long? Imageformrevnum { get; set; }
}
