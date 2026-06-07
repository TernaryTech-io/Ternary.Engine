using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Ialinkedaccount
{
    public string? Localiaid { get; set; }

    public long? Remotehsinum { get; set; }

    public string? Remoteiaid { get; set; }

    public DateTime? Consentexpiredate { get; set; }

    public long? Useridconfirmconsent { get; set; }

    public long? Iatype { get; set; }

    public DateTime? Linkeddate { get; set; }

    public long? Flags { get; set; }
}
