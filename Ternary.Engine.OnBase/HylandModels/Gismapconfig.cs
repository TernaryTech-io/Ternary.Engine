using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gismapconfig
{
    public long Gismapconfignum { get; set; }

    public string? Userportaluri { get; set; }

    public string? Userportaltokenuri { get; set; }

    public long? Geoaddressformat { get; set; }

    public long? Geomaxmatches { get; set; }

    public long? Geominscore { get; set; }

    public long? Mapzoomfactor { get; set; }

    public long? Mapzoomdelay { get; set; }

    public long? Mapwindowwidth { get; set; }

    public long? Mapwindowheight { get; set; }

    public string? Mapinitialextent { get; set; }

    public long? Mapextentwkidtype { get; set; }

    public long? Mapsearchextfactor { get; set; }

    public long? Usergroupnum { get; set; }

    public long? Flags { get; set; }

    public string? Runtmclientid { get; set; }

    public string? Runtmliccode { get; set; }

    public string? Runtmliccodeext { get; set; }
}
