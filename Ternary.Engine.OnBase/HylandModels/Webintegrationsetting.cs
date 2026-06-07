using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Webintegrationsetting
{
    public long Webintsettingsnum { get; set; }

    public long? Servicetype { get; set; }

    public long? Integrationtype { get; set; }

    public string? Clientid { get; set; }

    public string? Clientsecret { get; set; }

    public string? Serverurl { get; set; }

    public long? Authenticationtype { get; set; }

    public string? Mailacctusername { get; set; }

    public string? Mailacctpassword { get; set; }

    public string? Initvectordata { get; set; }

    public long? Cryptotype { get; set; }

    public long? Secretcryptotype { get; set; }

    public string? Secretinitvectordata { get; set; }

    public string? Redirecturi { get; set; }

    public string? Privatekey { get; set; }

    public long? Privatekeycryptotype { get; set; }

    public string? Privatekeyinitvectordata { get; set; }

    public string? Privatekeytext { get; set; }
}
