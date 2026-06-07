using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Gifieldtype
{
    public long Gifieldtypenum { get; set; }

    public long? Giproctypenum { get; set; }

    public string? Etdisplayname { get; set; }

    public long? Etlength { get; set; }

    public long? Etdatatypecode { get; set; }

    public long? Etdatasetnum { get; set; }

    public long? Flags { get; set; }
}
