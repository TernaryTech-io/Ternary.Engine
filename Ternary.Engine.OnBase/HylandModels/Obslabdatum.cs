using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Obslabdatum
{
    public long? Itemnum { get; set; }

    public long? Obslabnum { get; set; }

    public long? Obslabfieldnum { get; set; }

    public string? Obslabdatavalue { get; set; }

    public decimal? Emrviewid { get; set; }

    public decimal? Emrtermid { get; set; }

    public long? Iscompleted { get; set; }

    public DateTime? Datecompleted { get; set; }
}
