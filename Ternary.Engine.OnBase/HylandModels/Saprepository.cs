using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Saprepository
{
    public long Repositorynum { get; set; }

    public string? Saprepositoryname { get; set; }

    public string? Repositorydescr { get; set; }

    public long? Itemtypenum { get; set; }

    public long? Flags { get; set; }

    public string? Docclass { get; set; }

    public long? Destinationnum { get; set; }
}
