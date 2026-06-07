using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entityrepository
{
    public long Etrepositorynum { get; set; }

    public long? Seqnum { get; set; }

    public long? Etsourcetype { get; set; }

    public string? Clrassemblyname { get; set; }

    public string? Etresourcename { get; set; }

    public string? Eteddcontent { get; set; }

    public long? Producttype { get; set; }

    public long? Versionnum { get; set; }

    public long? Flags { get; set; }
}
