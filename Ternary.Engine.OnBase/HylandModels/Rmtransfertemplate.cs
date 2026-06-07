using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Rmtransfertemplate
{
    public long Transfertemplateid { get; set; }

    public string? Rootelementname { get; set; }

    public long? Templatetype { get; set; }

    public string? Transfertemplatename { get; set; }
}
