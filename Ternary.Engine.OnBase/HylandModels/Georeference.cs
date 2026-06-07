using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Georeference
{
    public long Geolayerid { get; set; }

    public long Geoobjectid { get; set; }

    public long Itemnum { get; set; }

    public long? Usernum { get; set; }

    public DateTime? Datestored { get; set; }

    public string? Geostaticlinkattr { get; set; }
}
