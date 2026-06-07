using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Webserviceurl
{
    public string Serviceprovider { get; set; } = null!;

    public string? Serviceurl { get; set; }

    public long? Flags { get; set; }

    public string? Datasourcename { get; set; }
}
