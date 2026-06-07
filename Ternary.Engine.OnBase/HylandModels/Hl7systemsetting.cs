using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Hl7systemsetting
{
    public long? Hl7processtimerinterval { get; set; }

    public long? Hl7logtodiagconsole { get; set; }

    public long? Hl7eventlogsortorder { get; set; }

    public long? Hl7eventlogwindays { get; set; }

    public long? Flags { get; set; }

    public long? Adminusernum { get; set; }

    public long? Charsperline { get; set; }

    public long? Txreplayitemtypenum { get; set; }

    public long? H17listenerlogretention { get; set; }

    public string? Structuredsettings { get; set; }

    public string? Hl7defaultdumppath { get; set; }
}
