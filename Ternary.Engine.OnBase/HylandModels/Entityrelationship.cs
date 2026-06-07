using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entityrelationship
{
    public long Etrelationshipnum { get; set; }

    public string? Etdisplayname { get; set; }

    public string? Ettypename { get; set; }

    public string? Etrelatedtypename { get; set; }

    public long? Etjointype { get; set; }

    public long? Etvisibility { get; set; }

    public long? Flags { get; set; }

    public long? Etminschemaver { get; set; }

    public long? Etmaxschemaver { get; set; }

    public long? Etpatchverdelta { get; set; }
}
