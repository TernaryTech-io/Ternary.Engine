using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rptdataproviderprop
{
    public long Rptprovidernum { get; set; }

    public string Propertyname { get; set; } = null!;

    public string? Propertyvalue { get; set; }

    public long? Propertytype { get; set; }

    public long Propertyseq { get; set; }

    public long? Flags { get; set; }

    public long? Recordinst { get; set; }
}
