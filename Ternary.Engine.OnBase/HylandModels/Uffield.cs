using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Uffield
{
    public long Ufformnum { get; set; }

    public long Formrevnum { get; set; }

    public string? Ufparentkey { get; set; }

    public string Uffieldkey { get; set; } = null!;

    public long? Fielddatatype { get; set; }

    public long? Fieldtype { get; set; }

    public long? Dstype { get; set; }

    public long? Fieldsource { get; set; }

    public string? Fieldsourceparam { get; set; }

    public long? Flags { get; set; }

    public string? Ufmask { get; set; }

    public string? Maskstatics { get; set; }

    public long? Length { get; set; }

    public string? Ufrange { get; set; }

    public string? Defaultval { get; set; }

    public long? Ufdatasetnum { get; set; }

    public long? Currencyformatnum { get; set; }

    public string? Datasetparent { get; set; }

    public long? Sigdefnum { get; set; }
}
