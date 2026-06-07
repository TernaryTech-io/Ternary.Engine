using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Eisgwwebservice
{
    public long Eiswebservicenum { get; set; }

    public long? Webserviceprojnum { get; set; }

    public string? Webservicename { get; set; }

    public string? Virtualdirname { get; set; }

    public string? Wsdlservicename { get; set; }

    public string? Uncpath { get; set; }

    public string? Altconnectionstr { get; set; }

    public DateTime? Lastmodified { get; set; }

    public long? Flags { get; set; }

    public string? Certificateinfo { get; set; }

    public string? Installupgradecode { get; set; }

    public long? Eisgwversion { get; set; }
}
