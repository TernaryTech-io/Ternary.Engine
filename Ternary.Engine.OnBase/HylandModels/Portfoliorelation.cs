using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Portfoliorelation
{
    public long Portfoliorelnum { get; set; }

    public string? Relationname { get; set; }

    public long? Sourcecontenttype { get; set; }

    public long? Destcontenttype { get; set; }

    public long? Destcontenttypeid { get; set; }

    public long? Flags { get; set; }

    public long? Destcontclassnum { get; set; }

    public long? Sourcecontentypeid { get; set; }

    public long? Srccontclassnum { get; set; }

    public long? Relationshiptype { get; set; }

    public long? Sourceappnum { get; set; }

    public long? Destappnum { get; set; }

    public long? Institution { get; set; }
}
