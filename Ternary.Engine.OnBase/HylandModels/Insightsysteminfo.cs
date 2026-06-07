using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Insightsysteminfo
{
    public string? Environmentguid { get; set; }

    public string? Clientid { get; set; }

    public string? Clientsecret { get; set; }

    public string? Sourceguid { get; set; }

    public long? Secretcryptotype { get; set; }

    public string? Secretinitvectordata { get; set; }

    public long? Flags { get; set; }
}
