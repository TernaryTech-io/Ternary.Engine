using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Testsystemhist
{
    public string Destinationguid { get; set; } = null!;

    public string? Destinstallid { get; set; }

    public long? Status { get; set; }

    public DateTime? Datecreated { get; set; }
}
