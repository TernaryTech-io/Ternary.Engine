using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7listenerlog
{
    public long Hl7listenerlognum { get; set; }

    public long? Processtype { get; set; }

    public DateTime? Logdate { get; set; }

    public string? Logmessage { get; set; }

    public string? Hl7source { get; set; }

    public long? Flags { get; set; }

    public string? Controlid { get; set; }

    public string? Onbasecontrolid { get; set; }

    public long? Status { get; set; }

    public long? Contexttype { get; set; }
}
