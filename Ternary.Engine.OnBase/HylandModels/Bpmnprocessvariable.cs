using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Bpmnprocessvariable
{
    public long? Processnum { get; set; }

    public long? Versionnum { get; set; }

    public long? Variablenum { get; set; }

    public string? Bpmnvariablename { get; set; }

    public string? Xsdfilename { get; set; }

    public string? Xsdnamespace { get; set; }

    public string? Xsddatatype { get; set; }

    public long? Flags { get; set; }
}
