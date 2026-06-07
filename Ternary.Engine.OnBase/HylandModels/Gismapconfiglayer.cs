using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gismapconfiglayer
{
    public long Gismapcfglayernum { get; set; }

    public long? Gismapconfignum { get; set; }

    public long? Servicetype { get; set; }

    public long? Serviceauthtype { get; set; }

    public string? Querywhereclause { get; set; }

    public string? Queryoutfields { get; set; }

    public string? Servicedisplayname { get; set; }

    public long? Layeropacity { get; set; }

    public string? Serviceuri { get; set; }

    public string? Loginclientid { get; set; }

    public string? Passwordsecure { get; set; }

    public string? Serviceredirecturi { get; set; }

    public string? Querydateformat { get; set; }

    public long? Flags { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
