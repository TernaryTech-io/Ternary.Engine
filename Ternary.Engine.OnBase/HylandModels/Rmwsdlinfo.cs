using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmwsdlinfo
{
    public long Wsdlconfigid { get; set; }

    public long? Baseconfigid { get; set; }

    public long? Objecttype { get; set; }

    public long? Objectid { get; set; }

    public long? Servicelocationid { get; set; }

    public string? Servicelocation { get; set; }

    public string? Wsdlusername { get; set; }

    public string? Wsdlpassword { get; set; }

    public long? Metadataprotocol { get; set; }

    public string? Customendpoint { get; set; }

    public long? Requesttimeout { get; set; }

    public string? Selectedcontract { get; set; }

    public string? Selectedmethod { get; set; }

    public string? Selectedendpoint { get; set; }

    public string? Rmdescription { get; set; }

    public long? Flags { get; set; }

    public long? Obblobnum { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }
}
