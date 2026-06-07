using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Lbbanksite
{
    public string Siteid { get; set; } = null!;

    public string Bankid { get; set; } = null!;

    public string? Sitename { get; set; }

    public string? Bankname { get; set; }

    public string? Basestylesheet { get; set; }

    public string? Notifyphone { get; set; }

    public string? Notifyemail { get; set; }

    public string? Baseurl { get; set; }

    public string? Bankinternalid { get; set; }
}
