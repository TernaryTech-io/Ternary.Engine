using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Entitytype
{
    public long Entitytypenum { get; set; }

    public string? Etname { get; set; }

    public string? Etdescription { get; set; }

    public string? Etexttable { get; set; }

    public string? Etschemaname { get; set; }

    public long? Flags { get; set; }

    public string? Clrassemblyname { get; set; }

    public string? Clrtypename { get; set; }

    public string? Etdisplayname { get; set; }

    public string? Ettablename { get; set; }

    public string? Etgroupname { get; set; }

    public long? Etvisibility { get; set; }

    public long? Securitytypenum { get; set; }

    public long? Ettrackchanges { get; set; }

    public long? Eteventlogging { get; set; }

    public long? Etpublishedid { get; set; }

    public string? Uiclrassemblyname { get; set; }

    public string? Uiclrtypename { get; set; }

    public long? Etmodulevisibility { get; set; }

    public string? Queryclrtypename { get; set; }

    public long? Etminschemaver { get; set; }

    public long? Etmaxschemaver { get; set; }

    public long? Etpatchverdelta { get; set; }
}
