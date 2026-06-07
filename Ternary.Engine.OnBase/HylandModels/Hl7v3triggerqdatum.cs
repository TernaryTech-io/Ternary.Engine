using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7v3triggerqdatum
{
    public long Hl7v3trigqdatanum { get; set; }

    public long? Hl7v3triggerqnum { get; set; }

    public string? Hl7v3name { get; set; }

    public string? Hl7v3value { get; set; }

    public DateTime? Createddate { get; set; }

    public string? Createdappname { get; set; }

    public DateTime? Updateddate { get; set; }

    public string? Updatedappname { get; set; }
}
