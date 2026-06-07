using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Aatenant
{
    public long Aatenantnum { get; set; }

    public long? Aacustomernum { get; set; }

    public string? Installid { get; set; }

    public string? Tenantname { get; set; }

    public long? Systemtype { get; set; }

    public long? Environmenttype { get; set; }

    public long? Dbprovidertype { get; set; }

    public string? Dbproviderversion { get; set; }

    public long? Dbaahostnum { get; set; }

    public string? Dbinstancename { get; set; }

    public string? Dbdatabasename { get; set; }

    public long? Dbport { get; set; }

    public string? Dbversion { get; set; }

    public DateTime? Firstdeployed { get; set; }

    public long? Parentaatenantnum { get; set; }

    public DateTime? Effectivefrom { get; set; }

    public long? Flags { get; set; }
}
