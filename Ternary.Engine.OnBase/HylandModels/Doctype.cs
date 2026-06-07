using System;
using System.Collections.Generic;

namespace Ternary.Engine.OnBase.Models;

public partial class Doctype
{
    public long Itemtypenum { get; set; }

    public string? Itemtypename { get; set; }

    public long? Itrevnum { get; set; }

    public long? Itemtypegroupnum { get; set; }

    public long? Filetypenum { get; set; }

    public long? Compressfile { get; set; }

    public string? Autonamestring { get; set; }

    public long? Inuse { get; set; }

    public long? Diskgroupnum { get; set; }

    public long? Displaythumbs { get; set; }

    public long? Numrows { get; set; }

    public long? Isdocrevisionable { get; set; }

    public long? Docsourceflag { get; set; }

    public long? Imagewindowflags { get; set; }

    public long? Uiflags { get; set; }

    public long? Itemtypeflags { get; set; }

    public long? Revisablebyinst { get; set; }

    public long? Itemtypeflags2 { get; set; }
}
