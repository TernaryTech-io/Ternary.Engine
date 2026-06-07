using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Fpaidpprofile
{
    public long Idpprofilenum { get; set; }

    public string? Idpprofilename { get; set; }

    public string? Idpbaseurl { get; set; }

    public string? Idptenantname { get; set; }

    public string? Idpclientid { get; set; }

    public string? Idpclientsecret { get; set; }

    public string? Idpscopes { get; set; }

    public long? Cryptotype { get; set; }

    public string? Initvectordata { get; set; }

    public long? Flags { get; set; }
}
