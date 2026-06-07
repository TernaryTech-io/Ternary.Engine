using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Wfapitask
{
    public long Apitasknum { get; set; }

    public string? Apitaskname { get; set; }

    public long? Onfoundtasklistnum { get; set; }

    public long? Onnotfoundtasklistnum { get; set; }

    public long? Wfcontentype { get; set; }

    public long? Portfoliorelnum { get; set; }

    public long? Propbagtype { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Rmapplicationid { get; set; }

    public long? Classid { get; set; }

    public long? Configversion { get; set; }

    public long? Flags { get; set; }
}
