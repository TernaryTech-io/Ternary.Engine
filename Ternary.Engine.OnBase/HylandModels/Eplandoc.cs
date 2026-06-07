using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eplandoc
{
    public long Eplandocnum { get; set; }

    public long? Epprojectnum { get; set; }

    public long? Itemnum { get; set; }

    public long? Docrevnum { get; set; }

    public long? Flags { get; set; }

    public long? Epdisciplinenum { get; set; }

    public long? Epsubtypenum { get; set; }

    public string? Epexternalidentifier { get; set; }

    public long? Epreviewcyclenum { get; set; }

    public long? Eptypeplandoc { get; set; }

    public long? Ispublished { get; set; }

    public long? Deleteditem { get; set; }

    public string? Epdescription { get; set; }
}
