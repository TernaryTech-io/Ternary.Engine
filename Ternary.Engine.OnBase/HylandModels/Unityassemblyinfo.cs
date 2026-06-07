using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Unityassemblyinfo
{
    public long Unityassemblynum { get; set; }

    public string? Assemblyfullname { get; set; }

    public string? Assemblydispname { get; set; }

    public string? Assemblyfilename { get; set; }

    public string? Assemblydesc { get; set; }

    public long? Assemblytype { get; set; }

    public string? Hashcode { get; set; }

    public DateTime? Lastmodified { get; set; }

    public string? Runtimeversion { get; set; }

    public long? Assemblystatus { get; set; }
}
