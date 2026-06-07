using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Geolocwvobj
{
    public long? Objectid { get; set; }

    public long? Classid { get; set; }

    public long? Geolatitude { get; set; }

    public long? Geolongitude { get; set; }

    public long? Accuracy { get; set; }

    public long? Geolocwvnum { get; set; }

    public long? Altitude { get; set; }

    public long? Verticalaccuracy { get; set; }

    public long? Bearing { get; set; }

    public long? Valueset { get; set; }

    public long? Geolocwvdatasource { get; set; }

    public DateTime? Timestamp { get; set; }

    public long? Flags { get; set; }
}
