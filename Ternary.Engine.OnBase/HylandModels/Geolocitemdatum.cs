using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Geolocitemdatum
{
    public long? Itemnum { get; set; }

    public long? Geolatitude { get; set; }

    public long? Geolongitude { get; set; }

    public long? Accuracy { get; set; }

    public long? Altitude { get; set; }

    public long? Verticalaccuracy { get; set; }

    public long? Bearing { get; set; }

    public long? Valuesset { get; set; }

    public long? Geolocitemdatasource { get; set; }

    public DateTime? Timestamp { get; set; }

    public long Geolocationnum { get; set; }

    public long? Flags { get; set; }
}
